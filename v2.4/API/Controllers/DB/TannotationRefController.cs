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
    public class TannotationRefController : ControllerBase
    {
        private readonly DBContext _context;

        public TannotationRefController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TannotationRef
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TannotationRef>>> GetTannotationRef()
        {
            return await _context.TannotationRef.ToListAsync();
        }

        // GET: api/TannotationRef/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TannotationRef>> GetTannotationRef(short id)
        {
            var tannotationRef = await _context.TannotationRef.FindAsync(id);

            if (tannotationRef == null)
            {
                return NotFound();
            }

            return tannotationRef;
        }

        // PUT: api/TannotationRef/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTannotationRef(short id, TannotationRef tannotationRef)
        {
            if (id != tannotationRef.TannotationRefId)
            {
                return BadRequest();
            }

            _context.Entry(tannotationRef).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TannotationRefExists(id))
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

        // POST: api/TannotationRef
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TannotationRef>> PostTannotationRef(TannotationRef tannotationRef)
        {
            _context.TannotationRef.Add(tannotationRef);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TannotationRefExists(tannotationRef.TannotationRefId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTannotationRef", new { id = tannotationRef.TannotationRefId }, tannotationRef);
        }

        // DELETE: api/TannotationRef/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TannotationRef>> DeleteTannotationRef(short id)
        {
            var tannotationRef = await _context.TannotationRef.FindAsync(id);
            if (tannotationRef == null)
            {
                return NotFound();
            }

            _context.TannotationRef.Remove(tannotationRef);
            await _context.SaveChangesAsync();

            return tannotationRef;
        }

        private bool TannotationRefExists(short id)
        {
            return _context.TannotationRef.Any(e => e.TannotationRefId == id);
        }
    }
}
