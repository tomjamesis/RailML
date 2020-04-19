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
    public class TocpRefInGroupController : ControllerBase
    {
        private readonly DBContext _context;

        public TocpRefInGroupController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TocpRefInGroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TocpRefInGroup>>> GetTocpRefInGroup()
        {
            return await _context.TocpRefInGroup.ToListAsync();
        }

        // GET: api/TocpRefInGroup/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TocpRefInGroup>> GetTocpRefInGroup(short id)
        {
            var tocpRefInGroup = await _context.TocpRefInGroup.FindAsync(id);

            if (tocpRefInGroup == null)
            {
                return NotFound();
            }

            return tocpRefInGroup;
        }

        // PUT: api/TocpRefInGroup/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTocpRefInGroup(short id, TocpRefInGroup tocpRefInGroup)
        {
            if (id != tocpRefInGroup.TocpRefInGroupId)
            {
                return BadRequest();
            }

            _context.Entry(tocpRefInGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TocpRefInGroupExists(id))
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

        // POST: api/TocpRefInGroup
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TocpRefInGroup>> PostTocpRefInGroup(TocpRefInGroup tocpRefInGroup)
        {
            _context.TocpRefInGroup.Add(tocpRefInGroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TocpRefInGroupExists(tocpRefInGroup.TocpRefInGroupId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTocpRefInGroup", new { id = tocpRefInGroup.TocpRefInGroupId }, tocpRefInGroup);
        }

        // DELETE: api/TocpRefInGroup/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TocpRefInGroup>> DeleteTocpRefInGroup(short id)
        {
            var tocpRefInGroup = await _context.TocpRefInGroup.FindAsync(id);
            if (tocpRefInGroup == null)
            {
                return NotFound();
            }

            _context.TocpRefInGroup.Remove(tocpRefInGroup);
            await _context.SaveChangesAsync();

            return tocpRefInGroup;
        }

        private bool TocpRefInGroupExists(short id)
        {
            return _context.TocpRefInGroup.Any(e => e.TocpRefInGroupId == id);
        }
    }
}
