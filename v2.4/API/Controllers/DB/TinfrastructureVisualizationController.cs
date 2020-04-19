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
    public class TinfrastructureVisualizationController : ControllerBase
    {
        private readonly DBContext _context;

        public TinfrastructureVisualizationController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TinfrastructureVisualization
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TinfrastructureVisualization>>> GetTinfrastructureVisualization()
        {
            return await _context.TinfrastructureVisualization.ToListAsync();
        }

        // GET: api/TinfrastructureVisualization/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TinfrastructureVisualization>> GetTinfrastructureVisualization(string id)
        {
            var tinfrastructureVisualization = await _context.TinfrastructureVisualization.FindAsync(id);

            if (tinfrastructureVisualization == null)
            {
                return NotFound();
            }

            return tinfrastructureVisualization;
        }

        // PUT: api/TinfrastructureVisualization/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTinfrastructureVisualization(string id, TinfrastructureVisualization tinfrastructureVisualization)
        {
            if (id != tinfrastructureVisualization.TinfrastructureVisualizationId)
            {
                return BadRequest();
            }

            _context.Entry(tinfrastructureVisualization).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TinfrastructureVisualizationExists(id))
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

        // POST: api/TinfrastructureVisualization
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TinfrastructureVisualization>> PostTinfrastructureVisualization(TinfrastructureVisualization tinfrastructureVisualization)
        {
            _context.TinfrastructureVisualization.Add(tinfrastructureVisualization);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TinfrastructureVisualizationExists(tinfrastructureVisualization.TinfrastructureVisualizationId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTinfrastructureVisualization", new { id = tinfrastructureVisualization.TinfrastructureVisualizationId }, tinfrastructureVisualization);
        }

        // DELETE: api/TinfrastructureVisualization/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TinfrastructureVisualization>> DeleteTinfrastructureVisualization(string id)
        {
            var tinfrastructureVisualization = await _context.TinfrastructureVisualization.FindAsync(id);
            if (tinfrastructureVisualization == null)
            {
                return NotFound();
            }

            _context.TinfrastructureVisualization.Remove(tinfrastructureVisualization);
            await _context.SaveChangesAsync();

            return tinfrastructureVisualization;
        }

        private bool TinfrastructureVisualizationExists(string id)
        {
            return _context.TinfrastructureVisualization.Any(e => e.TinfrastructureVisualizationId == id);
        }
    }
}
