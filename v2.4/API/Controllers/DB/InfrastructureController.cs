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
    public class InfrastructureController : ControllerBase
    {
        private readonly DBContext _context;

        public InfrastructureController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Infrastructure
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Infrastructure>>> GetInfrastructure()
        {
            return await _context.Infrastructure.ToListAsync();
        }

        // GET: api/Infrastructure/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Infrastructure>> GetInfrastructure(short id)
        {
            var infrastructure = await _context.Infrastructure.FindAsync(id);

            if (infrastructure == null)
            {
                return NotFound();
            }

            return infrastructure;
        }

        // PUT: api/Infrastructure/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInfrastructure(short id, Infrastructure infrastructure)
        {
            if (id != infrastructure.InfrastructureId)
            {
                return BadRequest();
            }

            _context.Entry(infrastructure).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InfrastructureExists(id))
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

        // POST: api/Infrastructure
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Infrastructure>> PostInfrastructure(Infrastructure infrastructure)
        {
            _context.Infrastructure.Add(infrastructure);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (InfrastructureExists(infrastructure.InfrastructureId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetInfrastructure", new { id = infrastructure.InfrastructureId }, infrastructure);
        }

        // DELETE: api/Infrastructure/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Infrastructure>> DeleteInfrastructure(short id)
        {
            var infrastructure = await _context.Infrastructure.FindAsync(id);
            if (infrastructure == null)
            {
                return NotFound();
            }

            _context.Infrastructure.Remove(infrastructure);
            await _context.SaveChangesAsync();

            return infrastructure;
        }

        private bool InfrastructureExists(short id)
        {
            return _context.Infrastructure.Any(e => e.InfrastructureId == id);
        }
    }
}
