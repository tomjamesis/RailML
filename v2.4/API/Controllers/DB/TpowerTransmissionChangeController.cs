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
    public class TpowerTransmissionChangeController : ControllerBase
    {
        private readonly DBContext _context;

        public TpowerTransmissionChangeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TpowerTransmissionChange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TpowerTransmissionChange>>> GetTpowerTransmissionChange()
        {
            return await _context.TpowerTransmissionChange.ToListAsync();
        }

        // GET: api/TpowerTransmissionChange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TpowerTransmissionChange>> GetTpowerTransmissionChange(short id)
        {
            var tpowerTransmissionChange = await _context.TpowerTransmissionChange.FindAsync(id);

            if (tpowerTransmissionChange == null)
            {
                return NotFound();
            }

            return tpowerTransmissionChange;
        }

        // PUT: api/TpowerTransmissionChange/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTpowerTransmissionChange(short id, TpowerTransmissionChange tpowerTransmissionChange)
        {
            if (id != tpowerTransmissionChange.TpowerTransmissionChangeId)
            {
                return BadRequest();
            }

            _context.Entry(tpowerTransmissionChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TpowerTransmissionChangeExists(id))
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

        // POST: api/TpowerTransmissionChange
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TpowerTransmissionChange>> PostTpowerTransmissionChange(TpowerTransmissionChange tpowerTransmissionChange)
        {
            _context.TpowerTransmissionChange.Add(tpowerTransmissionChange);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TpowerTransmissionChangeExists(tpowerTransmissionChange.TpowerTransmissionChangeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTpowerTransmissionChange", new { id = tpowerTransmissionChange.TpowerTransmissionChangeId }, tpowerTransmissionChange);
        }

        // DELETE: api/TpowerTransmissionChange/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TpowerTransmissionChange>> DeleteTpowerTransmissionChange(short id)
        {
            var tpowerTransmissionChange = await _context.TpowerTransmissionChange.FindAsync(id);
            if (tpowerTransmissionChange == null)
            {
                return NotFound();
            }

            _context.TpowerTransmissionChange.Remove(tpowerTransmissionChange);
            await _context.SaveChangesAsync();

            return tpowerTransmissionChange;
        }

        private bool TpowerTransmissionChangeExists(short id)
        {
            return _context.TpowerTransmissionChange.Any(e => e.TpowerTransmissionChangeId == id);
        }
    }
}
