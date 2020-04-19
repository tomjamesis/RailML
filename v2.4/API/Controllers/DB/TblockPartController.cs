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
    public class TblockPartController : ControllerBase
    {
        private readonly DBContext _context;

        public TblockPartController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TblockPart
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblockPart>>> GetTblockPart()
        {
            return await _context.TblockPart.ToListAsync();
        }

        // GET: api/TblockPart/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblockPart>> GetTblockPart(short id)
        {
            var tblockPart = await _context.TblockPart.FindAsync(id);

            if (tblockPart == null)
            {
                return NotFound();
            }

            return tblockPart;
        }

        // PUT: api/TblockPart/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblockPart(short id, TblockPart tblockPart)
        {
            if (id != tblockPart.TblockPartId)
            {
                return BadRequest();
            }

            _context.Entry(tblockPart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblockPartExists(id))
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

        // POST: api/TblockPart
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblockPart>> PostTblockPart(TblockPart tblockPart)
        {
            _context.TblockPart.Add(tblockPart);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TblockPartExists(tblockPart.TblockPartId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTblockPart", new { id = tblockPart.TblockPartId }, tblockPart);
        }

        // DELETE: api/TblockPart/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblockPart>> DeleteTblockPart(short id)
        {
            var tblockPart = await _context.TblockPart.FindAsync(id);
            if (tblockPart == null)
            {
                return NotFound();
            }

            _context.TblockPart.Remove(tblockPart);
            await _context.SaveChangesAsync();

            return tblockPart;
        }

        private bool TblockPartExists(short id)
        {
            return _context.TblockPart.Any(e => e.TblockPartId == id);
        }
    }
}
