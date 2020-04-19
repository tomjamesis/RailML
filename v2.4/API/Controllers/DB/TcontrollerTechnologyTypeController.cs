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
    public class TcontrollerTechnologyTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TcontrollerTechnologyTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TcontrollerTechnologyType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TcontrollerTechnologyType>>> GetTcontrollerTechnologyType()
        {
            return await _context.TcontrollerTechnologyType.ToListAsync();
        }

        // GET: api/TcontrollerTechnologyType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TcontrollerTechnologyType>> GetTcontrollerTechnologyType(byte id)
        {
            var tcontrollerTechnologyType = await _context.TcontrollerTechnologyType.FindAsync(id);

            if (tcontrollerTechnologyType == null)
            {
                return NotFound();
            }

            return tcontrollerTechnologyType;
        }

        // PUT: api/TcontrollerTechnologyType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTcontrollerTechnologyType(byte id, TcontrollerTechnologyType tcontrollerTechnologyType)
        {
            if (id != tcontrollerTechnologyType.TcontrollerTechnologyTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tcontrollerTechnologyType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TcontrollerTechnologyTypeExists(id))
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

        // POST: api/TcontrollerTechnologyType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TcontrollerTechnologyType>> PostTcontrollerTechnologyType(TcontrollerTechnologyType tcontrollerTechnologyType)
        {
            _context.TcontrollerTechnologyType.Add(tcontrollerTechnologyType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TcontrollerTechnologyTypeExists(tcontrollerTechnologyType.TcontrollerTechnologyTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTcontrollerTechnologyType", new { id = tcontrollerTechnologyType.TcontrollerTechnologyTypeId }, tcontrollerTechnologyType);
        }

        // DELETE: api/TcontrollerTechnologyType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TcontrollerTechnologyType>> DeleteTcontrollerTechnologyType(byte id)
        {
            var tcontrollerTechnologyType = await _context.TcontrollerTechnologyType.FindAsync(id);
            if (tcontrollerTechnologyType == null)
            {
                return NotFound();
            }

            _context.TcontrollerTechnologyType.Remove(tcontrollerTechnologyType);
            await _context.SaveChangesAsync();

            return tcontrollerTechnologyType;
        }

        private bool TcontrollerTechnologyTypeExists(byte id)
        {
            return _context.TcontrollerTechnologyType.Any(e => e.TcontrollerTechnologyTypeId == id);
        }
    }
}
