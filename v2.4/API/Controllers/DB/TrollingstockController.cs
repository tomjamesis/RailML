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
    public class TrollingstockController : ControllerBase
    {
        private readonly DBContext _context;

        public TrollingstockController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Trollingstock
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trollingstock>>> GetTrollingstock()
        {
            return await _context.Trollingstock.ToListAsync();
        }

        // GET: api/Trollingstock/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Trollingstock>> GetTrollingstock(short id)
        {
            var trollingstock = await _context.Trollingstock.FindAsync(id);

            if (trollingstock == null)
            {
                return NotFound();
            }

            return trollingstock;
        }

        // PUT: api/Trollingstock/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrollingstock(short id, Trollingstock trollingstock)
        {
            if (id != trollingstock.TrollingstockId)
            {
                return BadRequest();
            }

            _context.Entry(trollingstock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrollingstockExists(id))
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

        // POST: api/Trollingstock
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Trollingstock>> PostTrollingstock(Trollingstock trollingstock)
        {
            _context.Trollingstock.Add(trollingstock);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TrollingstockExists(trollingstock.TrollingstockId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTrollingstock", new { id = trollingstock.TrollingstockId }, trollingstock);
        }

        // DELETE: api/Trollingstock/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Trollingstock>> DeleteTrollingstock(short id)
        {
            var trollingstock = await _context.Trollingstock.FindAsync(id);
            if (trollingstock == null)
            {
                return NotFound();
            }

            _context.Trollingstock.Remove(trollingstock);
            await _context.SaveChangesAsync();

            return trollingstock;
        }

        private bool TrollingstockExists(short id)
        {
            return _context.Trollingstock.Any(e => e.TrollingstockId == id);
        }
    }
}
