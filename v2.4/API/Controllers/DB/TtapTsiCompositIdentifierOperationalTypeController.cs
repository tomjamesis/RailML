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
    public class TtapTsiCompositIdentifierOperationalTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TtapTsiCompositIdentifierOperationalTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtapTsiCompositIdentifierOperationalType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtapTsiCompositIdentifierOperationalType>>> GetTtapTsiCompositIdentifierOperationalType()
        {
            return await _context.TtapTsiCompositIdentifierOperationalType.ToListAsync();
        }

        // GET: api/TtapTsiCompositIdentifierOperationalType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtapTsiCompositIdentifierOperationalType>> GetTtapTsiCompositIdentifierOperationalType(long id)
        {
            var ttapTsiCompositIdentifierOperationalType = await _context.TtapTsiCompositIdentifierOperationalType.FindAsync(id);

            if (ttapTsiCompositIdentifierOperationalType == null)
            {
                return NotFound();
            }

            return ttapTsiCompositIdentifierOperationalType;
        }

        // PUT: api/TtapTsiCompositIdentifierOperationalType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtapTsiCompositIdentifierOperationalType(long id, TtapTsiCompositIdentifierOperationalType ttapTsiCompositIdentifierOperationalType)
        {
            if (id != ttapTsiCompositIdentifierOperationalType.TtapTsiCompositIdentifierOperationalTypeId)
            {
                return BadRequest();
            }

            _context.Entry(ttapTsiCompositIdentifierOperationalType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtapTsiCompositIdentifierOperationalTypeExists(id))
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

        // POST: api/TtapTsiCompositIdentifierOperationalType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtapTsiCompositIdentifierOperationalType>> PostTtapTsiCompositIdentifierOperationalType(TtapTsiCompositIdentifierOperationalType ttapTsiCompositIdentifierOperationalType)
        {
            _context.TtapTsiCompositIdentifierOperationalType.Add(ttapTsiCompositIdentifierOperationalType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtapTsiCompositIdentifierOperationalTypeExists(ttapTsiCompositIdentifierOperationalType.TtapTsiCompositIdentifierOperationalTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtapTsiCompositIdentifierOperationalType", new { id = ttapTsiCompositIdentifierOperationalType.TtapTsiCompositIdentifierOperationalTypeId }, ttapTsiCompositIdentifierOperationalType);
        }

        // DELETE: api/TtapTsiCompositIdentifierOperationalType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtapTsiCompositIdentifierOperationalType>> DeleteTtapTsiCompositIdentifierOperationalType(long id)
        {
            var ttapTsiCompositIdentifierOperationalType = await _context.TtapTsiCompositIdentifierOperationalType.FindAsync(id);
            if (ttapTsiCompositIdentifierOperationalType == null)
            {
                return NotFound();
            }

            _context.TtapTsiCompositIdentifierOperationalType.Remove(ttapTsiCompositIdentifierOperationalType);
            await _context.SaveChangesAsync();

            return ttapTsiCompositIdentifierOperationalType;
        }

        private bool TtapTsiCompositIdentifierOperationalTypeExists(long id)
        {
            return _context.TtapTsiCompositIdentifierOperationalType.Any(e => e.TtapTsiCompositIdentifierOperationalTypeId == id);
        }
    }
}
