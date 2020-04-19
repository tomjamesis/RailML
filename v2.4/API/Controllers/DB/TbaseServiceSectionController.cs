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
    public class TbaseServiceSectionController : ControllerBase
    {
        private readonly DBContext _context;

        public TbaseServiceSectionController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TbaseServiceSection
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbaseServiceSection>>> GetTbaseServiceSection()
        {
            return await _context.TbaseServiceSection.ToListAsync();
        }

        // GET: api/TbaseServiceSection/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbaseServiceSection>> GetTbaseServiceSection(short id)
        {
            var tbaseServiceSection = await _context.TbaseServiceSection.FindAsync(id);

            if (tbaseServiceSection == null)
            {
                return NotFound();
            }

            return tbaseServiceSection;
        }

        // PUT: api/TbaseServiceSection/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbaseServiceSection(short id, TbaseServiceSection tbaseServiceSection)
        {
            if (id != tbaseServiceSection.TbaseServiceSectionId)
            {
                return BadRequest();
            }

            _context.Entry(tbaseServiceSection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbaseServiceSectionExists(id))
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

        // POST: api/TbaseServiceSection
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TbaseServiceSection>> PostTbaseServiceSection(TbaseServiceSection tbaseServiceSection)
        {
            _context.TbaseServiceSection.Add(tbaseServiceSection);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbaseServiceSectionExists(tbaseServiceSection.TbaseServiceSectionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbaseServiceSection", new { id = tbaseServiceSection.TbaseServiceSectionId }, tbaseServiceSection);
        }

        // DELETE: api/TbaseServiceSection/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbaseServiceSection>> DeleteTbaseServiceSection(short id)
        {
            var tbaseServiceSection = await _context.TbaseServiceSection.FindAsync(id);
            if (tbaseServiceSection == null)
            {
                return NotFound();
            }

            _context.TbaseServiceSection.Remove(tbaseServiceSection);
            await _context.SaveChangesAsync();

            return tbaseServiceSection;
        }

        private bool TbaseServiceSectionExists(short id)
        {
            return _context.TbaseServiceSection.Any(e => e.TbaseServiceSectionId == id);
        }
    }
}
