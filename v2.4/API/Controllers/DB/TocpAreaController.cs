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
    public class TocpAreaController : ControllerBase
    {
        private readonly DBContext _context;

        public TocpAreaController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TocpArea
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TocpArea>>> GetTocpArea()
        {
            return await _context.TocpArea.ToListAsync();
        }

        // GET: api/TocpArea/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TocpArea>> GetTocpArea(long id)
        {
            var tocpArea = await _context.TocpArea.FindAsync(id);

            if (tocpArea == null)
            {
                return NotFound();
            }

            return tocpArea;
        }

        // PUT: api/TocpArea/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTocpArea(long id, TocpArea tocpArea)
        {
            if (id != tocpArea.TocpAreaId)
            {
                return BadRequest();
            }

            _context.Entry(tocpArea).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TocpAreaExists(id))
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

        // POST: api/TocpArea
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TocpArea>> PostTocpArea(TocpArea tocpArea)
        {
            _context.TocpArea.Add(tocpArea);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TocpAreaExists(tocpArea.TocpAreaId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTocpArea", new { id = tocpArea.TocpAreaId }, tocpArea);
        }

        // DELETE: api/TocpArea/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TocpArea>> DeleteTocpArea(long id)
        {
            var tocpArea = await _context.TocpArea.FindAsync(id);
            if (tocpArea == null)
            {
                return NotFound();
            }

            _context.TocpArea.Remove(tocpArea);
            await _context.SaveChangesAsync();

            return tocpArea;
        }

        private bool TocpAreaExists(long id)
        {
            return _context.TocpArea.Any(e => e.TocpAreaId == id);
        }
    }
}
