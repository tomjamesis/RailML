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
    public class EpowerTransmissionChangesController : ControllerBase
    {
        private readonly DBContext _context;

        public EpowerTransmissionChangesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EpowerTransmissionChanges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EpowerTransmissionChanges>>> GetEpowerTransmissionChanges()
        {
            return await _context.EpowerTransmissionChanges.ToListAsync();
        }

        // GET: api/EpowerTransmissionChanges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EpowerTransmissionChanges>> GetEpowerTransmissionChanges(long id)
        {
            var epowerTransmissionChanges = await _context.EpowerTransmissionChanges.FindAsync(id);

            if (epowerTransmissionChanges == null)
            {
                return NotFound();
            }

            return epowerTransmissionChanges;
        }

        // PUT: api/EpowerTransmissionChanges/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEpowerTransmissionChanges(long id, EpowerTransmissionChanges epowerTransmissionChanges)
        {
            if (id != epowerTransmissionChanges.EpowerTransmissionChangesId)
            {
                return BadRequest();
            }

            _context.Entry(epowerTransmissionChanges).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EpowerTransmissionChangesExists(id))
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

        // POST: api/EpowerTransmissionChanges
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EpowerTransmissionChanges>> PostEpowerTransmissionChanges(EpowerTransmissionChanges epowerTransmissionChanges)
        {
            _context.EpowerTransmissionChanges.Add(epowerTransmissionChanges);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EpowerTransmissionChangesExists(epowerTransmissionChanges.EpowerTransmissionChangesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEpowerTransmissionChanges", new { id = epowerTransmissionChanges.EpowerTransmissionChangesId }, epowerTransmissionChanges);
        }

        // DELETE: api/EpowerTransmissionChanges/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EpowerTransmissionChanges>> DeleteEpowerTransmissionChanges(long id)
        {
            var epowerTransmissionChanges = await _context.EpowerTransmissionChanges.FindAsync(id);
            if (epowerTransmissionChanges == null)
            {
                return NotFound();
            }

            _context.EpowerTransmissionChanges.Remove(epowerTransmissionChanges);
            await _context.SaveChangesAsync();

            return epowerTransmissionChanges;
        }

        private bool EpowerTransmissionChangesExists(long id)
        {
            return _context.EpowerTransmissionChanges.Any(e => e.EpowerTransmissionChangesId == id);
        }
    }
}
