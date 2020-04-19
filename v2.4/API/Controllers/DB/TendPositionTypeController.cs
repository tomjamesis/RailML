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
    public class TendPositionTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TendPositionTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TendPositionType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TendPositionType>>> GetTendPositionType()
        {
            return await _context.TendPositionType.ToListAsync();
        }

        // GET: api/TendPositionType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TendPositionType>> GetTendPositionType(byte id)
        {
            var tendPositionType = await _context.TendPositionType.FindAsync(id);

            if (tendPositionType == null)
            {
                return NotFound();
            }

            return tendPositionType;
        }

        // PUT: api/TendPositionType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTendPositionType(byte id, TendPositionType tendPositionType)
        {
            if (id != tendPositionType.TendPositionTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tendPositionType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TendPositionTypeExists(id))
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

        // POST: api/TendPositionType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TendPositionType>> PostTendPositionType(TendPositionType tendPositionType)
        {
            _context.TendPositionType.Add(tendPositionType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TendPositionTypeExists(tendPositionType.TendPositionTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTendPositionType", new { id = tendPositionType.TendPositionTypeId }, tendPositionType);
        }

        // DELETE: api/TendPositionType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TendPositionType>> DeleteTendPositionType(byte id)
        {
            var tendPositionType = await _context.TendPositionType.FindAsync(id);
            if (tendPositionType == null)
            {
                return NotFound();
            }

            _context.TendPositionType.Remove(tendPositionType);
            await _context.SaveChangesAsync();

            return tendPositionType;
        }

        private bool TendPositionTypeExists(byte id)
        {
            return _context.TendPositionType.Any(e => e.TendPositionTypeId == id);
        }
    }
}
