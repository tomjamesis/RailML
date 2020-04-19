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
    public class TbaliseGroupController : ControllerBase
    {
        private readonly DBContext _context;

        public TbaliseGroupController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TbaliseGroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbaliseGroup>>> GetTbaliseGroup()
        {
            return await _context.TbaliseGroup.ToListAsync();
        }

        // GET: api/TbaliseGroup/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbaliseGroup>> GetTbaliseGroup(short id)
        {
            var tbaliseGroup = await _context.TbaliseGroup.FindAsync(id);

            if (tbaliseGroup == null)
            {
                return NotFound();
            }

            return tbaliseGroup;
        }

        // PUT: api/TbaliseGroup/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbaliseGroup(short id, TbaliseGroup tbaliseGroup)
        {
            if (id != tbaliseGroup.TbaliseGroupId)
            {
                return BadRequest();
            }

            _context.Entry(tbaliseGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbaliseGroupExists(id))
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

        // POST: api/TbaliseGroup
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TbaliseGroup>> PostTbaliseGroup(TbaliseGroup tbaliseGroup)
        {
            _context.TbaliseGroup.Add(tbaliseGroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbaliseGroupExists(tbaliseGroup.TbaliseGroupId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbaliseGroup", new { id = tbaliseGroup.TbaliseGroupId }, tbaliseGroup);
        }

        // DELETE: api/TbaliseGroup/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbaliseGroup>> DeleteTbaliseGroup(short id)
        {
            var tbaliseGroup = await _context.TbaliseGroup.FindAsync(id);
            if (tbaliseGroup == null)
            {
                return NotFound();
            }

            _context.TbaliseGroup.Remove(tbaliseGroup);
            await _context.SaveChangesAsync();

            return tbaliseGroup;
        }

        private bool TbaliseGroupExists(short id)
        {
            return _context.TbaliseGroup.Any(e => e.TbaliseGroupId == id);
        }
    }
}
