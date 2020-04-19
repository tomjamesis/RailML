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
    public class EwagonController : ControllerBase
    {
        private readonly DBContext _context;

        public EwagonController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Ewagon
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ewagon>>> GetEwagon()
        {
            return await _context.Ewagon.ToListAsync();
        }

        // GET: api/Ewagon/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ewagon>> GetEwagon(short id)
        {
            var ewagon = await _context.Ewagon.FindAsync(id);

            if (ewagon == null)
            {
                return NotFound();
            }

            return ewagon;
        }

        // PUT: api/Ewagon/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEwagon(short id, Ewagon ewagon)
        {
            if (id != ewagon.EwagonId)
            {
                return BadRequest();
            }

            _context.Entry(ewagon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EwagonExists(id))
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

        // POST: api/Ewagon
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ewagon>> PostEwagon(Ewagon ewagon)
        {
            _context.Ewagon.Add(ewagon);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EwagonExists(ewagon.EwagonId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEwagon", new { id = ewagon.EwagonId }, ewagon);
        }

        // DELETE: api/Ewagon/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ewagon>> DeleteEwagon(short id)
        {
            var ewagon = await _context.Ewagon.FindAsync(id);
            if (ewagon == null)
            {
                return NotFound();
            }

            _context.Ewagon.Remove(ewagon);
            await _context.SaveChangesAsync();

            return ewagon;
        }

        private bool EwagonExists(short id)
        {
            return _context.Ewagon.Any(e => e.EwagonId == id);
        }
    }
}
