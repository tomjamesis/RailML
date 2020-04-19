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
    public class EvehicleBrakeController : ControllerBase
    {
        private readonly DBContext _context;

        public EvehicleBrakeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EvehicleBrake
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EvehicleBrake>>> GetEvehicleBrake()
        {
            return await _context.EvehicleBrake.ToListAsync();
        }

        // GET: api/EvehicleBrake/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EvehicleBrake>> GetEvehicleBrake(short id)
        {
            var evehicleBrake = await _context.EvehicleBrake.FindAsync(id);

            if (evehicleBrake == null)
            {
                return NotFound();
            }

            return evehicleBrake;
        }

        // PUT: api/EvehicleBrake/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvehicleBrake(short id, EvehicleBrake evehicleBrake)
        {
            if (id != evehicleBrake.EvehicleBrakeId)
            {
                return BadRequest();
            }

            _context.Entry(evehicleBrake).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EvehicleBrakeExists(id))
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

        // POST: api/EvehicleBrake
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EvehicleBrake>> PostEvehicleBrake(EvehicleBrake evehicleBrake)
        {
            _context.EvehicleBrake.Add(evehicleBrake);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EvehicleBrakeExists(evehicleBrake.EvehicleBrakeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEvehicleBrake", new { id = evehicleBrake.EvehicleBrakeId }, evehicleBrake);
        }

        // DELETE: api/EvehicleBrake/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EvehicleBrake>> DeleteEvehicleBrake(short id)
        {
            var evehicleBrake = await _context.EvehicleBrake.FindAsync(id);
            if (evehicleBrake == null)
            {
                return NotFound();
            }

            _context.EvehicleBrake.Remove(evehicleBrake);
            await _context.SaveChangesAsync();

            return evehicleBrake;
        }

        private bool EvehicleBrakeExists(short id)
        {
            return _context.EvehicleBrake.Any(e => e.EvehicleBrakeId == id);
        }
    }
}
