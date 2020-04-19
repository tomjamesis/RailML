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
    public class TvalueTableColumnHeaderController : ControllerBase
    {
        private readonly DBContext _context;

        public TvalueTableColumnHeaderController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TvalueTableColumnHeader
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TvalueTableColumnHeader>>> GetTvalueTableColumnHeader()
        {
            return await _context.TvalueTableColumnHeader.ToListAsync();
        }

        // GET: api/TvalueTableColumnHeader/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TvalueTableColumnHeader>> GetTvalueTableColumnHeader(long id)
        {
            var tvalueTableColumnHeader = await _context.TvalueTableColumnHeader.FindAsync(id);

            if (tvalueTableColumnHeader == null)
            {
                return NotFound();
            }

            return tvalueTableColumnHeader;
        }

        // PUT: api/TvalueTableColumnHeader/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTvalueTableColumnHeader(long id, TvalueTableColumnHeader tvalueTableColumnHeader)
        {
            if (id != tvalueTableColumnHeader.TvalueTableColumnHeaderId)
            {
                return BadRequest();
            }

            _context.Entry(tvalueTableColumnHeader).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TvalueTableColumnHeaderExists(id))
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

        // POST: api/TvalueTableColumnHeader
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TvalueTableColumnHeader>> PostTvalueTableColumnHeader(TvalueTableColumnHeader tvalueTableColumnHeader)
        {
            _context.TvalueTableColumnHeader.Add(tvalueTableColumnHeader);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TvalueTableColumnHeaderExists(tvalueTableColumnHeader.TvalueTableColumnHeaderId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTvalueTableColumnHeader", new { id = tvalueTableColumnHeader.TvalueTableColumnHeaderId }, tvalueTableColumnHeader);
        }

        // DELETE: api/TvalueTableColumnHeader/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TvalueTableColumnHeader>> DeleteTvalueTableColumnHeader(long id)
        {
            var tvalueTableColumnHeader = await _context.TvalueTableColumnHeader.FindAsync(id);
            if (tvalueTableColumnHeader == null)
            {
                return NotFound();
            }

            _context.TvalueTableColumnHeader.Remove(tvalueTableColumnHeader);
            await _context.SaveChangesAsync();

            return tvalueTableColumnHeader;
        }

        private bool TvalueTableColumnHeaderExists(long id)
        {
            return _context.TvalueTableColumnHeader.Any(e => e.TvalueTableColumnHeaderId == id);
        }
    }
}
