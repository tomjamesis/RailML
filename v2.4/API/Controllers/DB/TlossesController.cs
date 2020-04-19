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
    public class TlossesController : ControllerBase
    {
        private readonly DBContext _context;

        public TlossesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tlosses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tlosses>>> GetTlosses()
        {
            return await _context.Tlosses.ToListAsync();
        }

        // GET: api/Tlosses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tlosses>> GetTlosses(short id)
        {
            var tlosses = await _context.Tlosses.FindAsync(id);

            if (tlosses == null)
            {
                return NotFound();
            }

            return tlosses;
        }

        // PUT: api/Tlosses/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTlosses(short id, Tlosses tlosses)
        {
            if (id != tlosses.TlossesId)
            {
                return BadRequest();
            }

            _context.Entry(tlosses).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TlossesExists(id))
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

        // POST: api/Tlosses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tlosses>> PostTlosses(Tlosses tlosses)
        {
            _context.Tlosses.Add(tlosses);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TlossesExists(tlosses.TlossesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTlosses", new { id = tlosses.TlossesId }, tlosses);
        }

        // DELETE: api/Tlosses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tlosses>> DeleteTlosses(short id)
        {
            var tlosses = await _context.Tlosses.FindAsync(id);
            if (tlosses == null)
            {
                return NotFound();
            }

            _context.Tlosses.Remove(tlosses);
            await _context.SaveChangesAsync();

            return tlosses;
        }

        private bool TlossesExists(short id)
        {
            return _context.Tlosses.Any(e => e.TlossesId == id);
        }
    }
}
