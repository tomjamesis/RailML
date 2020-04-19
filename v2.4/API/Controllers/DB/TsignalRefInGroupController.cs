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
    public class TsignalRefInGroupController : ControllerBase
    {
        private readonly DBContext _context;

        public TsignalRefInGroupController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TsignalRefInGroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TsignalRefInGroup>>> GetTsignalRefInGroup()
        {
            return await _context.TsignalRefInGroup.ToListAsync();
        }

        // GET: api/TsignalRefInGroup/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TsignalRefInGroup>> GetTsignalRefInGroup(short id)
        {
            var tsignalRefInGroup = await _context.TsignalRefInGroup.FindAsync(id);

            if (tsignalRefInGroup == null)
            {
                return NotFound();
            }

            return tsignalRefInGroup;
        }

        // PUT: api/TsignalRefInGroup/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTsignalRefInGroup(short id, TsignalRefInGroup tsignalRefInGroup)
        {
            if (id != tsignalRefInGroup.TsignalRefInGroupId)
            {
                return BadRequest();
            }

            _context.Entry(tsignalRefInGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TsignalRefInGroupExists(id))
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

        // POST: api/TsignalRefInGroup
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TsignalRefInGroup>> PostTsignalRefInGroup(TsignalRefInGroup tsignalRefInGroup)
        {
            _context.TsignalRefInGroup.Add(tsignalRefInGroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TsignalRefInGroupExists(tsignalRefInGroup.TsignalRefInGroupId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTsignalRefInGroup", new { id = tsignalRefInGroup.TsignalRefInGroupId }, tsignalRefInGroup);
        }

        // DELETE: api/TsignalRefInGroup/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TsignalRefInGroup>> DeleteTsignalRefInGroup(short id)
        {
            var tsignalRefInGroup = await _context.TsignalRefInGroup.FindAsync(id);
            if (tsignalRefInGroup == null)
            {
                return NotFound();
            }

            _context.TsignalRefInGroup.Remove(tsignalRefInGroup);
            await _context.SaveChangesAsync();

            return tsignalRefInGroup;
        }

        private bool TsignalRefInGroupExists(short id)
        {
            return _context.TsignalRefInGroup.Any(e => e.TsignalRefInGroupId == id);
        }
    }
}
