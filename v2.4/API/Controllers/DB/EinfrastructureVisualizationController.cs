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
    public class EinfrastructureVisualizationController : ControllerBase
    {
        private readonly DBContext _context;

        public EinfrastructureVisualizationController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EinfrastructureVisualization
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EinfrastructureVisualization>>> GetEinfrastructureVisualization()
        {
            return await _context.EinfrastructureVisualization.ToListAsync();
        }

        // GET: api/EinfrastructureVisualization/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EinfrastructureVisualization>> GetEinfrastructureVisualization(short id)
        {
            var einfrastructureVisualization = await _context.EinfrastructureVisualization.FindAsync(id);

            if (einfrastructureVisualization == null)
            {
                return NotFound();
            }

            return einfrastructureVisualization;
        }

        // PUT: api/EinfrastructureVisualization/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEinfrastructureVisualization(short id, EinfrastructureVisualization einfrastructureVisualization)
        {
            if (id != einfrastructureVisualization.EinfrastructureVisualizationId)
            {
                return BadRequest();
            }

            _context.Entry(einfrastructureVisualization).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EinfrastructureVisualizationExists(id))
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

        // POST: api/EinfrastructureVisualization
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EinfrastructureVisualization>> PostEinfrastructureVisualization(EinfrastructureVisualization einfrastructureVisualization)
        {
            _context.EinfrastructureVisualization.Add(einfrastructureVisualization);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EinfrastructureVisualizationExists(einfrastructureVisualization.EinfrastructureVisualizationId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEinfrastructureVisualization", new { id = einfrastructureVisualization.EinfrastructureVisualizationId }, einfrastructureVisualization);
        }

        // DELETE: api/EinfrastructureVisualization/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EinfrastructureVisualization>> DeleteEinfrastructureVisualization(short id)
        {
            var einfrastructureVisualization = await _context.EinfrastructureVisualization.FindAsync(id);
            if (einfrastructureVisualization == null)
            {
                return NotFound();
            }

            _context.EinfrastructureVisualization.Remove(einfrastructureVisualization);
            await _context.SaveChangesAsync();

            return einfrastructureVisualization;
        }

        private bool EinfrastructureVisualizationExists(short id)
        {
            return _context.EinfrastructureVisualization.Any(e => e.EinfrastructureVisualizationId == id);
        }
    }
}
