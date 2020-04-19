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
    public class EblockController : ControllerBase
    {
        private readonly DBContext _context;

        public EblockController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Eblock
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eblock>>> GetEblock()
        {
            return await _context.Eblock.ToListAsync();
        }

        // GET: api/Eblock/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eblock>> GetEblock(short id)
        {
            var eblock = await _context.Eblock.FindAsync(id);

            if (eblock == null)
            {
                return NotFound();
            }

            return eblock;
        }

        // PUT: api/Eblock/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEblock(short id, Eblock eblock)
        {
            if (id != eblock.EblockId)
            {
                return BadRequest();
            }

            _context.Entry(eblock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EblockExists(id))
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

        // POST: api/Eblock
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eblock>> PostEblock(Eblock eblock)
        {
            _context.Eblock.Add(eblock);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EblockExists(eblock.EblockId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEblock", new { id = eblock.EblockId }, eblock);
        }

        // DELETE: api/Eblock/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eblock>> DeleteEblock(short id)
        {
            var eblock = await _context.Eblock.FindAsync(id);
            if (eblock == null)
            {
                return NotFound();
            }

            _context.Eblock.Remove(eblock);
            await _context.SaveChangesAsync();

            return eblock;
        }

        private bool EblockExists(short id)
        {
            return _context.Eblock.Any(e => e.EblockId == id);
        }
    }
}
