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
    public class EexternalReferenceTrainNumberController : ControllerBase
    {
        private readonly DBContext _context;

        public EexternalReferenceTrainNumberController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EexternalReferenceTrainNumber
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EexternalReferenceTrainNumber>>> GetEexternalReferenceTrainNumber()
        {
            return await _context.EexternalReferenceTrainNumber.ToListAsync();
        }

        // GET: api/EexternalReferenceTrainNumber/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EexternalReferenceTrainNumber>> GetEexternalReferenceTrainNumber(long id)
        {
            var eexternalReferenceTrainNumber = await _context.EexternalReferenceTrainNumber.FindAsync(id);

            if (eexternalReferenceTrainNumber == null)
            {
                return NotFound();
            }

            return eexternalReferenceTrainNumber;
        }

        // PUT: api/EexternalReferenceTrainNumber/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEexternalReferenceTrainNumber(long id, EexternalReferenceTrainNumber eexternalReferenceTrainNumber)
        {
            if (id != eexternalReferenceTrainNumber.EexternalReferenceTrainNumberId)
            {
                return BadRequest();
            }

            _context.Entry(eexternalReferenceTrainNumber).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EexternalReferenceTrainNumberExists(id))
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

        // POST: api/EexternalReferenceTrainNumber
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EexternalReferenceTrainNumber>> PostEexternalReferenceTrainNumber(EexternalReferenceTrainNumber eexternalReferenceTrainNumber)
        {
            _context.EexternalReferenceTrainNumber.Add(eexternalReferenceTrainNumber);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EexternalReferenceTrainNumberExists(eexternalReferenceTrainNumber.EexternalReferenceTrainNumberId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEexternalReferenceTrainNumber", new { id = eexternalReferenceTrainNumber.EexternalReferenceTrainNumberId }, eexternalReferenceTrainNumber);
        }

        // DELETE: api/EexternalReferenceTrainNumber/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EexternalReferenceTrainNumber>> DeleteEexternalReferenceTrainNumber(long id)
        {
            var eexternalReferenceTrainNumber = await _context.EexternalReferenceTrainNumber.FindAsync(id);
            if (eexternalReferenceTrainNumber == null)
            {
                return NotFound();
            }

            _context.EexternalReferenceTrainNumber.Remove(eexternalReferenceTrainNumber);
            await _context.SaveChangesAsync();

            return eexternalReferenceTrainNumber;
        }

        private bool EexternalReferenceTrainNumberExists(long id)
        {
            return _context.EexternalReferenceTrainNumber.Any(e => e.EexternalReferenceTrainNumberId == id);
        }
    }
}
