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
    public class EexternalReferenceLineNumberController : ControllerBase
    {
        private readonly DBContext _context;

        public EexternalReferenceLineNumberController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EexternalReferenceLineNumber
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EexternalReferenceLineNumber>>> GetEexternalReferenceLineNumber()
        {
            return await _context.EexternalReferenceLineNumber.ToListAsync();
        }

        // GET: api/EexternalReferenceLineNumber/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EexternalReferenceLineNumber>> GetEexternalReferenceLineNumber(long id)
        {
            var eexternalReferenceLineNumber = await _context.EexternalReferenceLineNumber.FindAsync(id);

            if (eexternalReferenceLineNumber == null)
            {
                return NotFound();
            }

            return eexternalReferenceLineNumber;
        }

        // PUT: api/EexternalReferenceLineNumber/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEexternalReferenceLineNumber(long id, EexternalReferenceLineNumber eexternalReferenceLineNumber)
        {
            if (id != eexternalReferenceLineNumber.EexternalReferenceLineNumberId)
            {
                return BadRequest();
            }

            _context.Entry(eexternalReferenceLineNumber).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EexternalReferenceLineNumberExists(id))
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

        // POST: api/EexternalReferenceLineNumber
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EexternalReferenceLineNumber>> PostEexternalReferenceLineNumber(EexternalReferenceLineNumber eexternalReferenceLineNumber)
        {
            _context.EexternalReferenceLineNumber.Add(eexternalReferenceLineNumber);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EexternalReferenceLineNumberExists(eexternalReferenceLineNumber.EexternalReferenceLineNumberId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEexternalReferenceLineNumber", new { id = eexternalReferenceLineNumber.EexternalReferenceLineNumberId }, eexternalReferenceLineNumber);
        }

        // DELETE: api/EexternalReferenceLineNumber/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EexternalReferenceLineNumber>> DeleteEexternalReferenceLineNumber(long id)
        {
            var eexternalReferenceLineNumber = await _context.EexternalReferenceLineNumber.FindAsync(id);
            if (eexternalReferenceLineNumber == null)
            {
                return NotFound();
            }

            _context.EexternalReferenceLineNumber.Remove(eexternalReferenceLineNumber);
            await _context.SaveChangesAsync();

            return eexternalReferenceLineNumber;
        }

        private bool EexternalReferenceLineNumberExists(long id)
        {
            return _context.EexternalReferenceLineNumber.Any(e => e.EexternalReferenceLineNumberId == id);
        }
    }
}
