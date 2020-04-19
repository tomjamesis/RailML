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
    public class EaxleWeightChangesController : ControllerBase
    {
        private readonly DBContext _context;

        public EaxleWeightChangesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EaxleWeightChanges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EaxleWeightChanges>>> GetEaxleWeightChanges()
        {
            return await _context.EaxleWeightChanges.ToListAsync();
        }

        // GET: api/EaxleWeightChanges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EaxleWeightChanges>> GetEaxleWeightChanges(long id)
        {
            var eaxleWeightChanges = await _context.EaxleWeightChanges.FindAsync(id);

            if (eaxleWeightChanges == null)
            {
                return NotFound();
            }

            return eaxleWeightChanges;
        }

        // PUT: api/EaxleWeightChanges/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEaxleWeightChanges(long id, EaxleWeightChanges eaxleWeightChanges)
        {
            if (id != eaxleWeightChanges.EaxleWeightChangesId)
            {
                return BadRequest();
            }

            _context.Entry(eaxleWeightChanges).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EaxleWeightChangesExists(id))
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

        // POST: api/EaxleWeightChanges
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EaxleWeightChanges>> PostEaxleWeightChanges(EaxleWeightChanges eaxleWeightChanges)
        {
            _context.EaxleWeightChanges.Add(eaxleWeightChanges);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EaxleWeightChangesExists(eaxleWeightChanges.EaxleWeightChangesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEaxleWeightChanges", new { id = eaxleWeightChanges.EaxleWeightChangesId }, eaxleWeightChanges);
        }

        // DELETE: api/EaxleWeightChanges/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EaxleWeightChanges>> DeleteEaxleWeightChanges(long id)
        {
            var eaxleWeightChanges = await _context.EaxleWeightChanges.FindAsync(id);
            if (eaxleWeightChanges == null)
            {
                return NotFound();
            }

            _context.EaxleWeightChanges.Remove(eaxleWeightChanges);
            await _context.SaveChangesAsync();

            return eaxleWeightChanges;
        }

        private bool EaxleWeightChangesExists(long id)
        {
            return _context.EaxleWeightChanges.Any(e => e.EaxleWeightChangesId == id);
        }
    }
}
