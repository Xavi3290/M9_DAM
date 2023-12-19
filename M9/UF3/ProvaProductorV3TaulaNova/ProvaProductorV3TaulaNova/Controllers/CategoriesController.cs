using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProvaProductorV3TaulaNova.Models;

namespace ProvaProductorV3TaulaNova.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly NorthwindContext _context;

        public CategoriesController(NorthwindContext context)
        {
            _context = context;
        }

        // GET: api/Categories
        [Route("api/Category")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        // GET: api/Categories/5
        [Route("api/Category/{id:int}")]
        [HttpGet()]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Route("api/Category/{id}")]
        [HttpPut()]
        public async Task<IActionResult> PutCategory(int id, Category category)
        {
            if (id != category.CategoryId)
            {
                return BadRequest();
            }

            _context.Entry(category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(id))
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

        // POST: api/Categories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Route("api/Category")]
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategory", new { id = category.CategoryId }, category);
        }

        // DELETE: api/Categories/5
        [Route("api/Category/{id}")]
        [HttpDelete()]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Mostrar ordenats per nom les categories que continguin un filtre (string, a la url)
        [Route("api/Category/{nom}")]
        [HttpGet()]
        public async Task<ActionResult<List<Category>>> GetCategory(String nom)
        {
            var category = await _context.Categories.Where(a=>a.CategoryName.Contains(nom)).OrderBy(a=>a.CategoryName).ToListAsync();

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        // GET: api/Category/id/id Ex3 Mostrar ordenats per id les categories del id m al id n (es passen per la url:   .../api/generes/m/n)
        [Route("api/Category/{id1:int}/{id2:int}")]
        [HttpGet()]
        public async Task<ActionResult<List<Category>>> GetCategory(int id1, int id2)
        {
            var category = await _context.Categories.Where(a => a.CategoryId >= id1 && a.CategoryId <= id2).OrderBy(a => a.CategoryId).ToListAsync();

            return category;
        }

        // GET: api/Category/nom/nom Ex4 Mostrar ordenats per nom els gèneres entre dos noms (es passen per la url: .../api/Categories/nom1/nom2)
        [Route("api/Category/{nom1}/{nom2}")]
        [HttpGet()]
        public async Task<ActionResult<List<Category>>> GetCategoryBetweent2Names(String nom1, String nom2)
        {
            var category = await _context.Categories.Where(a => a.CategoryName.CompareTo(nom1) >= 0 && a.CategoryName.CompareTo(nom2) <= 0).OrderBy(a => a.CategoryName).ToListAsync();

            return category;
        }

        // GET: api/Tracks/codi Ex5  Mostrar ordenades per nom els productes d’una categoria (es passa per la url el codi del gènere)
        [Route("api/Products/{codi:int}")]
        [HttpGet()]
        public async Task<ActionResult<List<Product>>> GetProductsWithCodi(int codi)
        {
            var products = await _context.Products.Where(a => a.CategoryId == codi).OrderBy(a => a.ProductName).ToListAsync();

            return products;
        }

        // GET: api/Genres/nom Ex6  Mostrar ordenats per nom els customers que fan ordres amb productes d’una categoria (sense duplicats)
        [Route("api/Customers/{id:int}")]
        [HttpGet()]
        // Genres.Where(a=>a.Name.Contains("Jazz")).SelectMany(a=>a.Tracks).Select(a=>a.Album).Select(a=>a.Artist.Name).Distinct().OrderBy(a=>a)
        public async Task<ActionResult<List<Customer>>> GetCustomerstWithCategory(int id)
        {
            var orders = await _context.Categories.Where(a => a.CategoryId == id).SelectMany(a => a.Products).SelectMany(a => a.OrderDetails).Select(a => a.Order).Select(a=> a.Customer).Distinct().OrderBy(a => a.CompanyName).ToListAsync();

            return orders;
        }

        // GET: api/Genres/nom Ex7      7. Mostrar ordenats per nom les ciutats o els països amb clients que han comprat cançons d’un gènere (sense duplicats) [es passa per la url el codi del gènere i si es vol ciutats o països]
        [Route("api/CityOCountry/{id:int}/{c_p}")]
        [HttpGet()]
        public async Task<ActionResult<List<string>>> GetCustomerByCategoryCityOrCountry(int id, String c_p)
        {
            var client = new List<string>();
            if (c_p == "c")
            {
                client = await _context.Categories.Where(a => a.CategoryId == id).SelectMany(a => a.Products).SelectMany(a => a.OrderDetails).Select(a => a.Order).Select(a => a.Customer).Select(a => a.City).Distinct().OrderBy(a => a).ToListAsync();
            }
            else
            {
                client = await _context.Categories.Where(a => a.CategoryId == id).SelectMany(a => a.Products).SelectMany(a => a.OrderDetails).Select(a => a.Order).Select(a => a.Customer).Select(a => a.Country).Distinct().OrderBy(a => a).ToListAsync();
            }

            return client;
        }




        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CategoryId == id);
        }
    }
}
