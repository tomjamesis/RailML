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
    public class TlineController : ControllerBase
    {
        private readonly DBContext _context;

        public TlineController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tline
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tline>>> GetTline()
        {
            return await _context.Tline.ToListAsync();
        }

        // GET: api/Tline/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tline>> GetTline(short id)
        {
            var tline = await _context.Tline.FindAsync(id);

            if (tline == null)
            {
                return NotFound();
            }

            return tline;
        }

        // PUT: api/Tline/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTline(short id, Tline tline)
        {
            if (id != tline.TlineId)
            {
                return BadRequest();
            }

            _context.Entry(tline).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TlineExists(id))
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

        // POST: api/Tline
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tline>> PostTline(Tline tline)
        {
            _context.Tline.Add(tline);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TlineExists(tline.TlineId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTline", new { id = tline.TlineId }, tline);
        }

        // DELETE: api/Tline/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tline>> DeleteTline(short id)
        {
            var tline = await _context.Tline.FindAsync(id);
            if (tline == null)
            {
                return NotFound();
            }

            _context.Tline.Remove(tline);
            await _context.SaveChangesAsync();

            return tline;
        }

        private bool TlineExists(short id)
        {
            return _context.Tline.Any(e => e.TlineId == id);
        }
    }
}
