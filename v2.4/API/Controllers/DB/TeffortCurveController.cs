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
    public class TeffortCurveController : ControllerBase
    {
        private readonly DBContext _context;

        public TeffortCurveController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TeffortCurve
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeffortCurve>>> GetTeffortCurve()
        {
            return await _context.TeffortCurve.ToListAsync();
        }

        // GET: api/TeffortCurve/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeffortCurve>> GetTeffortCurve(short id)
        {
            var teffortCurve = await _context.TeffortCurve.FindAsync(id);

            if (teffortCurve == null)
            {
                return NotFound();
            }

            return teffortCurve;
        }

        // PUT: api/TeffortCurve/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeffortCurve(short id, TeffortCurve teffortCurve)
        {
            if (id != teffortCurve.TeffortCurveId)
            {
                return BadRequest();
            }

            _context.Entry(teffortCurve).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeffortCurveExists(id))
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

        // POST: api/TeffortCurve
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TeffortCurve>> PostTeffortCurve(TeffortCurve teffortCurve)
        {
            _context.TeffortCurve.Add(teffortCurve);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TeffortCurveExists(teffortCurve.TeffortCurveId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTeffortCurve", new { id = teffortCurve.TeffortCurveId }, teffortCurve);
        }

        // DELETE: api/TeffortCurve/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TeffortCurve>> DeleteTeffortCurve(short id)
        {
            var teffortCurve = await _context.TeffortCurve.FindAsync(id);
            if (teffortCurve == null)
            {
                return NotFound();
            }

            _context.TeffortCurve.Remove(teffortCurve);
            await _context.SaveChangesAsync();

            return teffortCurve;
        }

        private bool TeffortCurveExists(short id)
        {
            return _context.TeffortCurve.Any(e => e.TeffortCurveId == id);
        }
    }
}
