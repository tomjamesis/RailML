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
    public class EconnectionsController : ControllerBase
    {
        private readonly DBContext _context;

        public EconnectionsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Econnections
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Econnections>>> GetEconnections()
        {
            return await _context.Econnections.ToListAsync();
        }

        // GET: api/Econnections/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Econnections>> GetEconnections(long id)
        {
            var econnections = await _context.Econnections.FindAsync(id);

            if (econnections == null)
            {
                return NotFound();
            }

            return econnections;
        }

        // PUT: api/Econnections/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEconnections(long id, Econnections econnections)
        {
            if (id != econnections.EconnectionsId)
            {
                return BadRequest();
            }

            _context.Entry(econnections).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EconnectionsExists(id))
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

        // POST: api/Econnections
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Econnections>> PostEconnections(Econnections econnections)
        {
            _context.Econnections.Add(econnections);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EconnectionsExists(econnections.EconnectionsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEconnections", new { id = econnections.EconnectionsId }, econnections);
        }

        // DELETE: api/Econnections/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Econnections>> DeleteEconnections(long id)
        {
            var econnections = await _context.Econnections.FindAsync(id);
            if (econnections == null)
            {
                return NotFound();
            }

            _context.Econnections.Remove(econnections);
            await _context.SaveChangesAsync();

            return econnections;
        }

        private bool EconnectionsExists(long id)
        {
            return _context.Econnections.Any(e => e.EconnectionsId == id);
        }
    }
}
