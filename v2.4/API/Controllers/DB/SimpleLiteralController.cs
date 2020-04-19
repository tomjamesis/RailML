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
    public class SimpleLiteralController : ControllerBase
    {
        private readonly DBContext _context;

        public SimpleLiteralController(DBContext context)
        {
            _context = context;
        }

        // GET: api/SimpleLiteral
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SimpleLiteral>>> GetSimpleLiteral()
        {
            return await _context.SimpleLiteral.ToListAsync();
        }

        // GET: api/SimpleLiteral/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SimpleLiteral>> GetSimpleLiteral(long id)
        {
            var simpleLiteral = await _context.SimpleLiteral.FindAsync(id);

            if (simpleLiteral == null)
            {
                return NotFound();
            }

            return simpleLiteral;
        }

        // PUT: api/SimpleLiteral/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSimpleLiteral(long id, SimpleLiteral simpleLiteral)
        {
            if (id != simpleLiteral.SimpleLiteralId)
            {
                return BadRequest();
            }

            _context.Entry(simpleLiteral).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SimpleLiteralExists(id))
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

        // POST: api/SimpleLiteral
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SimpleLiteral>> PostSimpleLiteral(SimpleLiteral simpleLiteral)
        {
            _context.SimpleLiteral.Add(simpleLiteral);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SimpleLiteralExists(simpleLiteral.SimpleLiteralId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSimpleLiteral", new { id = simpleLiteral.SimpleLiteralId }, simpleLiteral);
        }

        // DELETE: api/SimpleLiteral/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SimpleLiteral>> DeleteSimpleLiteral(long id)
        {
            var simpleLiteral = await _context.SimpleLiteral.FindAsync(id);
            if (simpleLiteral == null)
            {
                return NotFound();
            }

            _context.SimpleLiteral.Remove(simpleLiteral);
            await _context.SaveChangesAsync();

            return simpleLiteral;
        }

        private bool SimpleLiteralExists(long id)
        {
            return _context.SimpleLiteral.Any(e => e.SimpleLiteralId == id);
        }
    }
}
