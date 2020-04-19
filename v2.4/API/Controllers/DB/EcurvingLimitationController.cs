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
    public class EcurvingLimitationController : ControllerBase
    {
        private readonly DBContext _context;

        public EcurvingLimitationController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EcurvingLimitation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EcurvingLimitation>>> GetEcurvingLimitation()
        {
            return await _context.EcurvingLimitation.ToListAsync();
        }

        // GET: api/EcurvingLimitation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EcurvingLimitation>> GetEcurvingLimitation(short id)
        {
            var ecurvingLimitation = await _context.EcurvingLimitation.FindAsync(id);

            if (ecurvingLimitation == null)
            {
                return NotFound();
            }

            return ecurvingLimitation;
        }

        // PUT: api/EcurvingLimitation/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEcurvingLimitation(short id, EcurvingLimitation ecurvingLimitation)
        {
            if (id != ecurvingLimitation.EcurvingLimitationId)
            {
                return BadRequest();
            }

            _context.Entry(ecurvingLimitation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EcurvingLimitationExists(id))
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

        // POST: api/EcurvingLimitation
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EcurvingLimitation>> PostEcurvingLimitation(EcurvingLimitation ecurvingLimitation)
        {
            _context.EcurvingLimitation.Add(ecurvingLimitation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EcurvingLimitationExists(ecurvingLimitation.EcurvingLimitationId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEcurvingLimitation", new { id = ecurvingLimitation.EcurvingLimitationId }, ecurvingLimitation);
        }

        // DELETE: api/EcurvingLimitation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EcurvingLimitation>> DeleteEcurvingLimitation(short id)
        {
            var ecurvingLimitation = await _context.EcurvingLimitation.FindAsync(id);
            if (ecurvingLimitation == null)
            {
                return NotFound();
            }

            _context.EcurvingLimitation.Remove(ecurvingLimitation);
            await _context.SaveChangesAsync();

            return ecurvingLimitation;
        }

        private bool EcurvingLimitationExists(short id)
        {
            return _context.EcurvingLimitation.Any(e => e.EcurvingLimitationId == id);
        }
    }
}
