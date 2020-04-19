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
    public class TbaliseRefInGroupController : ControllerBase
    {
        private readonly DBContext _context;

        public TbaliseRefInGroupController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TbaliseRefInGroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbaliseRefInGroup>>> GetTbaliseRefInGroup()
        {
            return await _context.TbaliseRefInGroup.ToListAsync();
        }

        // GET: api/TbaliseRefInGroup/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbaliseRefInGroup>> GetTbaliseRefInGroup(short id)
        {
            var tbaliseRefInGroup = await _context.TbaliseRefInGroup.FindAsync(id);

            if (tbaliseRefInGroup == null)
            {
                return NotFound();
            }

            return tbaliseRefInGroup;
        }

        // PUT: api/TbaliseRefInGroup/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbaliseRefInGroup(short id, TbaliseRefInGroup tbaliseRefInGroup)
        {
            if (id != tbaliseRefInGroup.TbaliseRefInGroupId)
            {
                return BadRequest();
            }

            _context.Entry(tbaliseRefInGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbaliseRefInGroupExists(id))
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

        // POST: api/TbaliseRefInGroup
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TbaliseRefInGroup>> PostTbaliseRefInGroup(TbaliseRefInGroup tbaliseRefInGroup)
        {
            _context.TbaliseRefInGroup.Add(tbaliseRefInGroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbaliseRefInGroupExists(tbaliseRefInGroup.TbaliseRefInGroupId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbaliseRefInGroup", new { id = tbaliseRefInGroup.TbaliseRefInGroupId }, tbaliseRefInGroup);
        }

        // DELETE: api/TbaliseRefInGroup/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbaliseRefInGroup>> DeleteTbaliseRefInGroup(short id)
        {
            var tbaliseRefInGroup = await _context.TbaliseRefInGroup.FindAsync(id);
            if (tbaliseRefInGroup == null)
            {
                return NotFound();
            }

            _context.TbaliseRefInGroup.Remove(tbaliseRefInGroup);
            await _context.SaveChangesAsync();

            return tbaliseRefInGroup;
        }

        private bool TbaliseRefInGroupExists(short id)
        {
            return _context.TbaliseRefInGroup.Any(e => e.TbaliseRefInGroupId == id);
        }
    }
}
