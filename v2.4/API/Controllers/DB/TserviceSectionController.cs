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
    public class TserviceSectionController : ControllerBase
    {
        private readonly DBContext _context;

        public TserviceSectionController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TserviceSection
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TserviceSection>>> GetTserviceSection()
        {
            return await _context.TserviceSection.ToListAsync();
        }

        // GET: api/TserviceSection/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TserviceSection>> GetTserviceSection(short id)
        {
            var tserviceSection = await _context.TserviceSection.FindAsync(id);

            if (tserviceSection == null)
            {
                return NotFound();
            }

            return tserviceSection;
        }

        // PUT: api/TserviceSection/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTserviceSection(short id, TserviceSection tserviceSection)
        {
            if (id != tserviceSection.TserviceSectionId)
            {
                return BadRequest();
            }

            _context.Entry(tserviceSection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TserviceSectionExists(id))
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

        // POST: api/TserviceSection
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TserviceSection>> PostTserviceSection(TserviceSection tserviceSection)
        {
            _context.TserviceSection.Add(tserviceSection);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TserviceSectionExists(tserviceSection.TserviceSectionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTserviceSection", new { id = tserviceSection.TserviceSectionId }, tserviceSection);
        }

        // DELETE: api/TserviceSection/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TserviceSection>> DeleteTserviceSection(short id)
        {
            var tserviceSection = await _context.TserviceSection.FindAsync(id);
            if (tserviceSection == null)
            {
                return NotFound();
            }

            _context.TserviceSection.Remove(tserviceSection);
            await _context.SaveChangesAsync();

            return tserviceSection;
        }

        private bool TserviceSectionExists(short id)
        {
            return _context.TserviceSection.Any(e => e.TserviceSectionId == id);
        }
    }
}
