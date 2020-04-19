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
    public class TpowerTransmissionController : ControllerBase
    {
        private readonly DBContext _context;

        public TpowerTransmissionController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TpowerTransmission
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TpowerTransmission>>> GetTpowerTransmission()
        {
            return await _context.TpowerTransmission.ToListAsync();
        }

        // GET: api/TpowerTransmission/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TpowerTransmission>> GetTpowerTransmission(long id)
        {
            var tpowerTransmission = await _context.TpowerTransmission.FindAsync(id);

            if (tpowerTransmission == null)
            {
                return NotFound();
            }

            return tpowerTransmission;
        }

        // PUT: api/TpowerTransmission/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTpowerTransmission(long id, TpowerTransmission tpowerTransmission)
        {
            if (id != tpowerTransmission.TpowerTransmissionId)
            {
                return BadRequest();
            }

            _context.Entry(tpowerTransmission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TpowerTransmissionExists(id))
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

        // POST: api/TpowerTransmission
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TpowerTransmission>> PostTpowerTransmission(TpowerTransmission tpowerTransmission)
        {
            _context.TpowerTransmission.Add(tpowerTransmission);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TpowerTransmissionExists(tpowerTransmission.TpowerTransmissionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTpowerTransmission", new { id = tpowerTransmission.TpowerTransmissionId }, tpowerTransmission);
        }

        // DELETE: api/TpowerTransmission/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TpowerTransmission>> DeleteTpowerTransmission(long id)
        {
            var tpowerTransmission = await _context.TpowerTransmission.FindAsync(id);
            if (tpowerTransmission == null)
            {
                return NotFound();
            }

            _context.TpowerTransmission.Remove(tpowerTransmission);
            await _context.SaveChangesAsync();

            return tpowerTransmission;
        }

        private bool TpowerTransmissionExists(long id)
        {
            return _context.TpowerTransmission.Any(e => e.TpowerTransmissionId == id);
        }
    }
}
