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
    public class TeddyCurrentBrakeController : ControllerBase
    {
        private readonly DBContext _context;

        public TeddyCurrentBrakeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TeddyCurrentBrake
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeddyCurrentBrake>>> GetTeddyCurrentBrake()
        {
            return await _context.TeddyCurrentBrake.ToListAsync();
        }

        // GET: api/TeddyCurrentBrake/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeddyCurrentBrake>> GetTeddyCurrentBrake(long id)
        {
            var teddyCurrentBrake = await _context.TeddyCurrentBrake.FindAsync(id);

            if (teddyCurrentBrake == null)
            {
                return NotFound();
            }

            return teddyCurrentBrake;
        }

        // PUT: api/TeddyCurrentBrake/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeddyCurrentBrake(long id, TeddyCurrentBrake teddyCurrentBrake)
        {
            if (id != teddyCurrentBrake.TeddyCurrentBrakeId)
            {
                return BadRequest();
            }

            _context.Entry(teddyCurrentBrake).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeddyCurrentBrakeExists(id))
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

        // POST: api/TeddyCurrentBrake
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TeddyCurrentBrake>> PostTeddyCurrentBrake(TeddyCurrentBrake teddyCurrentBrake)
        {
            _context.TeddyCurrentBrake.Add(teddyCurrentBrake);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TeddyCurrentBrakeExists(teddyCurrentBrake.TeddyCurrentBrakeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTeddyCurrentBrake", new { id = teddyCurrentBrake.TeddyCurrentBrakeId }, teddyCurrentBrake);
        }

        // DELETE: api/TeddyCurrentBrake/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TeddyCurrentBrake>> DeleteTeddyCurrentBrake(long id)
        {
            var teddyCurrentBrake = await _context.TeddyCurrentBrake.FindAsync(id);
            if (teddyCurrentBrake == null)
            {
                return NotFound();
            }

            _context.TeddyCurrentBrake.Remove(teddyCurrentBrake);
            await _context.SaveChangesAsync();

            return teddyCurrentBrake;
        }

        private bool TeddyCurrentBrakeExists(long id)
        {
            return _context.TeddyCurrentBrake.Any(e => e.TeddyCurrentBrakeId == id);
        }
    }
}
