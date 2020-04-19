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
    public class TocpPropOtherController : ControllerBase
    {
        private readonly DBContext _context;

        public TocpPropOtherController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TocpPropOther
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TocpPropOther>>> GetTocpPropOther()
        {
            return await _context.TocpPropOther.ToListAsync();
        }

        // GET: api/TocpPropOther/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TocpPropOther>> GetTocpPropOther(long id)
        {
            var tocpPropOther = await _context.TocpPropOther.FindAsync(id);

            if (tocpPropOther == null)
            {
                return NotFound();
            }

            return tocpPropOther;
        }

        // PUT: api/TocpPropOther/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTocpPropOther(long id, TocpPropOther tocpPropOther)
        {
            if (id != tocpPropOther.TocpPropOtherId)
            {
                return BadRequest();
            }

            _context.Entry(tocpPropOther).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TocpPropOtherExists(id))
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

        // POST: api/TocpPropOther
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TocpPropOther>> PostTocpPropOther(TocpPropOther tocpPropOther)
        {
            _context.TocpPropOther.Add(tocpPropOther);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TocpPropOtherExists(tocpPropOther.TocpPropOtherId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTocpPropOther", new { id = tocpPropOther.TocpPropOtherId }, tocpPropOther);
        }

        // DELETE: api/TocpPropOther/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TocpPropOther>> DeleteTocpPropOther(long id)
        {
            var tocpPropOther = await _context.TocpPropOther.FindAsync(id);
            if (tocpPropOther == null)
            {
                return NotFound();
            }

            _context.TocpPropOther.Remove(tocpPropOther);
            await _context.SaveChangesAsync();

            return tocpPropOther;
        }

        private bool TocpPropOtherExists(long id)
        {
            return _context.TocpPropOther.Any(e => e.TocpPropOtherId == id);
        }
    }
}
