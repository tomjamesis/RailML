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
    public class TtrackCircuitBorderController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrackCircuitBorderController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrackCircuitBorder
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrackCircuitBorder>>> GetTtrackCircuitBorder()
        {
            return await _context.TtrackCircuitBorder.ToListAsync();
        }

        // GET: api/TtrackCircuitBorder/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrackCircuitBorder>> GetTtrackCircuitBorder(short id)
        {
            var ttrackCircuitBorder = await _context.TtrackCircuitBorder.FindAsync(id);

            if (ttrackCircuitBorder == null)
            {
                return NotFound();
            }

            return ttrackCircuitBorder;
        }

        // PUT: api/TtrackCircuitBorder/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrackCircuitBorder(short id, TtrackCircuitBorder ttrackCircuitBorder)
        {
            if (id != ttrackCircuitBorder.TtrackCircuitBorderId)
            {
                return BadRequest();
            }

            _context.Entry(ttrackCircuitBorder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrackCircuitBorderExists(id))
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

        // POST: api/TtrackCircuitBorder
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrackCircuitBorder>> PostTtrackCircuitBorder(TtrackCircuitBorder ttrackCircuitBorder)
        {
            _context.TtrackCircuitBorder.Add(ttrackCircuitBorder);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrackCircuitBorderExists(ttrackCircuitBorder.TtrackCircuitBorderId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrackCircuitBorder", new { id = ttrackCircuitBorder.TtrackCircuitBorderId }, ttrackCircuitBorder);
        }

        // DELETE: api/TtrackCircuitBorder/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrackCircuitBorder>> DeleteTtrackCircuitBorder(short id)
        {
            var ttrackCircuitBorder = await _context.TtrackCircuitBorder.FindAsync(id);
            if (ttrackCircuitBorder == null)
            {
                return NotFound();
            }

            _context.TtrackCircuitBorder.Remove(ttrackCircuitBorder);
            await _context.SaveChangesAsync();

            return ttrackCircuitBorder;
        }

        private bool TtrackCircuitBorderExists(short id)
        {
            return _context.TtrackCircuitBorder.Any(e => e.TtrackCircuitBorderId == id);
        }
    }
}
