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
    public class TtrackRefController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrackRefController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrackRef
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrackRef>>> GetTtrackRef()
        {
            return await _context.TtrackRef.ToListAsync();
        }

        // GET: api/TtrackRef/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrackRef>> GetTtrackRef(short id)
        {
            var ttrackRef = await _context.TtrackRef.FindAsync(id);

            if (ttrackRef == null)
            {
                return NotFound();
            }

            return ttrackRef;
        }

        // PUT: api/TtrackRef/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrackRef(short id, TtrackRef ttrackRef)
        {
            if (id != ttrackRef.TtrackRefId)
            {
                return BadRequest();
            }

            _context.Entry(ttrackRef).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrackRefExists(id))
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

        // POST: api/TtrackRef
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrackRef>> PostTtrackRef(TtrackRef ttrackRef)
        {
            _context.TtrackRef.Add(ttrackRef);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrackRefExists(ttrackRef.TtrackRefId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrackRef", new { id = ttrackRef.TtrackRefId }, ttrackRef);
        }

        // DELETE: api/TtrackRef/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrackRef>> DeleteTtrackRef(short id)
        {
            var ttrackRef = await _context.TtrackRef.FindAsync(id);
            if (ttrackRef == null)
            {
                return NotFound();
            }

            _context.TtrackRef.Remove(ttrackRef);
            await _context.SaveChangesAsync();

            return ttrackRef;
        }

        private bool TtrackRefExists(short id)
        {
            return _context.TtrackRef.Any(e => e.TtrackRefId == id);
        }
    }
}
