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
    public class TcurveController : ControllerBase
    {
        private readonly DBContext _context;

        public TcurveController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tcurve
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tcurve>>> GetTcurve()
        {
            return await _context.Tcurve.ToListAsync();
        }

        // GET: api/Tcurve/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tcurve>> GetTcurve(long id)
        {
            var tcurve = await _context.Tcurve.FindAsync(id);

            if (tcurve == null)
            {
                return NotFound();
            }

            return tcurve;
        }

        // PUT: api/Tcurve/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTcurve(long id, Tcurve tcurve)
        {
            if (id != tcurve.TcurveId)
            {
                return BadRequest();
            }

            _context.Entry(tcurve).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TcurveExists(id))
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

        // POST: api/Tcurve
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tcurve>> PostTcurve(Tcurve tcurve)
        {
            _context.Tcurve.Add(tcurve);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TcurveExists(tcurve.TcurveId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTcurve", new { id = tcurve.TcurveId }, tcurve);
        }

        // DELETE: api/Tcurve/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tcurve>> DeleteTcurve(long id)
        {
            var tcurve = await _context.Tcurve.FindAsync(id);
            if (tcurve == null)
            {
                return NotFound();
            }

            _context.Tcurve.Remove(tcurve);
            await _context.SaveChangesAsync();

            return tcurve;
        }

        private bool TcurveExists(long id)
        {
            return _context.Tcurve.Any(e => e.TcurveId == id);
        }
    }
}
