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
    public class TocpPropOperationalController : ControllerBase
    {
        private readonly DBContext _context;

        public TocpPropOperationalController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TocpPropOperational
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TocpPropOperational>>> GetTocpPropOperational()
        {
            return await _context.TocpPropOperational.ToListAsync();
        }

        // GET: api/TocpPropOperational/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TocpPropOperational>> GetTocpPropOperational(long id)
        {
            var tocpPropOperational = await _context.TocpPropOperational.FindAsync(id);

            if (tocpPropOperational == null)
            {
                return NotFound();
            }

            return tocpPropOperational;
        }

        // PUT: api/TocpPropOperational/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTocpPropOperational(long id, TocpPropOperational tocpPropOperational)
        {
            if (id != tocpPropOperational.TocpPropOperationalId)
            {
                return BadRequest();
            }

            _context.Entry(tocpPropOperational).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TocpPropOperationalExists(id))
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

        // POST: api/TocpPropOperational
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TocpPropOperational>> PostTocpPropOperational(TocpPropOperational tocpPropOperational)
        {
            _context.TocpPropOperational.Add(tocpPropOperational);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TocpPropOperationalExists(tocpPropOperational.TocpPropOperationalId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTocpPropOperational", new { id = tocpPropOperational.TocpPropOperationalId }, tocpPropOperational);
        }

        // DELETE: api/TocpPropOperational/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TocpPropOperational>> DeleteTocpPropOperational(long id)
        {
            var tocpPropOperational = await _context.TocpPropOperational.FindAsync(id);
            if (tocpPropOperational == null)
            {
                return NotFound();
            }

            _context.TocpPropOperational.Remove(tocpPropOperational);
            await _context.SaveChangesAsync();

            return tocpPropOperational;
        }

        private bool TocpPropOperationalExists(long id)
        {
            return _context.TocpPropOperational.Any(e => e.TocpPropOperationalId == id);
        }
    }
}
