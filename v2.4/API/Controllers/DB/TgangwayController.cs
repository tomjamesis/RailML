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
    public class TgangwayController : ControllerBase
    {
        private readonly DBContext _context;

        public TgangwayController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tgangway
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tgangway>>> GetTgangway()
        {
            return await _context.Tgangway.ToListAsync();
        }

        // GET: api/Tgangway/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tgangway>> GetTgangway(long id)
        {
            var tgangway = await _context.Tgangway.FindAsync(id);

            if (tgangway == null)
            {
                return NotFound();
            }

            return tgangway;
        }

        // PUT: api/Tgangway/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTgangway(long id, Tgangway tgangway)
        {
            if (id != tgangway.TgangwayId)
            {
                return BadRequest();
            }

            _context.Entry(tgangway).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TgangwayExists(id))
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

        // POST: api/Tgangway
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tgangway>> PostTgangway(Tgangway tgangway)
        {
            _context.Tgangway.Add(tgangway);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TgangwayExists(tgangway.TgangwayId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTgangway", new { id = tgangway.TgangwayId }, tgangway);
        }

        // DELETE: api/Tgangway/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tgangway>> DeleteTgangway(long id)
        {
            var tgangway = await _context.Tgangway.FindAsync(id);
            if (tgangway == null)
            {
                return NotFound();
            }

            _context.Tgangway.Remove(tgangway);
            await _context.SaveChangesAsync();

            return tgangway;
        }

        private bool TgangwayExists(long id)
        {
            return _context.Tgangway.Any(e => e.TgangwayId == id);
        }
    }
}
