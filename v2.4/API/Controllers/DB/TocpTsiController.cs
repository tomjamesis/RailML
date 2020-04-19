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
    public class TocpTsiController : ControllerBase
    {
        private readonly DBContext _context;

        public TocpTsiController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TocpTsi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TocpTsi>>> GetTocpTsi()
        {
            return await _context.TocpTsi.ToListAsync();
        }

        // GET: api/TocpTsi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TocpTsi>> GetTocpTsi(long id)
        {
            var tocpTsi = await _context.TocpTsi.FindAsync(id);

            if (tocpTsi == null)
            {
                return NotFound();
            }

            return tocpTsi;
        }

        // PUT: api/TocpTsi/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTocpTsi(long id, TocpTsi tocpTsi)
        {
            if (id != tocpTsi.TocpTsiId)
            {
                return BadRequest();
            }

            _context.Entry(tocpTsi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TocpTsiExists(id))
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

        // POST: api/TocpTsi
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TocpTsi>> PostTocpTsi(TocpTsi tocpTsi)
        {
            _context.TocpTsi.Add(tocpTsi);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TocpTsiExists(tocpTsi.TocpTsiId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTocpTsi", new { id = tocpTsi.TocpTsiId }, tocpTsi);
        }

        // DELETE: api/TocpTsi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TocpTsi>> DeleteTocpTsi(long id)
        {
            var tocpTsi = await _context.TocpTsi.FindAsync(id);
            if (tocpTsi == null)
            {
                return NotFound();
            }

            _context.TocpTsi.Remove(tocpTsi);
            await _context.SaveChangesAsync();

            return tocpTsi;
        }

        private bool TocpTsiExists(long id)
        {
            return _context.TocpTsi.Any(e => e.TocpTsiId == id);
        }
    }
}
