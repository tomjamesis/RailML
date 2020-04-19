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
    public class TtrackRefInGroupController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrackRefInGroupController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrackRefInGroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrackRefInGroup>>> GetTtrackRefInGroup()
        {
            return await _context.TtrackRefInGroup.ToListAsync();
        }

        // GET: api/TtrackRefInGroup/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrackRefInGroup>> GetTtrackRefInGroup(short id)
        {
            var ttrackRefInGroup = await _context.TtrackRefInGroup.FindAsync(id);

            if (ttrackRefInGroup == null)
            {
                return NotFound();
            }

            return ttrackRefInGroup;
        }

        // PUT: api/TtrackRefInGroup/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrackRefInGroup(short id, TtrackRefInGroup ttrackRefInGroup)
        {
            if (id != ttrackRefInGroup.TtrackRefInGroupId)
            {
                return BadRequest();
            }

            _context.Entry(ttrackRefInGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrackRefInGroupExists(id))
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

        // POST: api/TtrackRefInGroup
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrackRefInGroup>> PostTtrackRefInGroup(TtrackRefInGroup ttrackRefInGroup)
        {
            _context.TtrackRefInGroup.Add(ttrackRefInGroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrackRefInGroupExists(ttrackRefInGroup.TtrackRefInGroupId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrackRefInGroup", new { id = ttrackRefInGroup.TtrackRefInGroupId }, ttrackRefInGroup);
        }

        // DELETE: api/TtrackRefInGroup/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrackRefInGroup>> DeleteTtrackRefInGroup(short id)
        {
            var ttrackRefInGroup = await _context.TtrackRefInGroup.FindAsync(id);
            if (ttrackRefInGroup == null)
            {
                return NotFound();
            }

            _context.TtrackRefInGroup.Remove(ttrackRefInGroup);
            await _context.SaveChangesAsync();

            return ttrackRefInGroup;
        }

        private bool TtrackRefInGroupExists(short id)
        {
            return _context.TtrackRefInGroup.Any(e => e.TtrackRefInGroupId == id);
        }
    }
}
