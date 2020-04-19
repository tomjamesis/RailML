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
    public class SourceController : ControllerBase
    {
        private readonly DBContext _context;

        public SourceController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Source
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Source>>> GetSource()
        {
            return await _context.Source.ToListAsync();
        }

        // GET: api/Source/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Source>> GetSource(short id)
        {
            var source = await _context.Source.FindAsync(id);

            if (source == null)
            {
                return NotFound();
            }

            return source;
        }

        // PUT: api/Source/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSource(short id, Source source)
        {
            if (id != source.SourceId)
            {
                return BadRequest();
            }

            _context.Entry(source).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SourceExists(id))
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

        // POST: api/Source
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Source>> PostSource(Source source)
        {
            _context.Source.Add(source);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SourceExists(source.SourceId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSource", new { id = source.SourceId }, source);
        }

        // DELETE: api/Source/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Source>> DeleteSource(short id)
        {
            var source = await _context.Source.FindAsync(id);
            if (source == null)
            {
                return NotFound();
            }

            _context.Source.Remove(source);
            await _context.SaveChangesAsync();

            return source;
        }

        private bool SourceExists(short id)
        {
            return _context.Source.Any(e => e.SourceId == id);
        }
    }
}
