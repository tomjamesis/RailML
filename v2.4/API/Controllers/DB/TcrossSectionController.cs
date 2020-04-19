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
    public class TcrossSectionController : ControllerBase
    {
        private readonly DBContext _context;

        public TcrossSectionController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TcrossSection
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TcrossSection>>> GetTcrossSection()
        {
            return await _context.TcrossSection.ToListAsync();
        }

        // GET: api/TcrossSection/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TcrossSection>> GetTcrossSection(short id)
        {
            var tcrossSection = await _context.TcrossSection.FindAsync(id);

            if (tcrossSection == null)
            {
                return NotFound();
            }

            return tcrossSection;
        }

        // PUT: api/TcrossSection/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTcrossSection(short id, TcrossSection tcrossSection)
        {
            if (id != tcrossSection.TcrossSectionId)
            {
                return BadRequest();
            }

            _context.Entry(tcrossSection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TcrossSectionExists(id))
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

        // POST: api/TcrossSection
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TcrossSection>> PostTcrossSection(TcrossSection tcrossSection)
        {
            _context.TcrossSection.Add(tcrossSection);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TcrossSectionExists(tcrossSection.TcrossSectionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTcrossSection", new { id = tcrossSection.TcrossSectionId }, tcrossSection);
        }

        // DELETE: api/TcrossSection/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TcrossSection>> DeleteTcrossSection(short id)
        {
            var tcrossSection = await _context.TcrossSection.FindAsync(id);
            if (tcrossSection == null)
            {
                return NotFound();
            }

            _context.TcrossSection.Remove(tcrossSection);
            await _context.SaveChangesAsync();

            return tcrossSection;
        }

        private bool TcrossSectionExists(short id)
        {
            return _context.TcrossSection.Any(e => e.TcrossSectionId == id);
        }
    }
}
