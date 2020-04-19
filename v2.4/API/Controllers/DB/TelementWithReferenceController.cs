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
    public class TelementWithReferenceController : ControllerBase
    {
        private readonly DBContext _context;

        public TelementWithReferenceController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TelementWithReference
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TelementWithReference>>> GetTelementWithReference()
        {
            return await _context.TelementWithReference.ToListAsync();
        }

        // GET: api/TelementWithReference/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TelementWithReference>> GetTelementWithReference(long id)
        {
            var telementWithReference = await _context.TelementWithReference.FindAsync(id);

            if (telementWithReference == null)
            {
                return NotFound();
            }

            return telementWithReference;
        }

        // PUT: api/TelementWithReference/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTelementWithReference(long id, TelementWithReference telementWithReference)
        {
            if (id != telementWithReference.TelementWithReferenceId)
            {
                return BadRequest();
            }

            _context.Entry(telementWithReference).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TelementWithReferenceExists(id))
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

        // POST: api/TelementWithReference
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TelementWithReference>> PostTelementWithReference(TelementWithReference telementWithReference)
        {
            _context.TelementWithReference.Add(telementWithReference);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TelementWithReferenceExists(telementWithReference.TelementWithReferenceId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTelementWithReference", new { id = telementWithReference.TelementWithReferenceId }, telementWithReference);
        }

        // DELETE: api/TelementWithReference/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TelementWithReference>> DeleteTelementWithReference(long id)
        {
            var telementWithReference = await _context.TelementWithReference.FindAsync(id);
            if (telementWithReference == null)
            {
                return NotFound();
            }

            _context.TelementWithReference.Remove(telementWithReference);
            await _context.SaveChangesAsync();

            return telementWithReference;
        }

        private bool TelementWithReferenceExists(long id)
        {
            return _context.TelementWithReference.Any(e => e.TelementWithReferenceId == id);
        }
    }
}
