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
    public class TtrainProtectionMonitoringController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainProtectionMonitoringController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrainProtectionMonitoring
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrainProtectionMonitoring>>> GetTtrainProtectionMonitoring()
        {
            return await _context.TtrainProtectionMonitoring.ToListAsync();
        }

        // GET: api/TtrainProtectionMonitoring/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrainProtectionMonitoring>> GetTtrainProtectionMonitoring(byte id)
        {
            var ttrainProtectionMonitoring = await _context.TtrainProtectionMonitoring.FindAsync(id);

            if (ttrainProtectionMonitoring == null)
            {
                return NotFound();
            }

            return ttrainProtectionMonitoring;
        }

        // PUT: api/TtrainProtectionMonitoring/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrainProtectionMonitoring(byte id, TtrainProtectionMonitoring ttrainProtectionMonitoring)
        {
            if (id != ttrainProtectionMonitoring.TtrainProtectionMonitoringId)
            {
                return BadRequest();
            }

            _context.Entry(ttrainProtectionMonitoring).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainProtectionMonitoringExists(id))
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

        // POST: api/TtrainProtectionMonitoring
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrainProtectionMonitoring>> PostTtrainProtectionMonitoring(TtrainProtectionMonitoring ttrainProtectionMonitoring)
        {
            _context.TtrainProtectionMonitoring.Add(ttrainProtectionMonitoring);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainProtectionMonitoringExists(ttrainProtectionMonitoring.TtrainProtectionMonitoringId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrainProtectionMonitoring", new { id = ttrainProtectionMonitoring.TtrainProtectionMonitoringId }, ttrainProtectionMonitoring);
        }

        // DELETE: api/TtrainProtectionMonitoring/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrainProtectionMonitoring>> DeleteTtrainProtectionMonitoring(byte id)
        {
            var ttrainProtectionMonitoring = await _context.TtrainProtectionMonitoring.FindAsync(id);
            if (ttrainProtectionMonitoring == null)
            {
                return NotFound();
            }

            _context.TtrainProtectionMonitoring.Remove(ttrainProtectionMonitoring);
            await _context.SaveChangesAsync();

            return ttrainProtectionMonitoring;
        }

        private bool TtrainProtectionMonitoringExists(byte id)
        {
            return _context.TtrainProtectionMonitoring.Any(e => e.TtrainProtectionMonitoringId == id);
        }
    }
}
