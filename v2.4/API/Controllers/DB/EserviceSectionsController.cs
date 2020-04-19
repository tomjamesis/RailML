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
    public class EserviceSectionsController : ControllerBase
    {
        private readonly DBContext _context;

        public EserviceSectionsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EserviceSections
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EserviceSections>>> GetEserviceSections()
        {
            return await _context.EserviceSections.ToListAsync();
        }

        // GET: api/EserviceSections/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EserviceSections>> GetEserviceSections(long id)
        {
            var eserviceSections = await _context.EserviceSections.FindAsync(id);

            if (eserviceSections == null)
            {
                return NotFound();
            }

            return eserviceSections;
        }

        // PUT: api/EserviceSections/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEserviceSections(long id, EserviceSections eserviceSections)
        {
            if (id != eserviceSections.EserviceSectionsId)
            {
                return BadRequest();
            }

            _context.Entry(eserviceSections).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EserviceSectionsExists(id))
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

        // POST: api/EserviceSections
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EserviceSections>> PostEserviceSections(EserviceSections eserviceSections)
        {
            _context.EserviceSections.Add(eserviceSections);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EserviceSectionsExists(eserviceSections.EserviceSectionsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEserviceSections", new { id = eserviceSections.EserviceSectionsId }, eserviceSections);
        }

        // DELETE: api/EserviceSections/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EserviceSections>> DeleteEserviceSections(long id)
        {
            var eserviceSections = await _context.EserviceSections.FindAsync(id);
            if (eserviceSections == null)
            {
                return NotFound();
            }

            _context.EserviceSections.Remove(eserviceSections);
            await _context.SaveChangesAsync();

            return eserviceSections;
        }

        private bool EserviceSectionsExists(long id)
        {
            return _context.EserviceSections.Any(e => e.EserviceSectionsId == id);
        }
    }
}
