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
    public class TinsulatedRailSideController : ControllerBase
    {
        private readonly DBContext _context;

        public TinsulatedRailSideController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TinsulatedRailSide
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TinsulatedRailSide>>> GetTinsulatedRailSide()
        {
            return await _context.TinsulatedRailSide.ToListAsync();
        }

        // GET: api/TinsulatedRailSide/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TinsulatedRailSide>> GetTinsulatedRailSide(byte id)
        {
            var tinsulatedRailSide = await _context.TinsulatedRailSide.FindAsync(id);

            if (tinsulatedRailSide == null)
            {
                return NotFound();
            }

            return tinsulatedRailSide;
        }

        // PUT: api/TinsulatedRailSide/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTinsulatedRailSide(byte id, TinsulatedRailSide tinsulatedRailSide)
        {
            if (id != tinsulatedRailSide.TinsulatedRailSideId)
            {
                return BadRequest();
            }

            _context.Entry(tinsulatedRailSide).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TinsulatedRailSideExists(id))
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

        // POST: api/TinsulatedRailSide
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TinsulatedRailSide>> PostTinsulatedRailSide(TinsulatedRailSide tinsulatedRailSide)
        {
            _context.TinsulatedRailSide.Add(tinsulatedRailSide);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TinsulatedRailSideExists(tinsulatedRailSide.TinsulatedRailSideId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTinsulatedRailSide", new { id = tinsulatedRailSide.TinsulatedRailSideId }, tinsulatedRailSide);
        }

        // DELETE: api/TinsulatedRailSide/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TinsulatedRailSide>> DeleteTinsulatedRailSide(byte id)
        {
            var tinsulatedRailSide = await _context.TinsulatedRailSide.FindAsync(id);
            if (tinsulatedRailSide == null)
            {
                return NotFound();
            }

            _context.TinsulatedRailSide.Remove(tinsulatedRailSide);
            await _context.SaveChangesAsync();

            return tinsulatedRailSide;
        }

        private bool TinsulatedRailSideExists(byte id)
        {
            return _context.TinsulatedRailSide.Any(e => e.TinsulatedRailSideId == id);
        }
    }
}
