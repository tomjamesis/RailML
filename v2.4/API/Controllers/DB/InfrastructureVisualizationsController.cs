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
    public class InfrastructureVisualizationsController : ControllerBase
    {
        private readonly DBContext _context;

        public InfrastructureVisualizationsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/InfrastructureVisualizations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InfrastructureVisualizations>>> GetInfrastructureVisualizations()
        {
            return await _context.InfrastructureVisualizations.ToListAsync();
        }

        // GET: api/InfrastructureVisualizations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InfrastructureVisualizations>> GetInfrastructureVisualizations(long id)
        {
            var infrastructureVisualizations = await _context.InfrastructureVisualizations.FindAsync(id);

            if (infrastructureVisualizations == null)
            {
                return NotFound();
            }

            return infrastructureVisualizations;
        }

        // PUT: api/InfrastructureVisualizations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInfrastructureVisualizations(long id, InfrastructureVisualizations infrastructureVisualizations)
        {
            if (id != infrastructureVisualizations.InfrastructureVisualizationsId)
            {
                return BadRequest();
            }

            _context.Entry(infrastructureVisualizations).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InfrastructureVisualizationsExists(id))
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

        // POST: api/InfrastructureVisualizations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<InfrastructureVisualizations>> PostInfrastructureVisualizations(InfrastructureVisualizations infrastructureVisualizations)
        {
            _context.InfrastructureVisualizations.Add(infrastructureVisualizations);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (InfrastructureVisualizationsExists(infrastructureVisualizations.InfrastructureVisualizationsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetInfrastructureVisualizations", new { id = infrastructureVisualizations.InfrastructureVisualizationsId }, infrastructureVisualizations);
        }

        // DELETE: api/InfrastructureVisualizations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InfrastructureVisualizations>> DeleteInfrastructureVisualizations(long id)
        {
            var infrastructureVisualizations = await _context.InfrastructureVisualizations.FindAsync(id);
            if (infrastructureVisualizations == null)
            {
                return NotFound();
            }

            _context.InfrastructureVisualizations.Remove(infrastructureVisualizations);
            await _context.SaveChangesAsync();

            return infrastructureVisualizations;
        }

        private bool InfrastructureVisualizationsExists(long id)
        {
            return _context.InfrastructureVisualizations.Any(e => e.InfrastructureVisualizationsId == id);
        }
    }
}
