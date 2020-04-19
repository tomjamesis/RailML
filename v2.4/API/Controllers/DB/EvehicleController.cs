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
    public class EvehicleController : ControllerBase
    {
        private readonly DBContext _context;

        public EvehicleController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Evehicle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Evehicle>>> GetEvehicle()
        {
            return await _context.Evehicle.ToListAsync();
        }

        // GET: api/Evehicle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Evehicle>> GetEvehicle(short id)
        {
            var evehicle = await _context.Evehicle.FindAsync(id);

            if (evehicle == null)
            {
                return NotFound();
            }

            return evehicle;
        }

        // PUT: api/Evehicle/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvehicle(short id, Evehicle evehicle)
        {
            if (id != evehicle.EvehicleId)
            {
                return BadRequest();
            }

            _context.Entry(evehicle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EvehicleExists(id))
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

        // POST: api/Evehicle
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Evehicle>> PostEvehicle(Evehicle evehicle)
        {
            _context.Evehicle.Add(evehicle);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EvehicleExists(evehicle.EvehicleId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEvehicle", new { id = evehicle.EvehicleId }, evehicle);
        }

        // DELETE: api/Evehicle/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Evehicle>> DeleteEvehicle(short id)
        {
            var evehicle = await _context.Evehicle.FindAsync(id);
            if (evehicle == null)
            {
                return NotFound();
            }

            _context.Evehicle.Remove(evehicle);
            await _context.SaveChangesAsync();

            return evehicle;
        }

        private bool EvehicleExists(short id)
        {
            return _context.Evehicle.Any(e => e.EvehicleId == id);
        }
    }
}
