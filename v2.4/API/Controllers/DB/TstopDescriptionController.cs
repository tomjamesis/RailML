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
    public class TstopDescriptionController : ControllerBase
    {
        private readonly DBContext _context;

        public TstopDescriptionController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TstopDescription
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TstopDescription>>> GetTstopDescription()
        {
            return await _context.TstopDescription.ToListAsync();
        }

        // GET: api/TstopDescription/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TstopDescription>> GetTstopDescription(long id)
        {
            var tstopDescription = await _context.TstopDescription.FindAsync(id);

            if (tstopDescription == null)
            {
                return NotFound();
            }

            return tstopDescription;
        }

        // PUT: api/TstopDescription/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTstopDescription(long id, TstopDescription tstopDescription)
        {
            if (id != tstopDescription.TstopDescriptionId)
            {
                return BadRequest();
            }

            _context.Entry(tstopDescription).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TstopDescriptionExists(id))
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

        // POST: api/TstopDescription
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TstopDescription>> PostTstopDescription(TstopDescription tstopDescription)
        {
            _context.TstopDescription.Add(tstopDescription);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TstopDescriptionExists(tstopDescription.TstopDescriptionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTstopDescription", new { id = tstopDescription.TstopDescriptionId }, tstopDescription);
        }

        // DELETE: api/TstopDescription/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TstopDescription>> DeleteTstopDescription(long id)
        {
            var tstopDescription = await _context.TstopDescription.FindAsync(id);
            if (tstopDescription == null)
            {
                return NotFound();
            }

            _context.TstopDescription.Remove(tstopDescription);
            await _context.SaveChangesAsync();

            return tstopDescription;
        }

        private bool TstopDescriptionExists(long id)
        {
            return _context.TstopDescription.Any(e => e.TstopDescriptionId == id);
        }
    }
}
