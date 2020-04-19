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
    public class TdecelerationCurveController : ControllerBase
    {
        private readonly DBContext _context;

        public TdecelerationCurveController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TdecelerationCurve
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TdecelerationCurve>>> GetTdecelerationCurve()
        {
            return await _context.TdecelerationCurve.ToListAsync();
        }

        // GET: api/TdecelerationCurve/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TdecelerationCurve>> GetTdecelerationCurve(short id)
        {
            var tdecelerationCurve = await _context.TdecelerationCurve.FindAsync(id);

            if (tdecelerationCurve == null)
            {
                return NotFound();
            }

            return tdecelerationCurve;
        }

        // PUT: api/TdecelerationCurve/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdecelerationCurve(short id, TdecelerationCurve tdecelerationCurve)
        {
            if (id != tdecelerationCurve.TdecelerationCurveId)
            {
                return BadRequest();
            }

            _context.Entry(tdecelerationCurve).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdecelerationCurveExists(id))
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

        // POST: api/TdecelerationCurve
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TdecelerationCurve>> PostTdecelerationCurve(TdecelerationCurve tdecelerationCurve)
        {
            _context.TdecelerationCurve.Add(tdecelerationCurve);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TdecelerationCurveExists(tdecelerationCurve.TdecelerationCurveId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTdecelerationCurve", new { id = tdecelerationCurve.TdecelerationCurveId }, tdecelerationCurve);
        }

        // DELETE: api/TdecelerationCurve/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TdecelerationCurve>> DeleteTdecelerationCurve(short id)
        {
            var tdecelerationCurve = await _context.TdecelerationCurve.FindAsync(id);
            if (tdecelerationCurve == null)
            {
                return NotFound();
            }

            _context.TdecelerationCurve.Remove(tdecelerationCurve);
            await _context.SaveChangesAsync();

            return tdecelerationCurve;
        }

        private bool TdecelerationCurveExists(short id)
        {
            return _context.TdecelerationCurve.Any(e => e.TdecelerationCurveId == id);
        }
    }
}
