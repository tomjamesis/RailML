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
    public class TplatformEdgeRefController : ControllerBase
    {
        private readonly DBContext _context;

        public TplatformEdgeRefController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TplatformEdgeRef
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TplatformEdgeRef>>> GetTplatformEdgeRef()
        {
            return await _context.TplatformEdgeRef.ToListAsync();
        }

        // GET: api/TplatformEdgeRef/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TplatformEdgeRef>> GetTplatformEdgeRef(short id)
        {
            var tplatformEdgeRef = await _context.TplatformEdgeRef.FindAsync(id);

            if (tplatformEdgeRef == null)
            {
                return NotFound();
            }

            return tplatformEdgeRef;
        }

        // PUT: api/TplatformEdgeRef/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTplatformEdgeRef(short id, TplatformEdgeRef tplatformEdgeRef)
        {
            if (id != tplatformEdgeRef.TplatformEdgeRefId)
            {
                return BadRequest();
            }

            _context.Entry(tplatformEdgeRef).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TplatformEdgeRefExists(id))
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

        // POST: api/TplatformEdgeRef
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TplatformEdgeRef>> PostTplatformEdgeRef(TplatformEdgeRef tplatformEdgeRef)
        {
            _context.TplatformEdgeRef.Add(tplatformEdgeRef);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TplatformEdgeRefExists(tplatformEdgeRef.TplatformEdgeRefId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTplatformEdgeRef", new { id = tplatformEdgeRef.TplatformEdgeRefId }, tplatformEdgeRef);
        }

        // DELETE: api/TplatformEdgeRef/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TplatformEdgeRef>> DeleteTplatformEdgeRef(short id)
        {
            var tplatformEdgeRef = await _context.TplatformEdgeRef.FindAsync(id);
            if (tplatformEdgeRef == null)
            {
                return NotFound();
            }

            _context.TplatformEdgeRef.Remove(tplatformEdgeRef);
            await _context.SaveChangesAsync();

            return tplatformEdgeRef;
        }

        private bool TplatformEdgeRefExists(short id)
        {
            return _context.TplatformEdgeRef.Any(e => e.TplatformEdgeRefId == id);
        }
    }
}
