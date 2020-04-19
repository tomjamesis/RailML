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
    public class TspecialServiceTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TspecialServiceTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TspecialServiceType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TspecialServiceType>>> GetTspecialServiceType()
        {
            return await _context.TspecialServiceType.ToListAsync();
        }

        // GET: api/TspecialServiceType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TspecialServiceType>> GetTspecialServiceType(byte id)
        {
            var tspecialServiceType = await _context.TspecialServiceType.FindAsync(id);

            if (tspecialServiceType == null)
            {
                return NotFound();
            }

            return tspecialServiceType;
        }

        // PUT: api/TspecialServiceType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTspecialServiceType(byte id, TspecialServiceType tspecialServiceType)
        {
            if (id != tspecialServiceType.TspecialServiceTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tspecialServiceType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TspecialServiceTypeExists(id))
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

        // POST: api/TspecialServiceType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TspecialServiceType>> PostTspecialServiceType(TspecialServiceType tspecialServiceType)
        {
            _context.TspecialServiceType.Add(tspecialServiceType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TspecialServiceTypeExists(tspecialServiceType.TspecialServiceTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTspecialServiceType", new { id = tspecialServiceType.TspecialServiceTypeId }, tspecialServiceType);
        }

        // DELETE: api/TspecialServiceType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TspecialServiceType>> DeleteTspecialServiceType(byte id)
        {
            var tspecialServiceType = await _context.TspecialServiceType.FindAsync(id);
            if (tspecialServiceType == null)
            {
                return NotFound();
            }

            _context.TspecialServiceType.Remove(tspecialServiceType);
            await _context.SaveChangesAsync();

            return tspecialServiceType;
        }

        private bool TspecialServiceTypeExists(byte id)
        {
            return _context.TspecialServiceType.Any(e => e.TspecialServiceTypeId == id);
        }
    }
}
