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
    public class TelementRefInGroupController : ControllerBase
    {
        private readonly DBContext _context;

        public TelementRefInGroupController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TelementRefInGroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TelementRefInGroup>>> GetTelementRefInGroup()
        {
            return await _context.TelementRefInGroup.ToListAsync();
        }

        // GET: api/TelementRefInGroup/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TelementRefInGroup>> GetTelementRefInGroup(short id)
        {
            var telementRefInGroup = await _context.TelementRefInGroup.FindAsync(id);

            if (telementRefInGroup == null)
            {
                return NotFound();
            }

            return telementRefInGroup;
        }

        // PUT: api/TelementRefInGroup/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTelementRefInGroup(short id, TelementRefInGroup telementRefInGroup)
        {
            if (id != telementRefInGroup.TelementRefInGroupId)
            {
                return BadRequest();
            }

            _context.Entry(telementRefInGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TelementRefInGroupExists(id))
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

        // POST: api/TelementRefInGroup
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TelementRefInGroup>> PostTelementRefInGroup(TelementRefInGroup telementRefInGroup)
        {
            _context.TelementRefInGroup.Add(telementRefInGroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TelementRefInGroupExists(telementRefInGroup.TelementRefInGroupId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTelementRefInGroup", new { id = telementRefInGroup.TelementRefInGroupId }, telementRefInGroup);
        }

        // DELETE: api/TelementRefInGroup/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TelementRefInGroup>> DeleteTelementRefInGroup(short id)
        {
            var telementRefInGroup = await _context.TelementRefInGroup.FindAsync(id);
            if (telementRefInGroup == null)
            {
                return NotFound();
            }

            _context.TelementRefInGroup.Remove(telementRefInGroup);
            await _context.SaveChangesAsync();

            return telementRefInGroup;
        }

        private bool TelementRefInGroupExists(short id)
        {
            return _context.TelementRefInGroup.Any(e => e.TelementRefInGroupId == id);
        }
    }
}
