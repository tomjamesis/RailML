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
    public class TcurrentCurveController : ControllerBase
    {
        private readonly DBContext _context;

        public TcurrentCurveController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TcurrentCurve
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TcurrentCurve>>> GetTcurrentCurve()
        {
            return await _context.TcurrentCurve.ToListAsync();
        }

        // GET: api/TcurrentCurve/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TcurrentCurve>> GetTcurrentCurve(short id)
        {
            var tcurrentCurve = await _context.TcurrentCurve.FindAsync(id);

            if (tcurrentCurve == null)
            {
                return NotFound();
            }

            return tcurrentCurve;
        }

        // PUT: api/TcurrentCurve/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTcurrentCurve(short id, TcurrentCurve tcurrentCurve)
        {
            if (id != tcurrentCurve.TcurrentCurveId)
            {
                return BadRequest();
            }

            _context.Entry(tcurrentCurve).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TcurrentCurveExists(id))
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

        // POST: api/TcurrentCurve
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TcurrentCurve>> PostTcurrentCurve(TcurrentCurve tcurrentCurve)
        {
            _context.TcurrentCurve.Add(tcurrentCurve);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TcurrentCurveExists(tcurrentCurve.TcurrentCurveId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTcurrentCurve", new { id = tcurrentCurve.TcurrentCurveId }, tcurrentCurve);
        }

        // DELETE: api/TcurrentCurve/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TcurrentCurve>> DeleteTcurrentCurve(short id)
        {
            var tcurrentCurve = await _context.TcurrentCurve.FindAsync(id);
            if (tcurrentCurve == null)
            {
                return NotFound();
            }

            _context.TcurrentCurve.Remove(tcurrentCurve);
            await _context.SaveChangesAsync();

            return tcurrentCurve;
        }

        private bool TcurrentCurveExists(short id)
        {
            return _context.TcurrentCurve.Any(e => e.TcurrentCurveId == id);
        }
    }
}
