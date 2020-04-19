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
    public class EoperationModeChangesController : ControllerBase
    {
        private readonly DBContext _context;

        public EoperationModeChangesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EoperationModeChanges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EoperationModeChanges>>> GetEoperationModeChanges()
        {
            return await _context.EoperationModeChanges.ToListAsync();
        }

        // GET: api/EoperationModeChanges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EoperationModeChanges>> GetEoperationModeChanges(long id)
        {
            var eoperationModeChanges = await _context.EoperationModeChanges.FindAsync(id);

            if (eoperationModeChanges == null)
            {
                return NotFound();
            }

            return eoperationModeChanges;
        }

        // PUT: api/EoperationModeChanges/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEoperationModeChanges(long id, EoperationModeChanges eoperationModeChanges)
        {
            if (id != eoperationModeChanges.EoperationModeChangesId)
            {
                return BadRequest();
            }

            _context.Entry(eoperationModeChanges).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EoperationModeChangesExists(id))
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

        // POST: api/EoperationModeChanges
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EoperationModeChanges>> PostEoperationModeChanges(EoperationModeChanges eoperationModeChanges)
        {
            _context.EoperationModeChanges.Add(eoperationModeChanges);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EoperationModeChangesExists(eoperationModeChanges.EoperationModeChangesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEoperationModeChanges", new { id = eoperationModeChanges.EoperationModeChangesId }, eoperationModeChanges);
        }

        // DELETE: api/EoperationModeChanges/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EoperationModeChanges>> DeleteEoperationModeChanges(long id)
        {
            var eoperationModeChanges = await _context.EoperationModeChanges.FindAsync(id);
            if (eoperationModeChanges == null)
            {
                return NotFound();
            }

            _context.EoperationModeChanges.Remove(eoperationModeChanges);
            await _context.SaveChangesAsync();

            return eoperationModeChanges;
        }

        private bool EoperationModeChangesExists(long id)
        {
            return _context.EoperationModeChanges.Any(e => e.EoperationModeChangesId == id);
        }
    }
}
