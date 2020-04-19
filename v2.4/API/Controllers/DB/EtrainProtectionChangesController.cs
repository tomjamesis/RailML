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
    public class EtrainProtectionChangesController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrainProtectionChangesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrainProtectionChanges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrainProtectionChanges>>> GetEtrainProtectionChanges()
        {
            return await _context.EtrainProtectionChanges.ToListAsync();
        }

        // GET: api/EtrainProtectionChanges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrainProtectionChanges>> GetEtrainProtectionChanges(long id)
        {
            var etrainProtectionChanges = await _context.EtrainProtectionChanges.FindAsync(id);

            if (etrainProtectionChanges == null)
            {
                return NotFound();
            }

            return etrainProtectionChanges;
        }

        // PUT: api/EtrainProtectionChanges/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrainProtectionChanges(long id, EtrainProtectionChanges etrainProtectionChanges)
        {
            if (id != etrainProtectionChanges.EtrainProtectionChangesId)
            {
                return BadRequest();
            }

            _context.Entry(etrainProtectionChanges).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrainProtectionChangesExists(id))
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

        // POST: api/EtrainProtectionChanges
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrainProtectionChanges>> PostEtrainProtectionChanges(EtrainProtectionChanges etrainProtectionChanges)
        {
            _context.EtrainProtectionChanges.Add(etrainProtectionChanges);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrainProtectionChangesExists(etrainProtectionChanges.EtrainProtectionChangesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrainProtectionChanges", new { id = etrainProtectionChanges.EtrainProtectionChangesId }, etrainProtectionChanges);
        }

        // DELETE: api/EtrainProtectionChanges/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrainProtectionChanges>> DeleteEtrainProtectionChanges(long id)
        {
            var etrainProtectionChanges = await _context.EtrainProtectionChanges.FindAsync(id);
            if (etrainProtectionChanges == null)
            {
                return NotFound();
            }

            _context.EtrainProtectionChanges.Remove(etrainProtectionChanges);
            await _context.SaveChangesAsync();

            return etrainProtectionChanges;
        }

        private bool EtrainProtectionChangesExists(long id)
        {
            return _context.EtrainProtectionChanges.Any(e => e.EtrainProtectionChangesId == id);
        }
    }
}
