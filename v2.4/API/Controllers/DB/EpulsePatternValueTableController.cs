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
    public class EpulsePatternValueTableController : ControllerBase
    {
        private readonly DBContext _context;

        public EpulsePatternValueTableController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EpulsePatternValueTable
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EpulsePatternValueTable>>> GetEpulsePatternValueTable()
        {
            return await _context.EpulsePatternValueTable.ToListAsync();
        }

        // GET: api/EpulsePatternValueTable/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EpulsePatternValueTable>> GetEpulsePatternValueTable(short id)
        {
            var epulsePatternValueTable = await _context.EpulsePatternValueTable.FindAsync(id);

            if (epulsePatternValueTable == null)
            {
                return NotFound();
            }

            return epulsePatternValueTable;
        }

        // PUT: api/EpulsePatternValueTable/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEpulsePatternValueTable(short id, EpulsePatternValueTable epulsePatternValueTable)
        {
            if (id != epulsePatternValueTable.EpulsePatternValueTableId)
            {
                return BadRequest();
            }

            _context.Entry(epulsePatternValueTable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EpulsePatternValueTableExists(id))
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

        // POST: api/EpulsePatternValueTable
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EpulsePatternValueTable>> PostEpulsePatternValueTable(EpulsePatternValueTable epulsePatternValueTable)
        {
            _context.EpulsePatternValueTable.Add(epulsePatternValueTable);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EpulsePatternValueTableExists(epulsePatternValueTable.EpulsePatternValueTableId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEpulsePatternValueTable", new { id = epulsePatternValueTable.EpulsePatternValueTableId }, epulsePatternValueTable);
        }

        // DELETE: api/EpulsePatternValueTable/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EpulsePatternValueTable>> DeleteEpulsePatternValueTable(short id)
        {
            var epulsePatternValueTable = await _context.EpulsePatternValueTable.FindAsync(id);
            if (epulsePatternValueTable == null)
            {
                return NotFound();
            }

            _context.EpulsePatternValueTable.Remove(epulsePatternValueTable);
            await _context.SaveChangesAsync();

            return epulsePatternValueTable;
        }

        private bool EpulsePatternValueTableExists(short id)
        {
            return _context.EpulsePatternValueTable.Any(e => e.EpulsePatternValueTableId == id);
        }
    }
}
