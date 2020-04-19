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
    public class TstatisticAnalysesController : ControllerBase
    {
        private readonly DBContext _context;

        public TstatisticAnalysesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TstatisticAnalyses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TstatisticAnalyses>>> GetTstatisticAnalyses()
        {
            return await _context.TstatisticAnalyses.ToListAsync();
        }

        // GET: api/TstatisticAnalyses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TstatisticAnalyses>> GetTstatisticAnalyses(long id)
        {
            var tstatisticAnalyses = await _context.TstatisticAnalyses.FindAsync(id);

            if (tstatisticAnalyses == null)
            {
                return NotFound();
            }

            return tstatisticAnalyses;
        }

        // PUT: api/TstatisticAnalyses/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTstatisticAnalyses(long id, TstatisticAnalyses tstatisticAnalyses)
        {
            if (id != tstatisticAnalyses.TstatisticAnalysesId)
            {
                return BadRequest();
            }

            _context.Entry(tstatisticAnalyses).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TstatisticAnalysesExists(id))
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

        // POST: api/TstatisticAnalyses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TstatisticAnalyses>> PostTstatisticAnalyses(TstatisticAnalyses tstatisticAnalyses)
        {
            _context.TstatisticAnalyses.Add(tstatisticAnalyses);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TstatisticAnalysesExists(tstatisticAnalyses.TstatisticAnalysesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTstatisticAnalyses", new { id = tstatisticAnalyses.TstatisticAnalysesId }, tstatisticAnalyses);
        }

        // DELETE: api/TstatisticAnalyses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TstatisticAnalyses>> DeleteTstatisticAnalyses(long id)
        {
            var tstatisticAnalyses = await _context.TstatisticAnalyses.FindAsync(id);
            if (tstatisticAnalyses == null)
            {
                return NotFound();
            }

            _context.TstatisticAnalyses.Remove(tstatisticAnalyses);
            await _context.SaveChangesAsync();

            return tstatisticAnalyses;
        }

        private bool TstatisticAnalysesExists(long id)
        {
            return _context.TstatisticAnalyses.Any(e => e.TstatisticAnalysesId == id);
        }
    }
}
