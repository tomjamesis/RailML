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
    public class TspeedRangeTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TspeedRangeTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TspeedRangeType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TspeedRangeType>>> GetTspeedRangeType()
        {
            return await _context.TspeedRangeType.ToListAsync();
        }

        // GET: api/TspeedRangeType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TspeedRangeType>> GetTspeedRangeType(byte id)
        {
            var tspeedRangeType = await _context.TspeedRangeType.FindAsync(id);

            if (tspeedRangeType == null)
            {
                return NotFound();
            }

            return tspeedRangeType;
        }

        // PUT: api/TspeedRangeType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTspeedRangeType(byte id, TspeedRangeType tspeedRangeType)
        {
            if (id != tspeedRangeType.TspeedRangeTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tspeedRangeType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TspeedRangeTypeExists(id))
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

        // POST: api/TspeedRangeType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TspeedRangeType>> PostTspeedRangeType(TspeedRangeType tspeedRangeType)
        {
            _context.TspeedRangeType.Add(tspeedRangeType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TspeedRangeTypeExists(tspeedRangeType.TspeedRangeTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTspeedRangeType", new { id = tspeedRangeType.TspeedRangeTypeId }, tspeedRangeType);
        }

        // DELETE: api/TspeedRangeType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TspeedRangeType>> DeleteTspeedRangeType(byte id)
        {
            var tspeedRangeType = await _context.TspeedRangeType.FindAsync(id);
            if (tspeedRangeType == null)
            {
                return NotFound();
            }

            _context.TspeedRangeType.Remove(tspeedRangeType);
            await _context.SaveChangesAsync();

            return tspeedRangeType;
        }

        private bool TspeedRangeTypeExists(byte id)
        {
            return _context.TspeedRangeType.Any(e => e.TspeedRangeTypeId == id);
        }
    }
}
