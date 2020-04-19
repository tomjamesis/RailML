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
    public class TinfrastructureController : ControllerBase
    {
        private readonly DBContext _context;

        public TinfrastructureController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tinfrastructure
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tinfrastructure>>> GetTinfrastructure()
        {
            return await _context.Tinfrastructure.ToListAsync();
        }

        // GET: api/Tinfrastructure/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tinfrastructure>> GetTinfrastructure(short id)
        {
            var tinfrastructure = await _context.Tinfrastructure.FindAsync(id);

            if (tinfrastructure == null)
            {
                return NotFound();
            }

            return tinfrastructure;
        }

        // PUT: api/Tinfrastructure/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTinfrastructure(short id, Tinfrastructure tinfrastructure)
        {
            if (id != tinfrastructure.TinfrastructureId)
            {
                return BadRequest();
            }

            _context.Entry(tinfrastructure).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TinfrastructureExists(id))
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

        // POST: api/Tinfrastructure
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tinfrastructure>> PostTinfrastructure(Tinfrastructure tinfrastructure)
        {
            _context.Tinfrastructure.Add(tinfrastructure);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TinfrastructureExists(tinfrastructure.TinfrastructureId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTinfrastructure", new { id = tinfrastructure.TinfrastructureId }, tinfrastructure);
        }

        // DELETE: api/Tinfrastructure/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tinfrastructure>> DeleteTinfrastructure(short id)
        {
            var tinfrastructure = await _context.Tinfrastructure.FindAsync(id);
            if (tinfrastructure == null)
            {
                return NotFound();
            }

            _context.Tinfrastructure.Remove(tinfrastructure);
            await _context.SaveChangesAsync();

            return tinfrastructure;
        }

        private bool TinfrastructureExists(short id)
        {
            return _context.Tinfrastructure.Any(e => e.TinfrastructureId == id);
        }
    }
}
