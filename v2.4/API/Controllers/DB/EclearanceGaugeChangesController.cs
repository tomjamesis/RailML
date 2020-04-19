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
    public class EclearanceGaugeChangesController : ControllerBase
    {
        private readonly DBContext _context;

        public EclearanceGaugeChangesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EclearanceGaugeChanges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EclearanceGaugeChanges>>> GetEclearanceGaugeChanges()
        {
            return await _context.EclearanceGaugeChanges.ToListAsync();
        }

        // GET: api/EclearanceGaugeChanges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EclearanceGaugeChanges>> GetEclearanceGaugeChanges(long id)
        {
            var eclearanceGaugeChanges = await _context.EclearanceGaugeChanges.FindAsync(id);

            if (eclearanceGaugeChanges == null)
            {
                return NotFound();
            }

            return eclearanceGaugeChanges;
        }

        // PUT: api/EclearanceGaugeChanges/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEclearanceGaugeChanges(long id, EclearanceGaugeChanges eclearanceGaugeChanges)
        {
            if (id != eclearanceGaugeChanges.EclearanceGaugeChangesId)
            {
                return BadRequest();
            }

            _context.Entry(eclearanceGaugeChanges).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EclearanceGaugeChangesExists(id))
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

        // POST: api/EclearanceGaugeChanges
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EclearanceGaugeChanges>> PostEclearanceGaugeChanges(EclearanceGaugeChanges eclearanceGaugeChanges)
        {
            _context.EclearanceGaugeChanges.Add(eclearanceGaugeChanges);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EclearanceGaugeChangesExists(eclearanceGaugeChanges.EclearanceGaugeChangesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEclearanceGaugeChanges", new { id = eclearanceGaugeChanges.EclearanceGaugeChangesId }, eclearanceGaugeChanges);
        }

        // DELETE: api/EclearanceGaugeChanges/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EclearanceGaugeChanges>> DeleteEclearanceGaugeChanges(long id)
        {
            var eclearanceGaugeChanges = await _context.EclearanceGaugeChanges.FindAsync(id);
            if (eclearanceGaugeChanges == null)
            {
                return NotFound();
            }

            _context.EclearanceGaugeChanges.Remove(eclearanceGaugeChanges);
            await _context.SaveChangesAsync();

            return eclearanceGaugeChanges;
        }

        private bool EclearanceGaugeChangesExists(long id)
        {
            return _context.EclearanceGaugeChanges.Any(e => e.EclearanceGaugeChangesId == id);
        }
    }
}
