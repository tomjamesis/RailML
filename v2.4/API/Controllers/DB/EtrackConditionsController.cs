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
    public class EtrackConditionsController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrackConditionsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrackConditions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrackConditions>>> GetEtrackConditions()
        {
            return await _context.EtrackConditions.ToListAsync();
        }

        // GET: api/EtrackConditions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrackConditions>> GetEtrackConditions(long id)
        {
            var etrackConditions = await _context.EtrackConditions.FindAsync(id);

            if (etrackConditions == null)
            {
                return NotFound();
            }

            return etrackConditions;
        }

        // PUT: api/EtrackConditions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrackConditions(long id, EtrackConditions etrackConditions)
        {
            if (id != etrackConditions.EtrackConditionsId)
            {
                return BadRequest();
            }

            _context.Entry(etrackConditions).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrackConditionsExists(id))
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

        // POST: api/EtrackConditions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrackConditions>> PostEtrackConditions(EtrackConditions etrackConditions)
        {
            _context.EtrackConditions.Add(etrackConditions);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrackConditionsExists(etrackConditions.EtrackConditionsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrackConditions", new { id = etrackConditions.EtrackConditionsId }, etrackConditions);
        }

        // DELETE: api/EtrackConditions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrackConditions>> DeleteEtrackConditions(long id)
        {
            var etrackConditions = await _context.EtrackConditions.FindAsync(id);
            if (etrackConditions == null)
            {
                return NotFound();
            }

            _context.EtrackConditions.Remove(etrackConditions);
            await _context.SaveChangesAsync();

            return etrackConditions;
        }

        private bool EtrackConditionsExists(long id)
        {
            return _context.EtrackConditions.Any(e => e.EtrackConditionsId == id);
        }
    }
}
