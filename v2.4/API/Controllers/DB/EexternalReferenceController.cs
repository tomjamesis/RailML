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
    public class EexternalReferenceController : ControllerBase
    {
        private readonly DBContext _context;

        public EexternalReferenceController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EexternalReference
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EexternalReference>>> GetEexternalReference()
        {
            return await _context.EexternalReference.ToListAsync();
        }

        // GET: api/EexternalReference/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EexternalReference>> GetEexternalReference(long id)
        {
            var eexternalReference = await _context.EexternalReference.FindAsync(id);

            if (eexternalReference == null)
            {
                return NotFound();
            }

            return eexternalReference;
        }

        // PUT: api/EexternalReference/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEexternalReference(long id, EexternalReference eexternalReference)
        {
            if (id != eexternalReference.EexternalReferenceId)
            {
                return BadRequest();
            }

            _context.Entry(eexternalReference).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EexternalReferenceExists(id))
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

        // POST: api/EexternalReference
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EexternalReference>> PostEexternalReference(EexternalReference eexternalReference)
        {
            _context.EexternalReference.Add(eexternalReference);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EexternalReferenceExists(eexternalReference.EexternalReferenceId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEexternalReference", new { id = eexternalReference.EexternalReferenceId }, eexternalReference);
        }

        // DELETE: api/EexternalReference/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EexternalReference>> DeleteEexternalReference(long id)
        {
            var eexternalReference = await _context.EexternalReference.FindAsync(id);
            if (eexternalReference == null)
            {
                return NotFound();
            }

            _context.EexternalReference.Remove(eexternalReference);
            await _context.SaveChangesAsync();

            return eexternalReference;
        }

        private bool EexternalReferenceExists(long id)
        {
            return _context.EexternalReference.Any(e => e.EexternalReferenceId == id);
        }
    }
}
