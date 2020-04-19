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
    public class TgeoCoordController : ControllerBase
    {
        private readonly DBContext _context;

        public TgeoCoordController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TgeoCoord
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TgeoCoord>>> GetTgeoCoord()
        {
            return await _context.TgeoCoord.ToListAsync();
        }

        // GET: api/TgeoCoord/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TgeoCoord>> GetTgeoCoord(long id)
        {
            var tgeoCoord = await _context.TgeoCoord.FindAsync(id);

            if (tgeoCoord == null)
            {
                return NotFound();
            }

            return tgeoCoord;
        }

        // PUT: api/TgeoCoord/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTgeoCoord(long id, TgeoCoord tgeoCoord)
        {
            if (id != tgeoCoord.TgeoCoordId)
            {
                return BadRequest();
            }

            _context.Entry(tgeoCoord).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TgeoCoordExists(id))
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

        // POST: api/TgeoCoord
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TgeoCoord>> PostTgeoCoord(TgeoCoord tgeoCoord)
        {
            _context.TgeoCoord.Add(tgeoCoord);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TgeoCoordExists(tgeoCoord.TgeoCoordId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTgeoCoord", new { id = tgeoCoord.TgeoCoordId }, tgeoCoord);
        }

        // DELETE: api/TgeoCoord/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TgeoCoord>> DeleteTgeoCoord(long id)
        {
            var tgeoCoord = await _context.TgeoCoord.FindAsync(id);
            if (tgeoCoord == null)
            {
                return NotFound();
            }

            _context.TgeoCoord.Remove(tgeoCoord);
            await _context.SaveChangesAsync();

            return tgeoCoord;
        }

        private bool TgeoCoordExists(long id)
        {
            return _context.TgeoCoord.Any(e => e.TgeoCoordId == id);
        }
    }
}
