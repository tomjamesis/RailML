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
    public class EocsElementsController : ControllerBase
    {
        private readonly DBContext _context;

        public EocsElementsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EocsElements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EocsElements>>> GetEocsElements()
        {
            return await _context.EocsElements.ToListAsync();
        }

        // GET: api/EocsElements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EocsElements>> GetEocsElements(long id)
        {
            var eocsElements = await _context.EocsElements.FindAsync(id);

            if (eocsElements == null)
            {
                return NotFound();
            }

            return eocsElements;
        }

        // PUT: api/EocsElements/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEocsElements(long id, EocsElements eocsElements)
        {
            if (id != eocsElements.EocsElementsId)
            {
                return BadRequest();
            }

            _context.Entry(eocsElements).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EocsElementsExists(id))
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

        // POST: api/EocsElements
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EocsElements>> PostEocsElements(EocsElements eocsElements)
        {
            _context.EocsElements.Add(eocsElements);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EocsElementsExists(eocsElements.EocsElementsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEocsElements", new { id = eocsElements.EocsElementsId }, eocsElements);
        }

        // DELETE: api/EocsElements/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EocsElements>> DeleteEocsElements(long id)
        {
            var eocsElements = await _context.EocsElements.FindAsync(id);
            if (eocsElements == null)
            {
                return NotFound();
            }

            _context.EocsElements.Remove(eocsElements);
            await _context.SaveChangesAsync();

            return eocsElements;
        }

        private bool EocsElementsExists(long id)
        {
            return _context.EocsElements.Any(e => e.EocsElementsId == id);
        }
    }
}
