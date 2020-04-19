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
    public class TtrainProtectionElementGroupController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainProtectionElementGroupController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrainProtectionElementGroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrainProtectionElementGroup>>> GetTtrainProtectionElementGroup()
        {
            return await _context.TtrainProtectionElementGroup.ToListAsync();
        }

        // GET: api/TtrainProtectionElementGroup/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrainProtectionElementGroup>> GetTtrainProtectionElementGroup(short id)
        {
            var ttrainProtectionElementGroup = await _context.TtrainProtectionElementGroup.FindAsync(id);

            if (ttrainProtectionElementGroup == null)
            {
                return NotFound();
            }

            return ttrainProtectionElementGroup;
        }

        // PUT: api/TtrainProtectionElementGroup/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrainProtectionElementGroup(short id, TtrainProtectionElementGroup ttrainProtectionElementGroup)
        {
            if (id != ttrainProtectionElementGroup.TtrainProtectionElementGroupId)
            {
                return BadRequest();
            }

            _context.Entry(ttrainProtectionElementGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainProtectionElementGroupExists(id))
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

        // POST: api/TtrainProtectionElementGroup
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrainProtectionElementGroup>> PostTtrainProtectionElementGroup(TtrainProtectionElementGroup ttrainProtectionElementGroup)
        {
            _context.TtrainProtectionElementGroup.Add(ttrainProtectionElementGroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainProtectionElementGroupExists(ttrainProtectionElementGroup.TtrainProtectionElementGroupId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrainProtectionElementGroup", new { id = ttrainProtectionElementGroup.TtrainProtectionElementGroupId }, ttrainProtectionElementGroup);
        }

        // DELETE: api/TtrainProtectionElementGroup/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrainProtectionElementGroup>> DeleteTtrainProtectionElementGroup(short id)
        {
            var ttrainProtectionElementGroup = await _context.TtrainProtectionElementGroup.FindAsync(id);
            if (ttrainProtectionElementGroup == null)
            {
                return NotFound();
            }

            _context.TtrainProtectionElementGroup.Remove(ttrainProtectionElementGroup);
            await _context.SaveChangesAsync();

            return ttrainProtectionElementGroup;
        }

        private bool TtrainProtectionElementGroupExists(short id)
        {
            return _context.TtrainProtectionElementGroup.Any(e => e.TtrainProtectionElementGroupId == id);
        }
    }
}
