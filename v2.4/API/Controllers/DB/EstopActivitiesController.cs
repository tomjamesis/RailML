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
    public class EstopActivitiesController : ControllerBase
    {
        private readonly DBContext _context;

        public EstopActivitiesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EstopActivities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstopActivities>>> GetEstopActivities()
        {
            return await _context.EstopActivities.ToListAsync();
        }

        // GET: api/EstopActivities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EstopActivities>> GetEstopActivities(long id)
        {
            var estopActivities = await _context.EstopActivities.FindAsync(id);

            if (estopActivities == null)
            {
                return NotFound();
            }

            return estopActivities;
        }

        // PUT: api/EstopActivities/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstopActivities(long id, EstopActivities estopActivities)
        {
            if (id != estopActivities.EstopActivitiesId)
            {
                return BadRequest();
            }

            _context.Entry(estopActivities).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstopActivitiesExists(id))
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

        // POST: api/EstopActivities
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EstopActivities>> PostEstopActivities(EstopActivities estopActivities)
        {
            _context.EstopActivities.Add(estopActivities);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EstopActivitiesExists(estopActivities.EstopActivitiesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEstopActivities", new { id = estopActivities.EstopActivitiesId }, estopActivities);
        }

        // DELETE: api/EstopActivities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EstopActivities>> DeleteEstopActivities(long id)
        {
            var estopActivities = await _context.EstopActivities.FindAsync(id);
            if (estopActivities == null)
            {
                return NotFound();
            }

            _context.EstopActivities.Remove(estopActivities);
            await _context.SaveChangesAsync();

            return estopActivities;
        }

        private bool EstopActivitiesExists(long id)
        {
            return _context.EstopActivities.Any(e => e.EstopActivitiesId == id);
        }
    }
}
