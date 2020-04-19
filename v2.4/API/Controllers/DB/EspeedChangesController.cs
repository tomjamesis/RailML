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
    public class EspeedChangesController : ControllerBase
    {
        private readonly DBContext _context;

        public EspeedChangesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EspeedChanges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EspeedChanges>>> GetEspeedChanges()
        {
            return await _context.EspeedChanges.ToListAsync();
        }

        // GET: api/EspeedChanges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EspeedChanges>> GetEspeedChanges(long id)
        {
            var espeedChanges = await _context.EspeedChanges.FindAsync(id);

            if (espeedChanges == null)
            {
                return NotFound();
            }

            return espeedChanges;
        }

        // PUT: api/EspeedChanges/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEspeedChanges(long id, EspeedChanges espeedChanges)
        {
            if (id != espeedChanges.EspeedChangesId)
            {
                return BadRequest();
            }

            _context.Entry(espeedChanges).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EspeedChangesExists(id))
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

        // POST: api/EspeedChanges
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EspeedChanges>> PostEspeedChanges(EspeedChanges espeedChanges)
        {
            _context.EspeedChanges.Add(espeedChanges);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EspeedChangesExists(espeedChanges.EspeedChangesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEspeedChanges", new { id = espeedChanges.EspeedChangesId }, espeedChanges);
        }

        // DELETE: api/EspeedChanges/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EspeedChanges>> DeleteEspeedChanges(long id)
        {
            var espeedChanges = await _context.EspeedChanges.FindAsync(id);
            if (espeedChanges == null)
            {
                return NotFound();
            }

            _context.EspeedChanges.Remove(espeedChanges);
            await _context.SaveChangesAsync();

            return espeedChanges;
        }

        private bool EspeedChangesExists(long id)
        {
            return _context.EspeedChanges.Any(e => e.EspeedChangesId == id);
        }
    }
}
