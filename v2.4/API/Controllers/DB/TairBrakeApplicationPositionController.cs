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
    public class TairBrakeApplicationPositionController : ControllerBase
    {
        private readonly DBContext _context;

        public TairBrakeApplicationPositionController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TairBrakeApplicationPosition
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TairBrakeApplicationPosition>>> GetTairBrakeApplicationPosition()
        {
            return await _context.TairBrakeApplicationPosition.ToListAsync();
        }

        // GET: api/TairBrakeApplicationPosition/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TairBrakeApplicationPosition>> GetTairBrakeApplicationPosition(byte id)
        {
            var tairBrakeApplicationPosition = await _context.TairBrakeApplicationPosition.FindAsync(id);

            if (tairBrakeApplicationPosition == null)
            {
                return NotFound();
            }

            return tairBrakeApplicationPosition;
        }

        // PUT: api/TairBrakeApplicationPosition/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTairBrakeApplicationPosition(byte id, TairBrakeApplicationPosition tairBrakeApplicationPosition)
        {
            if (id != tairBrakeApplicationPosition.TairBrakeApplicationPositionId)
            {
                return BadRequest();
            }

            _context.Entry(tairBrakeApplicationPosition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TairBrakeApplicationPositionExists(id))
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

        // POST: api/TairBrakeApplicationPosition
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TairBrakeApplicationPosition>> PostTairBrakeApplicationPosition(TairBrakeApplicationPosition tairBrakeApplicationPosition)
        {
            _context.TairBrakeApplicationPosition.Add(tairBrakeApplicationPosition);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TairBrakeApplicationPositionExists(tairBrakeApplicationPosition.TairBrakeApplicationPositionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTairBrakeApplicationPosition", new { id = tairBrakeApplicationPosition.TairBrakeApplicationPositionId }, tairBrakeApplicationPosition);
        }

        // DELETE: api/TairBrakeApplicationPosition/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TairBrakeApplicationPosition>> DeleteTairBrakeApplicationPosition(byte id)
        {
            var tairBrakeApplicationPosition = await _context.TairBrakeApplicationPosition.FindAsync(id);
            if (tairBrakeApplicationPosition == null)
            {
                return NotFound();
            }

            _context.TairBrakeApplicationPosition.Remove(tairBrakeApplicationPosition);
            await _context.SaveChangesAsync();

            return tairBrakeApplicationPosition;
        }

        private bool TairBrakeApplicationPositionExists(byte id)
        {
            return _context.TairBrakeApplicationPosition.Any(e => e.TairBrakeApplicationPositionId == id);
        }
    }
}
