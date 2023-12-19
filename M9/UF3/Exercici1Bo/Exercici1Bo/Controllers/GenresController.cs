using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Exercici1Bo.Models;
using Microsoft.NET.StringTools;

namespace Exercici1Bo.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly ChinookContext _context;

        public GenresController(ChinookContext context)
        {
            _context = context;
        }

        // GET: api/Genres Ex1 Mostrar ordenats per nom tots els gèneres 
        [Route("api/genre")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genre>>> GetGenres()
        {
            return await _context.Genres.OrderBy(a => a.Name).ToListAsync();
        }

        // GET: api/Genres/5
        [Route("api/genre/{id:int}")]
        [HttpGet()]
        public async Task<ActionResult<Genre>> GetGenre(int id)
        {
            var genre = await _context.Genres.FindAsync(id);

            if (genre == null)
            {
                return NotFound();
            }

            return genre;
        }

        // PUT: api/Genres/5   Ex9  Inserir un nou gènere
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Route("api/genre/{id}")]
        [HttpPut()]
        public async Task<IActionResult> PutGenre(int id, Genre genre)
        {
            if (id != genre.GenreId)
            {
                return BadRequest();
            }

            _context.Entry(genre).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GenreExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Genres  ex10   Modificar un gènere ja existent 
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Route("api/genre")]
        [HttpPost]
        public async Task<ActionResult<Genre>> PostGenre(Genre genre)
        {
            _context.Genres.Add(genre);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGenre", new { id = genre.GenreId }, genre);
        }

        // DELETE: api/Genres/5 ex11  Esborrar un gènere ja existent (passant-li el codi per la url) [només si no té cançons]
        [Route("api/genre/{id}")]
        [HttpDelete()]
        public async Task<IActionResult> DeleteGenre(int id)
        {
            var genre = await _context.Genres.FindAsync(id);
            if (genre == null)
            {
                return NotFound();
            }

            _context.Genres.Remove(genre);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // GET: api/Genres/nom Ex2 Mostrar ordenats per nom els gèneres que continguin un filtre (string, a la url)
        [Route("api/genre/{nom}")]
        [HttpGet()]
        public async Task<ActionResult<List<Genre>>> GetGenre(String nom)
        {            
            var genres = await _context.Genres.Where(a => a.Name.Contains(nom)).OrderBy(a=>a.Name).ToListAsync();

            return genres;
        }

        // GET: api/Genres/id/id Ex3 Mostrar ordenats per id els gèneres del id m al id n (es passen per la url:   .../api/generes/m/n)
        [Route("api/genre/{id1:int}/{id2:int}")]
        [HttpGet()]
        public async Task<ActionResult<List<Genre>>> GetGenre(int id1,int id2)
        {
            var genres = await _context.Genres.Where(a => a.GenreId>=id1 && a.GenreId<=id2).OrderBy(a => a.GenreId).ToListAsync();

            return genres;
        }

        // GET: api/Genres/nom/nom Ex4 Mostrar ordenats per nom els gèneres entre dos noms (es passen per la url: .../api/generes/nom1/nom2)
        [Route("api/genre/{nom1}/{nom2}")]
        [HttpGet()]
        public async Task<ActionResult<List<Genre>>> GetGenreBetweent2Names(String nom1, String nom2)
        {
            var genres = await _context.Genres.Where(a => a.Name.CompareTo(nom1)>=0 && a.Name.CompareTo(nom2)<=0).OrderBy(a => a.Name).ToListAsync();

            return genres;
        }

        // GET: api/Tracks/codi Ex5  Mostrar ordenades per nom les cançons d’un gènere (es passa per la url el codi del gènere)
        [Route("api/tracks/{codi:int}")]
        [HttpGet()]
        public async Task<ActionResult<List<Track>>> GetTracksWithCodi(int codi)
        {
            var tracks = await _context.Tracks.Where(a => a.GenreId == codi).OrderBy(a=>a.Name).ToListAsync();

            return tracks;
        }

        // GET: api/Genres/nom Ex6  Mostrar ordenats per nom els artistes amb cançons d’un gènere (sense duplicats)
        [Route("api/artists/{id:int}")]
        [HttpGet()]
        // Genres.Where(a=>a.Name.Contains("Jazz")).SelectMany(a=>a.Tracks).Select(a=>a.Album).Select(a=>a.Artist.Name).Distinct().OrderBy(a=>a)
        public async Task<ActionResult<List<Artist>>> GetArtistWithGenere(int id)
        {
            var artistas = await _context.Genres.Where(a => a.GenreId == id).SelectMany(a => a.Tracks).Select(a => a.Album).Select(a => a.Artist).Distinct().OrderBy(a => a.Name).ToListAsync();

            return artistas;
        }

        // GET: api/Genres/nom Ex7      7. Mostrar ordenats per nom les ciutats o els països amb clients que han comprat cançons d’un gènere (sense duplicats) [es passa per la url el codi del gènere i si es vol ciutats o països]
        [Route("api/CityOCountry/{id:int}/{c_p}")]
        [HttpGet()]       
        public async Task<ActionResult<List<string>>> GetCustomerByGenre(int id, String c_p)
        {
            var client = new List<string>();
            if(c_p == "c")
            {
                client = await _context.Tracks.Where(a => a.GenreId == id).SelectMany(a => a.InvoiceLines).Select(a => a.Invoice.Customer).Select(a => a.City).Distinct().OrderBy(a => a).ToListAsync();
            }
            else
            {
                client = await _context.Tracks.Where(a => a.GenreId == id).SelectMany(a => a.InvoiceLines).Select(a => a.Invoice.Customer).Select(a => a.Country).Distinct().OrderBy(a => a).ToListAsync();
            }          

            return client;
        }

        // ex8 Select *
       //        from Invoice
        //      inner join InvoiceLine on InvoiceLine.InvoiceId = Invoice.InvoiceId
        //      inner join Track on Track.TrackId = InvoiceLine.TrackId
        //      where BillingCountry = 'Canada'


        // ex12

        //public async Task<IActionResult> DeleteGenreTree(int id)
        //{
        //    string StoredProc = "exec sp_GenreDeltree @id = " + id.ToString();
        //    _context.Database.ExecuteSqlRaw(StoredProc);
        //    return NoContent();
        //}

        private bool GenreExists(int id)
        {
            return _context.Genres.Any(e => e.GenreId == id);
        }

       


    }
}
