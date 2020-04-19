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
    public class EformationsController : ControllerBase
    {
        private readonly DBContext _context;

        public EformationsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Eformations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eformations>>> GetEformations()
        {
            return await _context.Eformations.ToListAsync();
        }

        // GET: api/Eformations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eformations>> GetEformations(long id)
        {
            var eformations = await _context.Eformations.FindAsync(id);

            if (eformations == null)
            {
                return NotFound();
            }

            return eformations;
        }

        // PUT: api/Eformations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEformations(long id, Eformations eformations)
        {
            if (id != eformations.EformationsId)
            {
                return BadRequest();
            }

            _context.Entry(eformations).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EformationsExists(id))
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

        // POST: api/Eformations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eformations>> PostEformations(Eformations eformations)
        {
            _context.Eformations.Add(eformations);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EformationsExists(eformations.EformationsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEformations", new { id = eformations.EformationsId }, eformations);
        }

        // DELETE: api/Eformations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eformations>> DeleteEformations(long id)
        {
            var eformations = await _context.Eformations.FindAsync(id);
            if (eformations == null)
            {
                return NotFound();
            }

            _context.Eformations.Remove(eformations);
            await _context.SaveChangesAsync();

            return eformations;
        }

        private bool EformationsExists(long id)
        {
            return _context.Eformations.Any(e => e.EformationsId == id);
        }
    }
}
