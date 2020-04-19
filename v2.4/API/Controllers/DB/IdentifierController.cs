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
    public class IdentifierController : ControllerBase
    {
        private readonly DBContext _context;

        public IdentifierController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Identifier
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Identifier>>> GetIdentifier()
        {
            return await _context.Identifier.ToListAsync();
        }

        // GET: api/Identifier/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Identifier>> GetIdentifier(short id)
        {
            var identifier = await _context.Identifier.FindAsync(id);

            if (identifier == null)
            {
                return NotFound();
            }

            return identifier;
        }

        // PUT: api/Identifier/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIdentifier(short id, Identifier identifier)
        {
            if (id != identifier.IdentifierId)
            {
                return BadRequest();
            }

            _context.Entry(identifier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IdentifierExists(id))
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

        // POST: api/Identifier
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Identifier>> PostIdentifier(Identifier identifier)
        {
            _context.Identifier.Add(identifier);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (IdentifierExists(identifier.IdentifierId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetIdentifier", new { id = identifier.IdentifierId }, identifier);
        }

        // DELETE: api/Identifier/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Identifier>> DeleteIdentifier(short id)
        {
            var identifier = await _context.Identifier.FindAsync(id);
            if (identifier == null)
            {
                return NotFound();
            }

            _context.Identifier.Remove(identifier);
            await _context.SaveChangesAsync();

            return identifier;
        }

        private bool IdentifierExists(short id)
        {
            return _context.Identifier.Any(e => e.IdentifierId == id);
        }
    }
}
