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
    public class TsignalGroupController : ControllerBase
    {
        private readonly DBContext _context;

        public TsignalGroupController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TsignalGroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TsignalGroup>>> GetTsignalGroup()
        {
            return await _context.TsignalGroup.ToListAsync();
        }

        // GET: api/TsignalGroup/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TsignalGroup>> GetTsignalGroup(short id)
        {
            var tsignalGroup = await _context.TsignalGroup.FindAsync(id);

            if (tsignalGroup == null)
            {
                return NotFound();
            }

            return tsignalGroup;
        }

        // PUT: api/TsignalGroup/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTsignalGroup(short id, TsignalGroup tsignalGroup)
        {
            if (id != tsignalGroup.TsignalGroupId)
            {
                return BadRequest();
            }

            _context.Entry(tsignalGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TsignalGroupExists(id))
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

        // POST: api/TsignalGroup
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TsignalGroup>> PostTsignalGroup(TsignalGroup tsignalGroup)
        {
            _context.TsignalGroup.Add(tsignalGroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TsignalGroupExists(tsignalGroup.TsignalGroupId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTsignalGroup", new { id = tsignalGroup.TsignalGroupId }, tsignalGroup);
        }

        // DELETE: api/TsignalGroup/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TsignalGroup>> DeleteTsignalGroup(short id)
        {
            var tsignalGroup = await _context.TsignalGroup.FindAsync(id);
            if (tsignalGroup == null)
            {
                return NotFound();
            }

            _context.TsignalGroup.Remove(tsignalGroup);
            await _context.SaveChangesAsync();

            return tsignalGroup;
        }

        private bool TsignalGroupExists(short id)
        {
            return _context.TsignalGroup.Any(e => e.TsignalGroupId == id);
        }
    }
}
