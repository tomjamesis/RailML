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
    public class TocpPropEquipmentSummaryController : ControllerBase
    {
        private readonly DBContext _context;

        public TocpPropEquipmentSummaryController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TocpPropEquipmentSummary
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TocpPropEquipmentSummary>>> GetTocpPropEquipmentSummary()
        {
            return await _context.TocpPropEquipmentSummary.ToListAsync();
        }

        // GET: api/TocpPropEquipmentSummary/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TocpPropEquipmentSummary>> GetTocpPropEquipmentSummary(long id)
        {
            var tocpPropEquipmentSummary = await _context.TocpPropEquipmentSummary.FindAsync(id);

            if (tocpPropEquipmentSummary == null)
            {
                return NotFound();
            }

            return tocpPropEquipmentSummary;
        }

        // PUT: api/TocpPropEquipmentSummary/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTocpPropEquipmentSummary(long id, TocpPropEquipmentSummary tocpPropEquipmentSummary)
        {
            if (id != tocpPropEquipmentSummary.TocpPropEquipmentSummaryId)
            {
                return BadRequest();
            }

            _context.Entry(tocpPropEquipmentSummary).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TocpPropEquipmentSummaryExists(id))
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

        // POST: api/TocpPropEquipmentSummary
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TocpPropEquipmentSummary>> PostTocpPropEquipmentSummary(TocpPropEquipmentSummary tocpPropEquipmentSummary)
        {
            _context.TocpPropEquipmentSummary.Add(tocpPropEquipmentSummary);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TocpPropEquipmentSummaryExists(tocpPropEquipmentSummary.TocpPropEquipmentSummaryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTocpPropEquipmentSummary", new { id = tocpPropEquipmentSummary.TocpPropEquipmentSummaryId }, tocpPropEquipmentSummary);
        }

        // DELETE: api/TocpPropEquipmentSummary/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TocpPropEquipmentSummary>> DeleteTocpPropEquipmentSummary(long id)
        {
            var tocpPropEquipmentSummary = await _context.TocpPropEquipmentSummary.FindAsync(id);
            if (tocpPropEquipmentSummary == null)
            {
                return NotFound();
            }

            _context.TocpPropEquipmentSummary.Remove(tocpPropEquipmentSummary);
            await _context.SaveChangesAsync();

            return tocpPropEquipmentSummary;
        }

        private bool TocpPropEquipmentSummaryExists(long id)
        {
            return _context.TocpPropEquipmentSummary.Any(e => e.TocpPropEquipmentSummaryId == id);
        }
    }
}
