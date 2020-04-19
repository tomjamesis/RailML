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
    public class TtrainProtectionMediumController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainProtectionMediumController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrainProtectionMedium
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrainProtectionMedium>>> GetTtrainProtectionMedium()
        {
            return await _context.TtrainProtectionMedium.ToListAsync();
        }

        // GET: api/TtrainProtectionMedium/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrainProtectionMedium>> GetTtrainProtectionMedium(byte id)
        {
            var ttrainProtectionMedium = await _context.TtrainProtectionMedium.FindAsync(id);

            if (ttrainProtectionMedium == null)
            {
                return NotFound();
            }

            return ttrainProtectionMedium;
        }

        // PUT: api/TtrainProtectionMedium/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrainProtectionMedium(byte id, TtrainProtectionMedium ttrainProtectionMedium)
        {
            if (id != ttrainProtectionMedium.TtrainProtectionMediumId)
            {
                return BadRequest();
            }

            _context.Entry(ttrainProtectionMedium).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainProtectionMediumExists(id))
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

        // POST: api/TtrainProtectionMedium
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrainProtectionMedium>> PostTtrainProtectionMedium(TtrainProtectionMedium ttrainProtectionMedium)
        {
            _context.TtrainProtectionMedium.Add(ttrainProtectionMedium);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainProtectionMediumExists(ttrainProtectionMedium.TtrainProtectionMediumId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrainProtectionMedium", new { id = ttrainProtectionMedium.TtrainProtectionMediumId }, ttrainProtectionMedium);
        }

        // DELETE: api/TtrainProtectionMedium/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrainProtectionMedium>> DeleteTtrainProtectionMedium(byte id)
        {
            var ttrainProtectionMedium = await _context.TtrainProtectionMedium.FindAsync(id);
            if (ttrainProtectionMedium == null)
            {
                return NotFound();
            }

            _context.TtrainProtectionMedium.Remove(ttrainProtectionMedium);
            await _context.SaveChangesAsync();

            return ttrainProtectionMedium;
        }

        private bool TtrainProtectionMediumExists(byte id)
        {
            return _context.TtrainProtectionMedium.Any(e => e.TtrainProtectionMediumId == id);
        }
    }
}
