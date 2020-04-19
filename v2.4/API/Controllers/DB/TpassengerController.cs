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
    public class TpassengerController : ControllerBase
    {
        private readonly DBContext _context;

        public TpassengerController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tpassenger
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tpassenger>>> GetTpassenger()
        {
            return await _context.Tpassenger.ToListAsync();
        }

        // GET: api/Tpassenger/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tpassenger>> GetTpassenger(short id)
        {
            var tpassenger = await _context.Tpassenger.FindAsync(id);

            if (tpassenger == null)
            {
                return NotFound();
            }

            return tpassenger;
        }

        // PUT: api/Tpassenger/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTpassenger(short id, Tpassenger tpassenger)
        {
            if (id != tpassenger.TpassengerId)
            {
                return BadRequest();
            }

            _context.Entry(tpassenger).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TpassengerExists(id))
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

        // POST: api/Tpassenger
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tpassenger>> PostTpassenger(Tpassenger tpassenger)
        {
            _context.Tpassenger.Add(tpassenger);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TpassengerExists(tpassenger.TpassengerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTpassenger", new { id = tpassenger.TpassengerId }, tpassenger);
        }

        // DELETE: api/Tpassenger/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tpassenger>> DeleteTpassenger(short id)
        {
            var tpassenger = await _context.Tpassenger.FindAsync(id);
            if (tpassenger == null)
            {
                return NotFound();
            }

            _context.Tpassenger.Remove(tpassenger);
            await _context.SaveChangesAsync();

            return tpassenger;
        }

        private bool TpassengerExists(short id)
        {
            return _context.Tpassenger.Any(e => e.TpassengerId == id);
        }
    }
}
