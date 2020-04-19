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
    public class TpathController : ControllerBase
    {
        private readonly DBContext _context;

        public TpathController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tpath
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tpath>>> GetTpath()
        {
            return await _context.Tpath.ToListAsync();
        }

        // GET: api/Tpath/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tpath>> GetTpath(long id)
        {
            var tpath = await _context.Tpath.FindAsync(id);

            if (tpath == null)
            {
                return NotFound();
            }

            return tpath;
        }

        // PUT: api/Tpath/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTpath(long id, Tpath tpath)
        {
            if (id != tpath.TpathId)
            {
                return BadRequest();
            }

            _context.Entry(tpath).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TpathExists(id))
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

        // POST: api/Tpath
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tpath>> PostTpath(Tpath tpath)
        {
            _context.Tpath.Add(tpath);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TpathExists(tpath.TpathId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTpath", new { id = tpath.TpathId }, tpath);
        }

        // DELETE: api/Tpath/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tpath>> DeleteTpath(long id)
        {
            var tpath = await _context.Tpath.FindAsync(id);
            if (tpath == null)
            {
                return NotFound();
            }

            _context.Tpath.Remove(tpath);
            await _context.SaveChangesAsync();

            return tpath;
        }

        private bool TpathExists(long id)
        {
            return _context.Tpath.Any(e => e.TpathId == id);
        }
    }
}
