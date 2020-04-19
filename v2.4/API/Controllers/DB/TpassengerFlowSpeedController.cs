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
    public class TpassengerFlowSpeedController : ControllerBase
    {
        private readonly DBContext _context;

        public TpassengerFlowSpeedController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TpassengerFlowSpeed
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TpassengerFlowSpeed>>> GetTpassengerFlowSpeed()
        {
            return await _context.TpassengerFlowSpeed.ToListAsync();
        }

        // GET: api/TpassengerFlowSpeed/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TpassengerFlowSpeed>> GetTpassengerFlowSpeed(long id)
        {
            var tpassengerFlowSpeed = await _context.TpassengerFlowSpeed.FindAsync(id);

            if (tpassengerFlowSpeed == null)
            {
                return NotFound();
            }

            return tpassengerFlowSpeed;
        }

        // PUT: api/TpassengerFlowSpeed/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTpassengerFlowSpeed(long id, TpassengerFlowSpeed tpassengerFlowSpeed)
        {
            if (id != tpassengerFlowSpeed.TpassengerFlowSpeedId)
            {
                return BadRequest();
            }

            _context.Entry(tpassengerFlowSpeed).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TpassengerFlowSpeedExists(id))
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

        // POST: api/TpassengerFlowSpeed
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TpassengerFlowSpeed>> PostTpassengerFlowSpeed(TpassengerFlowSpeed tpassengerFlowSpeed)
        {
            _context.TpassengerFlowSpeed.Add(tpassengerFlowSpeed);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TpassengerFlowSpeedExists(tpassengerFlowSpeed.TpassengerFlowSpeedId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTpassengerFlowSpeed", new { id = tpassengerFlowSpeed.TpassengerFlowSpeedId }, tpassengerFlowSpeed);
        }

        // DELETE: api/TpassengerFlowSpeed/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TpassengerFlowSpeed>> DeleteTpassengerFlowSpeed(long id)
        {
            var tpassengerFlowSpeed = await _context.TpassengerFlowSpeed.FindAsync(id);
            if (tpassengerFlowSpeed == null)
            {
                return NotFound();
            }

            _context.TpassengerFlowSpeed.Remove(tpassengerFlowSpeed);
            await _context.SaveChangesAsync();

            return tpassengerFlowSpeed;
        }

        private bool TpassengerFlowSpeedExists(long id)
        {
            return _context.TpassengerFlowSpeed.Any(e => e.TpassengerFlowSpeedId == id);
        }
    }
}
