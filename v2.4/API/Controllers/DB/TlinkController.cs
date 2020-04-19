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
    public class TlinkController : ControllerBase
    {
        private readonly DBContext _context;

        public TlinkController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tlink
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tlink>>> GetTlink()
        {
            return await _context.Tlink.ToListAsync();
        }

        // GET: api/Tlink/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tlink>> GetTlink(long id)
        {
            var tlink = await _context.Tlink.FindAsync(id);

            if (tlink == null)
            {
                return NotFound();
            }

            return tlink;
        }

        // PUT: api/Tlink/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTlink(long id, Tlink tlink)
        {
            if (id != tlink.TlinkId)
            {
                return BadRequest();
            }

            _context.Entry(tlink).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TlinkExists(id))
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

        // POST: api/Tlink
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tlink>> PostTlink(Tlink tlink)
        {
            _context.Tlink.Add(tlink);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TlinkExists(tlink.TlinkId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTlink", new { id = tlink.TlinkId }, tlink);
        }

        // DELETE: api/Tlink/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tlink>> DeleteTlink(long id)
        {
            var tlink = await _context.Tlink.FindAsync(id);
            if (tlink == null)
            {
                return NotFound();
            }

            _context.Tlink.Remove(tlink);
            await _context.SaveChangesAsync();

            return tlink;
        }

        private bool TlinkExists(long id)
        {
            return _context.Tlink.Any(e => e.TlinkId == id);
        }
    }
}
