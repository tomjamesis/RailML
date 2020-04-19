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
    public class ElocksController : ControllerBase
    {
        private readonly DBContext _context;

        public ElocksController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Elocks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Elocks>>> GetElocks()
        {
            return await _context.Elocks.ToListAsync();
        }

        // GET: api/Elocks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Elocks>> GetElocks(long id)
        {
            var elocks = await _context.Elocks.FindAsync(id);

            if (elocks == null)
            {
                return NotFound();
            }

            return elocks;
        }

        // PUT: api/Elocks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElocks(long id, Elocks elocks)
        {
            if (id != elocks.ElocksId)
            {
                return BadRequest();
            }

            _context.Entry(elocks).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElocksExists(id))
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

        // POST: api/Elocks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Elocks>> PostElocks(Elocks elocks)
        {
            _context.Elocks.Add(elocks);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ElocksExists(elocks.ElocksId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetElocks", new { id = elocks.ElocksId }, elocks);
        }

        // DELETE: api/Elocks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Elocks>> DeleteElocks(long id)
        {
            var elocks = await _context.Elocks.FindAsync(id);
            if (elocks == null)
            {
                return NotFound();
            }

            _context.Elocks.Remove(elocks);
            await _context.SaveChangesAsync();

            return elocks;
        }

        private bool ElocksExists(long id)
        {
            return _context.Elocks.Any(e => e.ElocksId == id);
        }
    }
}
