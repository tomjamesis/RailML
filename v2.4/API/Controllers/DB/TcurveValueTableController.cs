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
    public class TcurveValueTableController : ControllerBase
    {
        private readonly DBContext _context;

        public TcurveValueTableController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TcurveValueTable
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TcurveValueTable>>> GetTcurveValueTable()
        {
            return await _context.TcurveValueTable.ToListAsync();
        }

        // GET: api/TcurveValueTable/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TcurveValueTable>> GetTcurveValueTable(short id)
        {
            var tcurveValueTable = await _context.TcurveValueTable.FindAsync(id);

            if (tcurveValueTable == null)
            {
                return NotFound();
            }

            return tcurveValueTable;
        }

        // PUT: api/TcurveValueTable/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTcurveValueTable(short id, TcurveValueTable tcurveValueTable)
        {
            if (id != tcurveValueTable.TcurveValueTableId)
            {
                return BadRequest();
            }

            _context.Entry(tcurveValueTable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TcurveValueTableExists(id))
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

        // POST: api/TcurveValueTable
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TcurveValueTable>> PostTcurveValueTable(TcurveValueTable tcurveValueTable)
        {
            _context.TcurveValueTable.Add(tcurveValueTable);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TcurveValueTableExists(tcurveValueTable.TcurveValueTableId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTcurveValueTable", new { id = tcurveValueTable.TcurveValueTableId }, tcurveValueTable);
        }

        // DELETE: api/TcurveValueTable/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TcurveValueTable>> DeleteTcurveValueTable(short id)
        {
            var tcurveValueTable = await _context.TcurveValueTable.FindAsync(id);
            if (tcurveValueTable == null)
            {
                return NotFound();
            }

            _context.TcurveValueTable.Remove(tcurveValueTable);
            await _context.SaveChangesAsync();

            return tcurveValueTable;
        }

        private bool TcurveValueTableExists(short id)
        {
            return _context.TcurveValueTable.Any(e => e.TcurveValueTableId == id);
        }
    }
}
