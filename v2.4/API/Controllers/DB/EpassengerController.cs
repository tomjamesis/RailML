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
    public class EpassengerController : ControllerBase
    {
        private readonly DBContext _context;

        public EpassengerController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Epassenger
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Epassenger>>> GetEpassenger()
        {
            return await _context.Epassenger.ToListAsync();
        }

        // GET: api/Epassenger/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Epassenger>> GetEpassenger(short id)
        {
            var epassenger = await _context.Epassenger.FindAsync(id);

            if (epassenger == null)
            {
                return NotFound();
            }

            return epassenger;
        }

        // PUT: api/Epassenger/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEpassenger(short id, Epassenger epassenger)
        {
            if (id != epassenger.EpassengerId)
            {
                return BadRequest();
            }

            _context.Entry(epassenger).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EpassengerExists(id))
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

        // POST: api/Epassenger
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Epassenger>> PostEpassenger(Epassenger epassenger)
        {
            _context.Epassenger.Add(epassenger);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EpassengerExists(epassenger.EpassengerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEpassenger", new { id = epassenger.EpassengerId }, epassenger);
        }

        // DELETE: api/Epassenger/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Epassenger>> DeleteEpassenger(short id)
        {
            var epassenger = await _context.Epassenger.FindAsync(id);
            if (epassenger == null)
            {
                return NotFound();
            }

            _context.Epassenger.Remove(epassenger);
            await _context.SaveChangesAsync();

            return epassenger;
        }

        private bool EpassengerExists(short id)
        {
            return _context.Epassenger.Any(e => e.EpassengerId == id);
        }
    }
}
