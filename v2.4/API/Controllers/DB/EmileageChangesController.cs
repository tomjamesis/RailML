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
    public class EmileageChangesController : ControllerBase
    {
        private readonly DBContext _context;

        public EmileageChangesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EmileageChanges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmileageChanges>>> GetEmileageChanges()
        {
            return await _context.EmileageChanges.ToListAsync();
        }

        // GET: api/EmileageChanges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmileageChanges>> GetEmileageChanges(long id)
        {
            var emileageChanges = await _context.EmileageChanges.FindAsync(id);

            if (emileageChanges == null)
            {
                return NotFound();
            }

            return emileageChanges;
        }

        // PUT: api/EmileageChanges/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmileageChanges(long id, EmileageChanges emileageChanges)
        {
            if (id != emileageChanges.EmileageChangesId)
            {
                return BadRequest();
            }

            _context.Entry(emileageChanges).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmileageChangesExists(id))
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

        // POST: api/EmileageChanges
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EmileageChanges>> PostEmileageChanges(EmileageChanges emileageChanges)
        {
            _context.EmileageChanges.Add(emileageChanges);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmileageChangesExists(emileageChanges.EmileageChangesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmileageChanges", new { id = emileageChanges.EmileageChangesId }, emileageChanges);
        }

        // DELETE: api/EmileageChanges/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EmileageChanges>> DeleteEmileageChanges(long id)
        {
            var emileageChanges = await _context.EmileageChanges.FindAsync(id);
            if (emileageChanges == null)
            {
                return NotFound();
            }

            _context.EmileageChanges.Remove(emileageChanges);
            await _context.SaveChangesAsync();

            return emileageChanges;
        }

        private bool EmileageChangesExists(long id)
        {
            return _context.EmileageChanges.Any(e => e.EmileageChangesId == id);
        }
    }
}
