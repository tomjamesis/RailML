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
    public class TocpCenterSideController : ControllerBase
    {
        private readonly DBContext _context;

        public TocpCenterSideController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TocpCenterSide
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TocpCenterSide>>> GetTocpCenterSide()
        {
            return await _context.TocpCenterSide.ToListAsync();
        }

        // GET: api/TocpCenterSide/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TocpCenterSide>> GetTocpCenterSide(byte id)
        {
            var tocpCenterSide = await _context.TocpCenterSide.FindAsync(id);

            if (tocpCenterSide == null)
            {
                return NotFound();
            }

            return tocpCenterSide;
        }

        // PUT: api/TocpCenterSide/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTocpCenterSide(byte id, TocpCenterSide tocpCenterSide)
        {
            if (id != tocpCenterSide.TocpCenterSideId)
            {
                return BadRequest();
            }

            _context.Entry(tocpCenterSide).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TocpCenterSideExists(id))
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

        // POST: api/TocpCenterSide
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TocpCenterSide>> PostTocpCenterSide(TocpCenterSide tocpCenterSide)
        {
            _context.TocpCenterSide.Add(tocpCenterSide);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TocpCenterSideExists(tocpCenterSide.TocpCenterSideId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTocpCenterSide", new { id = tocpCenterSide.TocpCenterSideId }, tocpCenterSide);
        }

        // DELETE: api/TocpCenterSide/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TocpCenterSide>> DeleteTocpCenterSide(byte id)
        {
            var tocpCenterSide = await _context.TocpCenterSide.FindAsync(id);
            if (tocpCenterSide == null)
            {
                return NotFound();
            }

            _context.TocpCenterSide.Remove(tocpCenterSide);
            await _context.SaveChangesAsync();

            return tocpCenterSide;
        }

        private bool TocpCenterSideExists(byte id)
        {
            return _context.TocpCenterSide.Any(e => e.TocpCenterSideId == id);
        }
    }
}
