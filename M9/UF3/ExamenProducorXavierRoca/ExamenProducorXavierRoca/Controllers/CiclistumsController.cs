using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExamenProducorXavierRoca.Models;

namespace ExamenProducorXavierRoca.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CiclistumsController : ControllerBase
    {
        private readonly CiclismeContext _context;

        public CiclistumsController(CiclismeContext context)
        {
            _context = context;
        }

        // GET: api/Ciclistums
        [Route("api/Ciclistum")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ciclistum>>> GetCiclista()
        {
            return await _context.Ciclista.ToListAsync();
        }

        // GET: api/Ciclistums/5
        //[Route("api/Ciclistum/{id:int}")]
        //[HttpGet()]
        //public async Task<ActionResult<Ciclistum>> GetCiclistum(short id)
        //{
        //    var ciclistum = await _context.Ciclista.FindAsync(id);

        //    if (ciclistum == null)
        //    {
        //        return NotFound();
        //    }

        //    return ciclistum;
        //}

        // PUT: api/Ciclistums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Route("api/Ciclistum/{id}")]
        [HttpPut()]
        public async Task<IActionResult> PutCiclistum(short id, Ciclistum ciclistum)
        {
            if (id != ciclistum.Dorsal)
            {
                return BadRequest();
            }

            _context.Entry(ciclistum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CiclistumExists(id))
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

        // POST: api/Ciclistums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Route("api/Ciclistum")]
        [HttpPost]
        public async Task<ActionResult<Ciclistum>> PostCiclistum(Ciclistum ciclistum)
        {
            _context.Ciclista.Add(ciclistum);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CiclistumExists(ciclistum.Dorsal))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCiclistum", new { id = ciclistum.Dorsal }, ciclistum);
        }

        // DELETE: api/Ciclistums/5
        [Route("api/Ciclistum/{id}")]
        [HttpDelete()]
        public async Task<IActionResult> DeleteCiclistum(short id)
        {
            var ciclistum = await _context.Ciclista.FindAsync(id);
            if (ciclistum == null)
            {
                return NotFound();
            }

            _context.Ciclista.Remove(ciclistum);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [Route("api/Ciclistum/{nom}")]
        [HttpGet()]
        public async Task<ActionResult<List<Ciclistum>>> GetCiclistesNom(String nom)
        {
            var ciclistes = await _context.Ciclista.Where(a => a.Nombre.Contains(nom)).OrderBy(a => a.Nombre).ToListAsync();

            return ciclistes;
        }

        [Route("api/Ciclistum/{edat:int}")]
        [HttpGet()]
        public async Task<ActionResult<List<Ciclistum>>> GetCiclistesEdat(int edat)
        {
            var ciclistes = await _context.Ciclista.Where(a => a.Edad == edat).OrderBy(a => a.Edad).ThenBy(a => a.Nombre).ToListAsync();

            return ciclistes;
        }

        [Route("api/Ciclistum/{id1:int}/{id2:int}")]
        [HttpGet()]
        public async Task<ActionResult<List<Ciclistum>>> GetCiclistesEntreDosEdats(int id1, int id2)
        {
            var ciclistes = await _context.Ciclista.Where(a => a.Edad >= id1 && a.Edad <= id2).OrderBy(a => a.Edad).ThenBy(a => a.Nombre).ToListAsync();

            return ciclistes;
        }

        [Route("api/Equipo/{equip}")]
        [HttpGet()]
        public async Task<ActionResult<List<Ciclistum>>> GetCiclistesDeUnEquip(String equip)
        {
            var ciclistes = await _context.Equipos.Where(a => a.Nomeq.Equals(equip)).SelectMany(a=>a.Ciclista).OrderBy(a => a.Nombre).ToListAsync();

            return ciclistes;
        }

        [Route("api/Maillot/{etapa:int}")]
        [HttpGet()]
        public async Task<ActionResult<List<Ciclistum>>> GetCiclistesGuanyadorsDeLEtapa(int etapa)
        {
            var ciclistes = await _context.Etapas.Where(a => a.Netapa == etapa).SelectMany(a => a.Llevars).Select(a=>a.DorsalNavigation).Distinct().OrderBy(a => a.Nombre).ToListAsync();

            return ciclistes;
        }

        [Route("api/Maillot/{codigo}")]
        [HttpGet()]
        public async Task<ActionResult<List<Ciclistum>>> GetCiclistesGuanyadorsDelMaillot(String codigo)
        {
            var ciclistes = await _context.Maillots.Where(a => a.Codigo.Equals(codigo)).SelectMany(a => a.Llevars).Select(a => a.DorsalNavigation).Distinct().OrderBy(a => a.Nombre).ToListAsync();

            return ciclistes;
        }

        [Route("api/Etapa/{id:int}")]
        [HttpGet()]
        public async Task<ActionResult<List<Etapa>>> GetEtapa(int id)
        {
            var etapa = await _context.Etapas.Where(a => a.Netapa == id).ToListAsync();

            return etapa;
        }

        [Route("api/Etapa/{b}")]
        [HttpGet()]
        public async Task<ActionResult<List<Etapa>>> GetEtapaAmbPort(Boolean b)
        {
            if (b)
            {
                var etapa = await _context.Puertos.Select(a=>a.NetapaNavigation).Distinct().OrderBy(a=>a.Netapa).ToListAsync();

                return etapa;
            }
            else
            {
                var etapa = await _context.Etapas.Where(a => a.Puertos.Count() == 0).OrderBy(a => a.Netapa).ToListAsync();

                return etapa;
            }
           
        }



        private bool CiclistumExists(short id)
        {
            return _context.Ciclista.Any(e => e.Dorsal == id);
        }
    }
}
