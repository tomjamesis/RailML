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
    public class EcirculationsController : ControllerBase
    {
        private readonly DBContext _context;

        public EcirculationsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Ecirculations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ecirculations>>> GetEcirculations()
        {
            return await _context.Ecirculations.ToListAsync();
        }

        // GET: api/Ecirculations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ecirculations>> GetEcirculations(long id)
        {
            var ecirculations = await _context.Ecirculations.FindAsync(id);

            if (ecirculations == null)
            {
                return NotFound();
            }

            return ecirculations;
        }

        // PUT: api/Ecirculations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEcirculations(long id, Ecirculations ecirculations)
        {
            if (id != ecirculations.EcirculationsId)
            {
                return BadRequest();
            }

            _context.Entry(ecirculations).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EcirculationsExists(id))
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

        // POST: api/Ecirculations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ecirculations>> PostEcirculations(Ecirculations ecirculations)
        {
            _context.Ecirculations.Add(ecirculations);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EcirculationsExists(ecirculations.EcirculationsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEcirculations", new { id = ecirculations.EcirculationsId }, ecirculations);
        }

        // DELETE: api/Ecirculations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ecirculations>> DeleteEcirculations(long id)
        {
            var ecirculations = await _context.Ecirculations.FindAsync(id);
            if (ecirculations == null)
            {
                return NotFound();
            }

            _context.Ecirculations.Remove(ecirculations);
            await _context.SaveChangesAsync();

            return ecirculations;
        }

        private bool EcirculationsExists(long id)
        {
            return _context.Ecirculations.Any(e => e.EcirculationsId == id);
        }
    }
}
