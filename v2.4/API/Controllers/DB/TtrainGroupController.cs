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
    public class TtrainGroupController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainGroupController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrainGroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrainGroup>>> GetTtrainGroup()
        {
            return await _context.TtrainGroup.ToListAsync();
        }

        // GET: api/TtrainGroup/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrainGroup>> GetTtrainGroup(short id)
        {
            var ttrainGroup = await _context.TtrainGroup.FindAsync(id);

            if (ttrainGroup == null)
            {
                return NotFound();
            }

            return ttrainGroup;
        }

        // PUT: api/TtrainGroup/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrainGroup(short id, TtrainGroup ttrainGroup)
        {
            if (id != ttrainGroup.TtrainGroupId)
            {
                return BadRequest();
            }

            _context.Entry(ttrainGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainGroupExists(id))
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

        // POST: api/TtrainGroup
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrainGroup>> PostTtrainGroup(TtrainGroup ttrainGroup)
        {
            _context.TtrainGroup.Add(ttrainGroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainGroupExists(ttrainGroup.TtrainGroupId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrainGroup", new { id = ttrainGroup.TtrainGroupId }, ttrainGroup);
        }

        // DELETE: api/TtrainGroup/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrainGroup>> DeleteTtrainGroup(short id)
        {
            var ttrainGroup = await _context.TtrainGroup.FindAsync(id);
            if (ttrainGroup == null)
            {
                return NotFound();
            }

            _context.TtrainGroup.Remove(ttrainGroup);
            await _context.SaveChangesAsync();

            return ttrainGroup;
        }

        private bool TtrainGroupExists(short id)
        {
            return _context.TtrainGroup.Any(e => e.TtrainGroupId == id);
        }
    }
}
