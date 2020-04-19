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
    public class TsignalLineController : ControllerBase
    {
        private readonly DBContext _context;

        public TsignalLineController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TsignalLine
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TsignalLine>>> GetTsignalLine()
        {
            return await _context.TsignalLine.ToListAsync();
        }

        // GET: api/TsignalLine/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TsignalLine>> GetTsignalLine(short id)
        {
            var tsignalLine = await _context.TsignalLine.FindAsync(id);

            if (tsignalLine == null)
            {
                return NotFound();
            }

            return tsignalLine;
        }

        // PUT: api/TsignalLine/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTsignalLine(short id, TsignalLine tsignalLine)
        {
            if (id != tsignalLine.TsignalLineId)
            {
                return BadRequest();
            }

            _context.Entry(tsignalLine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TsignalLineExists(id))
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

        // POST: api/TsignalLine
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TsignalLine>> PostTsignalLine(TsignalLine tsignalLine)
        {
            _context.TsignalLine.Add(tsignalLine);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TsignalLineExists(tsignalLine.TsignalLineId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTsignalLine", new { id = tsignalLine.TsignalLineId }, tsignalLine);
        }

        // DELETE: api/TsignalLine/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TsignalLine>> DeleteTsignalLine(short id)
        {
            var tsignalLine = await _context.TsignalLine.FindAsync(id);
            if (tsignalLine == null)
            {
                return NotFound();
            }

            _context.TsignalLine.Remove(tsignalLine);
            await _context.SaveChangesAsync();

            return tsignalLine;
        }

        private bool TsignalLineExists(short id)
        {
            return _context.TsignalLine.Any(e => e.TsignalLineId == id);
        }
    }
}
