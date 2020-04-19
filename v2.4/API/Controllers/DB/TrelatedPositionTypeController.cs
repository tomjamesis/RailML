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
    public class TrelatedPositionTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TrelatedPositionTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TrelatedPositionType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrelatedPositionType>>> GetTrelatedPositionType()
        {
            return await _context.TrelatedPositionType.ToListAsync();
        }

        // GET: api/TrelatedPositionType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrelatedPositionType>> GetTrelatedPositionType(byte id)
        {
            var trelatedPositionType = await _context.TrelatedPositionType.FindAsync(id);

            if (trelatedPositionType == null)
            {
                return NotFound();
            }

            return trelatedPositionType;
        }

        // PUT: api/TrelatedPositionType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrelatedPositionType(byte id, TrelatedPositionType trelatedPositionType)
        {
            if (id != trelatedPositionType.TrelatedPositionTypeId)
            {
                return BadRequest();
            }

            _context.Entry(trelatedPositionType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrelatedPositionTypeExists(id))
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

        // POST: api/TrelatedPositionType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TrelatedPositionType>> PostTrelatedPositionType(TrelatedPositionType trelatedPositionType)
        {
            _context.TrelatedPositionType.Add(trelatedPositionType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TrelatedPositionTypeExists(trelatedPositionType.TrelatedPositionTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTrelatedPositionType", new { id = trelatedPositionType.TrelatedPositionTypeId }, trelatedPositionType);
        }

        // DELETE: api/TrelatedPositionType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TrelatedPositionType>> DeleteTrelatedPositionType(byte id)
        {
            var trelatedPositionType = await _context.TrelatedPositionType.FindAsync(id);
            if (trelatedPositionType == null)
            {
                return NotFound();
            }

            _context.TrelatedPositionType.Remove(trelatedPositionType);
            await _context.SaveChangesAsync();

            return trelatedPositionType;
        }

        private bool TrelatedPositionTypeExists(byte id)
        {
            return _context.TrelatedPositionType.Any(e => e.TrelatedPositionTypeId == id);
        }
    }
}
