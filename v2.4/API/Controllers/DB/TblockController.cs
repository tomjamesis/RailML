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
    public class TblockController : ControllerBase
    {
        private readonly DBContext _context;

        public TblockController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tblock
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tblock>>> GetTblock()
        {
            return await _context.Tblock.ToListAsync();
        }

        // GET: api/Tblock/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tblock>> GetTblock(short id)
        {
            var tblock = await _context.Tblock.FindAsync(id);

            if (tblock == null)
            {
                return NotFound();
            }

            return tblock;
        }

        // PUT: api/Tblock/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblock(short id, Tblock tblock)
        {
            if (id != tblock.TblockId)
            {
                return BadRequest();
            }

            _context.Entry(tblock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblockExists(id))
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

        // POST: api/Tblock
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tblock>> PostTblock(Tblock tblock)
        {
            _context.Tblock.Add(tblock);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TblockExists(tblock.TblockId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTblock", new { id = tblock.TblockId }, tblock);
        }

        // DELETE: api/Tblock/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tblock>> DeleteTblock(short id)
        {
            var tblock = await _context.Tblock.FindAsync(id);
            if (tblock == null)
            {
                return NotFound();
            }

            _context.Tblock.Remove(tblock);
            await _context.SaveChangesAsync();

            return tblock;
        }

        private bool TblockExists(short id)
        {
            return _context.Tblock.Any(e => e.TblockId == id);
        }
    }
}
