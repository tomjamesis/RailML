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
    public class FormatController : ControllerBase
    {
        private readonly DBContext _context;

        public FormatController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Format
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Format>>> GetFormat()
        {
            return await _context.Format.ToListAsync();
        }

        // GET: api/Format/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Format>> GetFormat(short id)
        {
            var format = await _context.Format.FindAsync(id);

            if (format == null)
            {
                return NotFound();
            }

            return format;
        }

        // PUT: api/Format/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFormat(short id, Format format)
        {
            if (id != format.FormatId)
            {
                return BadRequest();
            }

            _context.Entry(format).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FormatExists(id))
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

        // POST: api/Format
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Format>> PostFormat(Format format)
        {
            _context.Format.Add(format);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FormatExists(format.FormatId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFormat", new { id = format.FormatId }, format);
        }

        // DELETE: api/Format/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Format>> DeleteFormat(short id)
        {
            var format = await _context.Format.FindAsync(id);
            if (format == null)
            {
                return NotFound();
            }

            _context.Format.Remove(format);
            await _context.SaveChangesAsync();

            return format;
        }

        private bool FormatExists(short id)
        {
            return _context.Format.Any(e => e.FormatId == id);
        }
    }
}
