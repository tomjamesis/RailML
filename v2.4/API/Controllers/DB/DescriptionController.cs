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
    public class DescriptionController : ControllerBase
    {
        private readonly DBContext _context;

        public DescriptionController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Description
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Description>>> GetDescription()
        {
            return await _context.Description.ToListAsync();
        }

        // GET: api/Description/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Description>> GetDescription(short id)
        {
            var description = await _context.Description.FindAsync(id);

            if (description == null)
            {
                return NotFound();
            }

            return description;
        }

        // PUT: api/Description/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDescription(short id, Description description)
        {
            if (id != description.DescriptionId)
            {
                return BadRequest();
            }

            _context.Entry(description).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DescriptionExists(id))
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

        // POST: api/Description
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Description>> PostDescription(Description description)
        {
            _context.Description.Add(description);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DescriptionExists(description.DescriptionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDescription", new { id = description.DescriptionId }, description);
        }

        // DELETE: api/Description/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Description>> DeleteDescription(short id)
        {
            var description = await _context.Description.FindAsync(id);
            if (description == null)
            {
                return NotFound();
            }

            _context.Description.Remove(description);
            await _context.SaveChangesAsync();

            return description;
        }

        private bool DescriptionExists(short id)
        {
            return _context.Description.Any(e => e.DescriptionId == id);
        }
    }
}
