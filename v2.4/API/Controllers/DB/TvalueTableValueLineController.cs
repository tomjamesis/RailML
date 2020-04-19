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
    public class TvalueTableValueLineController : ControllerBase
    {
        private readonly DBContext _context;

        public TvalueTableValueLineController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TvalueTableValueLine
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TvalueTableValueLine>>> GetTvalueTableValueLine()
        {
            return await _context.TvalueTableValueLine.ToListAsync();
        }

        // GET: api/TvalueTableValueLine/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TvalueTableValueLine>> GetTvalueTableValueLine(long id)
        {
            var tvalueTableValueLine = await _context.TvalueTableValueLine.FindAsync(id);

            if (tvalueTableValueLine == null)
            {
                return NotFound();
            }

            return tvalueTableValueLine;
        }

        // PUT: api/TvalueTableValueLine/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTvalueTableValueLine(long id, TvalueTableValueLine tvalueTableValueLine)
        {
            if (id != tvalueTableValueLine.TvalueTableValueLineId)
            {
                return BadRequest();
            }

            _context.Entry(tvalueTableValueLine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TvalueTableValueLineExists(id))
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

        // POST: api/TvalueTableValueLine
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TvalueTableValueLine>> PostTvalueTableValueLine(TvalueTableValueLine tvalueTableValueLine)
        {
            _context.TvalueTableValueLine.Add(tvalueTableValueLine);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TvalueTableValueLineExists(tvalueTableValueLine.TvalueTableValueLineId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTvalueTableValueLine", new { id = tvalueTableValueLine.TvalueTableValueLineId }, tvalueTableValueLine);
        }

        // DELETE: api/TvalueTableValueLine/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TvalueTableValueLine>> DeleteTvalueTableValueLine(long id)
        {
            var tvalueTableValueLine = await _context.TvalueTableValueLine.FindAsync(id);
            if (tvalueTableValueLine == null)
            {
                return NotFound();
            }

            _context.TvalueTableValueLine.Remove(tvalueTableValueLine);
            await _context.SaveChangesAsync();

            return tvalueTableValueLine;
        }

        private bool TvalueTableValueLineExists(long id)
        {
            return _context.TvalueTableValueLine.Any(e => e.TvalueTableValueLineId == id);
        }
    }
}
