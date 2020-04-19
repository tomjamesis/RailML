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
    public class TefficiencyCurveController : ControllerBase
    {
        private readonly DBContext _context;

        public TefficiencyCurveController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TefficiencyCurve
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TefficiencyCurve>>> GetTefficiencyCurve()
        {
            return await _context.TefficiencyCurve.ToListAsync();
        }

        // GET: api/TefficiencyCurve/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TefficiencyCurve>> GetTefficiencyCurve(short id)
        {
            var tefficiencyCurve = await _context.TefficiencyCurve.FindAsync(id);

            if (tefficiencyCurve == null)
            {
                return NotFound();
            }

            return tefficiencyCurve;
        }

        // PUT: api/TefficiencyCurve/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTefficiencyCurve(short id, TefficiencyCurve tefficiencyCurve)
        {
            if (id != tefficiencyCurve.TefficiencyCurveId)
            {
                return BadRequest();
            }

            _context.Entry(tefficiencyCurve).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TefficiencyCurveExists(id))
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

        // POST: api/TefficiencyCurve
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TefficiencyCurve>> PostTefficiencyCurve(TefficiencyCurve tefficiencyCurve)
        {
            _context.TefficiencyCurve.Add(tefficiencyCurve);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TefficiencyCurveExists(tefficiencyCurve.TefficiencyCurveId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTefficiencyCurve", new { id = tefficiencyCurve.TefficiencyCurveId }, tefficiencyCurve);
        }

        // DELETE: api/TefficiencyCurve/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TefficiencyCurve>> DeleteTefficiencyCurve(short id)
        {
            var tefficiencyCurve = await _context.TefficiencyCurve.FindAsync(id);
            if (tefficiencyCurve == null)
            {
                return NotFound();
            }

            _context.TefficiencyCurve.Remove(tefficiencyCurve);
            await _context.SaveChangesAsync();

            return tefficiencyCurve;
        }

        private bool TefficiencyCurveExists(short id)
        {
            return _context.TefficiencyCurve.Any(e => e.TefficiencyCurveId == id);
        }
    }
}
