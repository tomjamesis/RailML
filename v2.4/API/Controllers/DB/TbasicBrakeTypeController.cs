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
    public class TbasicBrakeTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TbasicBrakeTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TbasicBrakeType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbasicBrakeType>>> GetTbasicBrakeType()
        {
            return await _context.TbasicBrakeType.ToListAsync();
        }

        // GET: api/TbasicBrakeType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbasicBrakeType>> GetTbasicBrakeType(long id)
        {
            var tbasicBrakeType = await _context.TbasicBrakeType.FindAsync(id);

            if (tbasicBrakeType == null)
            {
                return NotFound();
            }

            return tbasicBrakeType;
        }

        // PUT: api/TbasicBrakeType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbasicBrakeType(long id, TbasicBrakeType tbasicBrakeType)
        {
            if (id != tbasicBrakeType.TbasicBrakeTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tbasicBrakeType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbasicBrakeTypeExists(id))
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

        // POST: api/TbasicBrakeType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TbasicBrakeType>> PostTbasicBrakeType(TbasicBrakeType tbasicBrakeType)
        {
            _context.TbasicBrakeType.Add(tbasicBrakeType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbasicBrakeTypeExists(tbasicBrakeType.TbasicBrakeTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbasicBrakeType", new { id = tbasicBrakeType.TbasicBrakeTypeId }, tbasicBrakeType);
        }

        // DELETE: api/TbasicBrakeType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbasicBrakeType>> DeleteTbasicBrakeType(long id)
        {
            var tbasicBrakeType = await _context.TbasicBrakeType.FindAsync(id);
            if (tbasicBrakeType == null)
            {
                return NotFound();
            }

            _context.TbasicBrakeType.Remove(tbasicBrakeType);
            await _context.SaveChangesAsync();

            return tbasicBrakeType;
        }

        private bool TbasicBrakeTypeExists(long id)
        {
            return _context.TbasicBrakeType.Any(e => e.TbasicBrakeTypeId == id);
        }
    }
}
