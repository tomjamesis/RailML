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
    public class TvalueTableController : ControllerBase
    {
        private readonly DBContext _context;

        public TvalueTableController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TvalueTable
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TvalueTable>>> GetTvalueTable()
        {
            return await _context.TvalueTable.ToListAsync();
        }

        // GET: api/TvalueTable/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TvalueTable>> GetTvalueTable(long id)
        {
            var tvalueTable = await _context.TvalueTable.FindAsync(id);

            if (tvalueTable == null)
            {
                return NotFound();
            }

            return tvalueTable;
        }

        // PUT: api/TvalueTable/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTvalueTable(long id, TvalueTable tvalueTable)
        {
            if (id != tvalueTable.TvalueTableId)
            {
                return BadRequest();
            }

            _context.Entry(tvalueTable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TvalueTableExists(id))
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

        // POST: api/TvalueTable
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TvalueTable>> PostTvalueTable(TvalueTable tvalueTable)
        {
            _context.TvalueTable.Add(tvalueTable);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TvalueTableExists(tvalueTable.TvalueTableId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTvalueTable", new { id = tvalueTable.TvalueTableId }, tvalueTable);
        }

        // DELETE: api/TvalueTable/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TvalueTable>> DeleteTvalueTable(long id)
        {
            var tvalueTable = await _context.TvalueTable.FindAsync(id);
            if (tvalueTable == null)
            {
                return NotFound();
            }

            _context.TvalueTable.Remove(tvalueTable);
            await _context.SaveChangesAsync();

            return tvalueTable;
        }

        private bool TvalueTableExists(long id)
        {
            return _context.TvalueTable.Any(e => e.TvalueTableId == id);
        }
    }
}
