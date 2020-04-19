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
    public class EoperatingPeriodController : ControllerBase
    {
        private readonly DBContext _context;

        public EoperatingPeriodController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EoperatingPeriod
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EoperatingPeriod>>> GetEoperatingPeriod()
        {
            return await _context.EoperatingPeriod.ToListAsync();
        }

        // GET: api/EoperatingPeriod/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EoperatingPeriod>> GetEoperatingPeriod(short id)
        {
            var eoperatingPeriod = await _context.EoperatingPeriod.FindAsync(id);

            if (eoperatingPeriod == null)
            {
                return NotFound();
            }

            return eoperatingPeriod;
        }

        // PUT: api/EoperatingPeriod/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEoperatingPeriod(short id, EoperatingPeriod eoperatingPeriod)
        {
            if (id != eoperatingPeriod.EoperatingPeriodId)
            {
                return BadRequest();
            }

            _context.Entry(eoperatingPeriod).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EoperatingPeriodExists(id))
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

        // POST: api/EoperatingPeriod
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EoperatingPeriod>> PostEoperatingPeriod(EoperatingPeriod eoperatingPeriod)
        {
            _context.EoperatingPeriod.Add(eoperatingPeriod);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EoperatingPeriodExists(eoperatingPeriod.EoperatingPeriodId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEoperatingPeriod", new { id = eoperatingPeriod.EoperatingPeriodId }, eoperatingPeriod);
        }

        // DELETE: api/EoperatingPeriod/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EoperatingPeriod>> DeleteEoperatingPeriod(short id)
        {
            var eoperatingPeriod = await _context.EoperatingPeriod.FindAsync(id);
            if (eoperatingPeriod == null)
            {
                return NotFound();
            }

            _context.EoperatingPeriod.Remove(eoperatingPeriod);
            await _context.SaveChangesAsync();

            return eoperatingPeriod;
        }

        private bool EoperatingPeriodExists(short id)
        {
            return _context.EoperatingPeriod.Any(e => e.EoperatingPeriodId == id);
        }
    }
}
