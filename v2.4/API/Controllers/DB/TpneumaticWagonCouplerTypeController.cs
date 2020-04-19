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
    public class TpneumaticWagonCouplerTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TpneumaticWagonCouplerTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TpneumaticWagonCouplerType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TpneumaticWagonCouplerType>>> GetTpneumaticWagonCouplerType()
        {
            return await _context.TpneumaticWagonCouplerType.ToListAsync();
        }

        // GET: api/TpneumaticWagonCouplerType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TpneumaticWagonCouplerType>> GetTpneumaticWagonCouplerType(long id)
        {
            var tpneumaticWagonCouplerType = await _context.TpneumaticWagonCouplerType.FindAsync(id);

            if (tpneumaticWagonCouplerType == null)
            {
                return NotFound();
            }

            return tpneumaticWagonCouplerType;
        }

        // PUT: api/TpneumaticWagonCouplerType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTpneumaticWagonCouplerType(long id, TpneumaticWagonCouplerType tpneumaticWagonCouplerType)
        {
            if (id != tpneumaticWagonCouplerType.TpneumaticWagonCouplerTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tpneumaticWagonCouplerType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TpneumaticWagonCouplerTypeExists(id))
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

        // POST: api/TpneumaticWagonCouplerType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TpneumaticWagonCouplerType>> PostTpneumaticWagonCouplerType(TpneumaticWagonCouplerType tpneumaticWagonCouplerType)
        {
            _context.TpneumaticWagonCouplerType.Add(tpneumaticWagonCouplerType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TpneumaticWagonCouplerTypeExists(tpneumaticWagonCouplerType.TpneumaticWagonCouplerTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTpneumaticWagonCouplerType", new { id = tpneumaticWagonCouplerType.TpneumaticWagonCouplerTypeId }, tpneumaticWagonCouplerType);
        }

        // DELETE: api/TpneumaticWagonCouplerType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TpneumaticWagonCouplerType>> DeleteTpneumaticWagonCouplerType(long id)
        {
            var tpneumaticWagonCouplerType = await _context.TpneumaticWagonCouplerType.FindAsync(id);
            if (tpneumaticWagonCouplerType == null)
            {
                return NotFound();
            }

            _context.TpneumaticWagonCouplerType.Remove(tpneumaticWagonCouplerType);
            await _context.SaveChangesAsync();

            return tpneumaticWagonCouplerType;
        }

        private bool TpneumaticWagonCouplerTypeExists(long id)
        {
            return _context.TpneumaticWagonCouplerType.Any(e => e.TpneumaticWagonCouplerTypeId == id);
        }
    }
}
