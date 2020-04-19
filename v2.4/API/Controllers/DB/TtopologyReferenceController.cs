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
    public class TtopologyReferenceController : ControllerBase
    {
        private readonly DBContext _context;

        public TtopologyReferenceController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtopologyReference
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtopologyReference>>> GetTtopologyReference()
        {
            return await _context.TtopologyReference.ToListAsync();
        }

        // GET: api/TtopologyReference/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtopologyReference>> GetTtopologyReference(long id)
        {
            var ttopologyReference = await _context.TtopologyReference.FindAsync(id);

            if (ttopologyReference == null)
            {
                return NotFound();
            }

            return ttopologyReference;
        }

        // PUT: api/TtopologyReference/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtopologyReference(long id, TtopologyReference ttopologyReference)
        {
            if (id != ttopologyReference.TtopologyReferenceId)
            {
                return BadRequest();
            }

            _context.Entry(ttopologyReference).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtopologyReferenceExists(id))
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

        // POST: api/TtopologyReference
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtopologyReference>> PostTtopologyReference(TtopologyReference ttopologyReference)
        {
            _context.TtopologyReference.Add(ttopologyReference);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtopologyReferenceExists(ttopologyReference.TtopologyReferenceId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtopologyReference", new { id = ttopologyReference.TtopologyReferenceId }, ttopologyReference);
        }

        // DELETE: api/TtopologyReference/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtopologyReference>> DeleteTtopologyReference(long id)
        {
            var ttopologyReference = await _context.TtopologyReference.FindAsync(id);
            if (ttopologyReference == null)
            {
                return NotFound();
            }

            _context.TtopologyReference.Remove(ttopologyReference);
            await _context.SaveChangesAsync();

            return ttopologyReference;
        }

        private bool TtopologyReferenceExists(long id)
        {
            return _context.TtopologyReference.Any(e => e.TtopologyReferenceId == id);
        }
    }
}
