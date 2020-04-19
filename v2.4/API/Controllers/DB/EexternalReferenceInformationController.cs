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
    public class EexternalReferenceInformationController : ControllerBase
    {
        private readonly DBContext _context;

        public EexternalReferenceInformationController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EexternalReferenceInformation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EexternalReferenceInformation>>> GetEexternalReferenceInformation()
        {
            return await _context.EexternalReferenceInformation.ToListAsync();
        }

        // GET: api/EexternalReferenceInformation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EexternalReferenceInformation>> GetEexternalReferenceInformation(long id)
        {
            var eexternalReferenceInformation = await _context.EexternalReferenceInformation.FindAsync(id);

            if (eexternalReferenceInformation == null)
            {
                return NotFound();
            }

            return eexternalReferenceInformation;
        }

        // PUT: api/EexternalReferenceInformation/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEexternalReferenceInformation(long id, EexternalReferenceInformation eexternalReferenceInformation)
        {
            if (id != eexternalReferenceInformation.EexternalReferenceInformationId)
            {
                return BadRequest();
            }

            _context.Entry(eexternalReferenceInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EexternalReferenceInformationExists(id))
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

        // POST: api/EexternalReferenceInformation
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EexternalReferenceInformation>> PostEexternalReferenceInformation(EexternalReferenceInformation eexternalReferenceInformation)
        {
            _context.EexternalReferenceInformation.Add(eexternalReferenceInformation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EexternalReferenceInformationExists(eexternalReferenceInformation.EexternalReferenceInformationId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEexternalReferenceInformation", new { id = eexternalReferenceInformation.EexternalReferenceInformationId }, eexternalReferenceInformation);
        }

        // DELETE: api/EexternalReferenceInformation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EexternalReferenceInformation>> DeleteEexternalReferenceInformation(long id)
        {
            var eexternalReferenceInformation = await _context.EexternalReferenceInformation.FindAsync(id);
            if (eexternalReferenceInformation == null)
            {
                return NotFound();
            }

            _context.EexternalReferenceInformation.Remove(eexternalReferenceInformation);
            await _context.SaveChangesAsync();

            return eexternalReferenceInformation;
        }

        private bool EexternalReferenceInformationExists(long id)
        {
            return _context.EexternalReferenceInformation.Any(e => e.EexternalReferenceInformationId == id);
        }
    }
}
