using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.DB;

namespace API.Controllers.DB
{
    [Route("api/[controller]")]
    [ApiController]
    public class EcategoriesController : ControllerBase
    {
        private readonly DBContext _context;

        public EcategoriesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Ecategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ecategories>>> GetEcategories()
        {
            return await _context.Ecategories.ToListAsync();
        }

        // GET: api/Ecategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ecategories>> GetEcategories(long id)
        {
            var ecategories = await _context.Ecategories.FindAsync(id);

            if (ecategories == null)
            {
                return NotFound();
            }

            return ecategories;
        }

        // PUT: api/Ecategories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEcategories(long id, Ecategories ecategories)
        {
            if (id != ecategories.EcategoriesId)
            {
                return BadRequest();
            }

            _context.Entry(ecategories).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EcategoriesExists(id))
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

        // POST: api/Ecategories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ecategories>> PostEcategories(Ecategories ecategories)
        {
            _context.Ecategories.Add(ecategories);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EcategoriesExists(ecategories.EcategoriesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEcategories", new { id = ecategories.EcategoriesId }, ecategories);
        }

        // DELETE: api/Ecategories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ecategories>> DeleteEcategories(long id)
        {
            var ecategories = await _context.Ecategories.FindAsync(id);
            if (ecategories == null)
            {
                return NotFound();
            }

            _context.Ecategories.Remove(ecategories);
            await _context.SaveChangesAsync();

            return ecategories;
        }

        private bool EcategoriesExists(long id)
        {
            return _context.Ecategories.Any(e => e.EcategoriesId == id);
        }
    }
}
