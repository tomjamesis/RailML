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
    public class EcategoryController : ControllerBase
    {
        private readonly DBContext _context;

        public EcategoryController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Ecategory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ecategory>>> GetEcategory()
        {
            return await _context.Ecategory.ToListAsync();
        }

        // GET: api/Ecategory/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ecategory>> GetEcategory(short id)
        {
            var ecategory = await _context.Ecategory.FindAsync(id);

            if (ecategory == null)
            {
                return NotFound();
            }

            return ecategory;
        }

        // PUT: api/Ecategory/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEcategory(short id, Ecategory ecategory)
        {
            if (id != ecategory.EcategoryId)
            {
                return BadRequest();
            }

            _context.Entry(ecategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EcategoryExists(id))
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

        // POST: api/Ecategory
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ecategory>> PostEcategory(Ecategory ecategory)
        {
            _context.Ecategory.Add(ecategory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EcategoryExists(ecategory.EcategoryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEcategory", new { id = ecategory.EcategoryId }, ecategory);
        }

        // DELETE: api/Ecategory/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ecategory>> DeleteEcategory(short id)
        {
            var ecategory = await _context.Ecategory.FindAsync(id);
            if (ecategory == null)
            {
                return NotFound();
            }

            _context.Ecategory.Remove(ecategory);
            await _context.SaveChangesAsync();

            return ecategory;
        }

        private bool EcategoryExists(short id)
        {
            return _context.Ecategory.Any(e => e.EcategoryId == id);
        }
    }
}
