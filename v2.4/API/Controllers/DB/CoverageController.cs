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
    public class CoverageController : ControllerBase
    {
        private readonly DBContext _context;

        public CoverageController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Coverage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Coverage>>> GetCoverage()
        {
            return await _context.Coverage.ToListAsync();
        }

        // GET: api/Coverage/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Coverage>> GetCoverage(short id)
        {
            var coverage = await _context.Coverage.FindAsync(id);

            if (coverage == null)
            {
                return NotFound();
            }

            return coverage;
        }

        // PUT: api/Coverage/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCoverage(short id, Coverage coverage)
        {
            if (id != coverage.CoverageId)
            {
                return BadRequest();
            }

            _context.Entry(coverage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoverageExists(id))
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

        // POST: api/Coverage
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Coverage>> PostCoverage(Coverage coverage)
        {
            _context.Coverage.Add(coverage);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CoverageExists(coverage.CoverageId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCoverage", new { id = coverage.CoverageId }, coverage);
        }

        // DELETE: api/Coverage/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Coverage>> DeleteCoverage(short id)
        {
            var coverage = await _context.Coverage.FindAsync(id);
            if (coverage == null)
            {
                return NotFound();
            }

            _context.Coverage.Remove(coverage);
            await _context.SaveChangesAsync();

            return coverage;
        }

        private bool CoverageExists(short id)
        {
            return _context.Coverage.Any(e => e.CoverageId == id);
        }
    }
}
