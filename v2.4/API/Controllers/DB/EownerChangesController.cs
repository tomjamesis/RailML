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
    public class EownerChangesController : ControllerBase
    {
        private readonly DBContext _context;

        public EownerChangesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EownerChanges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EownerChanges>>> GetEownerChanges()
        {
            return await _context.EownerChanges.ToListAsync();
        }

        // GET: api/EownerChanges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EownerChanges>> GetEownerChanges(long id)
        {
            var eownerChanges = await _context.EownerChanges.FindAsync(id);

            if (eownerChanges == null)
            {
                return NotFound();
            }

            return eownerChanges;
        }

        // PUT: api/EownerChanges/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEownerChanges(long id, EownerChanges eownerChanges)
        {
            if (id != eownerChanges.EownerChangesId)
            {
                return BadRequest();
            }

            _context.Entry(eownerChanges).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EownerChangesExists(id))
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

        // POST: api/EownerChanges
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EownerChanges>> PostEownerChanges(EownerChanges eownerChanges)
        {
            _context.EownerChanges.Add(eownerChanges);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EownerChangesExists(eownerChanges.EownerChangesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEownerChanges", new { id = eownerChanges.EownerChangesId }, eownerChanges);
        }

        // DELETE: api/EownerChanges/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EownerChanges>> DeleteEownerChanges(long id)
        {
            var eownerChanges = await _context.EownerChanges.FindAsync(id);
            if (eownerChanges == null)
            {
                return NotFound();
            }

            _context.EownerChanges.Remove(eownerChanges);
            await _context.SaveChangesAsync();

            return eownerChanges;
        }

        private bool EownerChangesExists(long id)
        {
            return _context.EownerChanges.Any(e => e.EownerChangesId == id);
        }
    }
}
