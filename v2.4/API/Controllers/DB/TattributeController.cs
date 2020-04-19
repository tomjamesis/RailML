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
    public class TattributeController : ControllerBase
    {
        private readonly DBContext _context;

        public TattributeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tattribute
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tattribute>>> GetTattribute()
        {
            return await _context.Tattribute.ToListAsync();
        }

        // GET: api/Tattribute/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tattribute>> GetTattribute(long id)
        {
            var tattribute = await _context.Tattribute.FindAsync(id);

            if (tattribute == null)
            {
                return NotFound();
            }

            return tattribute;
        }

        // PUT: api/Tattribute/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTattribute(long id, Tattribute tattribute)
        {
            if (id != tattribute.TattributeId)
            {
                return BadRequest();
            }

            _context.Entry(tattribute).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TattributeExists(id))
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

        // POST: api/Tattribute
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tattribute>> PostTattribute(Tattribute tattribute)
        {
            _context.Tattribute.Add(tattribute);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TattributeExists(tattribute.TattributeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTattribute", new { id = tattribute.TattributeId }, tattribute);
        }

        // DELETE: api/Tattribute/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tattribute>> DeleteTattribute(long id)
        {
            var tattribute = await _context.Tattribute.FindAsync(id);
            if (tattribute == null)
            {
                return NotFound();
            }

            _context.Tattribute.Remove(tattribute);
            await _context.SaveChangesAsync();

            return tattribute;
        }

        private bool TattributeExists(long id)
        {
            return _context.Tattribute.Any(e => e.TattributeId == id);
        }
    }
}
