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
    public class EstopDescriptionController : ControllerBase
    {
        private readonly DBContext _context;

        public EstopDescriptionController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EstopDescription
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstopDescription>>> GetEstopDescription()
        {
            return await _context.EstopDescription.ToListAsync();
        }

        // GET: api/EstopDescription/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EstopDescription>> GetEstopDescription(short id)
        {
            var estopDescription = await _context.EstopDescription.FindAsync(id);

            if (estopDescription == null)
            {
                return NotFound();
            }

            return estopDescription;
        }

        // PUT: api/EstopDescription/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstopDescription(short id, EstopDescription estopDescription)
        {
            if (id != estopDescription.EstopDescriptionId)
            {
                return BadRequest();
            }

            _context.Entry(estopDescription).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstopDescriptionExists(id))
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

        // POST: api/EstopDescription
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EstopDescription>> PostEstopDescription(EstopDescription estopDescription)
        {
            _context.EstopDescription.Add(estopDescription);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EstopDescriptionExists(estopDescription.EstopDescriptionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEstopDescription", new { id = estopDescription.EstopDescriptionId }, estopDescription);
        }

        // DELETE: api/EstopDescription/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EstopDescription>> DeleteEstopDescription(short id)
        {
            var estopDescription = await _context.EstopDescription.FindAsync(id);
            if (estopDescription == null)
            {
                return NotFound();
            }

            _context.EstopDescription.Remove(estopDescription);
            await _context.SaveChangesAsync();

            return estopDescription;
        }

        private bool EstopDescriptionExists(short id)
        {
            return _context.EstopDescription.Any(e => e.EstopDescriptionId == id);
        }
    }
}
