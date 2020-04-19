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
    public class EblocksController : ControllerBase
    {
        private readonly DBContext _context;

        public EblocksController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Eblocks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eblocks>>> GetEblocks()
        {
            return await _context.Eblocks.ToListAsync();
        }

        // GET: api/Eblocks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eblocks>> GetEblocks(long id)
        {
            var eblocks = await _context.Eblocks.FindAsync(id);

            if (eblocks == null)
            {
                return NotFound();
            }

            return eblocks;
        }

        // PUT: api/Eblocks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEblocks(long id, Eblocks eblocks)
        {
            if (id != eblocks.EblocksId)
            {
                return BadRequest();
            }

            _context.Entry(eblocks).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EblocksExists(id))
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

        // POST: api/Eblocks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eblocks>> PostEblocks(Eblocks eblocks)
        {
            _context.Eblocks.Add(eblocks);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EblocksExists(eblocks.EblocksId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEblocks", new { id = eblocks.EblocksId }, eblocks);
        }

        // DELETE: api/Eblocks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eblocks>> DeleteEblocks(long id)
        {
            var eblocks = await _context.Eblocks.FindAsync(id);
            if (eblocks == null)
            {
                return NotFound();
            }

            _context.Eblocks.Remove(eblocks);
            await _context.SaveChangesAsync();

            return eblocks;
        }

        private bool EblocksExists(long id)
        {
            return _context.Eblocks.Any(e => e.EblocksId == id);
        }
    }
}
