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
    public class TplatformEdgeController : ControllerBase
    {
        private readonly DBContext _context;

        public TplatformEdgeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TplatformEdge
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TplatformEdge>>> GetTplatformEdge()
        {
            return await _context.TplatformEdge.ToListAsync();
        }

        // GET: api/TplatformEdge/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TplatformEdge>> GetTplatformEdge(short id)
        {
            var tplatformEdge = await _context.TplatformEdge.FindAsync(id);

            if (tplatformEdge == null)
            {
                return NotFound();
            }

            return tplatformEdge;
        }

        // PUT: api/TplatformEdge/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTplatformEdge(short id, TplatformEdge tplatformEdge)
        {
            if (id != tplatformEdge.TplatformEdgeId)
            {
                return BadRequest();
            }

            _context.Entry(tplatformEdge).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TplatformEdgeExists(id))
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

        // POST: api/TplatformEdge
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TplatformEdge>> PostTplatformEdge(TplatformEdge tplatformEdge)
        {
            _context.TplatformEdge.Add(tplatformEdge);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TplatformEdgeExists(tplatformEdge.TplatformEdgeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTplatformEdge", new { id = tplatformEdge.TplatformEdgeId }, tplatformEdge);
        }

        // DELETE: api/TplatformEdge/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TplatformEdge>> DeleteTplatformEdge(short id)
        {
            var tplatformEdge = await _context.TplatformEdge.FindAsync(id);
            if (tplatformEdge == null)
            {
                return NotFound();
            }

            _context.TplatformEdge.Remove(tplatformEdge);
            await _context.SaveChangesAsync();

            return tplatformEdge;
        }

        private bool TplatformEdgeExists(short id)
        {
            return _context.TplatformEdge.Any(e => e.TplatformEdgeId == id);
        }
    }
}
