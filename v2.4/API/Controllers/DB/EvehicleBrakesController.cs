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
    public class EvehicleBrakesController : ControllerBase
    {
        private readonly DBContext _context;

        public EvehicleBrakesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EvehicleBrakes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EvehicleBrakes>>> GetEvehicleBrakes()
        {
            return await _context.EvehicleBrakes.ToListAsync();
        }

        // GET: api/EvehicleBrakes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EvehicleBrakes>> GetEvehicleBrakes(long id)
        {
            var evehicleBrakes = await _context.EvehicleBrakes.FindAsync(id);

            if (evehicleBrakes == null)
            {
                return NotFound();
            }

            return evehicleBrakes;
        }

        // PUT: api/EvehicleBrakes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvehicleBrakes(long id, EvehicleBrakes evehicleBrakes)
        {
            if (id != evehicleBrakes.EvehicleBrakesId)
            {
                return BadRequest();
            }

            _context.Entry(evehicleBrakes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EvehicleBrakesExists(id))
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

        // POST: api/EvehicleBrakes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EvehicleBrakes>> PostEvehicleBrakes(EvehicleBrakes evehicleBrakes)
        {
            _context.EvehicleBrakes.Add(evehicleBrakes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EvehicleBrakesExists(evehicleBrakes.EvehicleBrakesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEvehicleBrakes", new { id = evehicleBrakes.EvehicleBrakesId }, evehicleBrakes);
        }

        // DELETE: api/EvehicleBrakes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EvehicleBrakes>> DeleteEvehicleBrakes(long id)
        {
            var evehicleBrakes = await _context.EvehicleBrakes.FindAsync(id);
            if (evehicleBrakes == null)
            {
                return NotFound();
            }

            _context.EvehicleBrakes.Remove(evehicleBrakes);
            await _context.SaveChangesAsync();

            return evehicleBrakes;
        }

        private bool EvehicleBrakesExists(long id)
        {
            return _context.EvehicleBrakes.Any(e => e.EvehicleBrakesId == id);
        }
    }
}
