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
    public class EblockPartsController : ControllerBase
    {
        private readonly DBContext _context;

        public EblockPartsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EblockParts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EblockParts>>> GetEblockParts()
        {
            return await _context.EblockParts.ToListAsync();
        }

        // GET: api/EblockParts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EblockParts>> GetEblockParts(long id)
        {
            var eblockParts = await _context.EblockParts.FindAsync(id);

            if (eblockParts == null)
            {
                return NotFound();
            }

            return eblockParts;
        }

        // PUT: api/EblockParts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEblockParts(long id, EblockParts eblockParts)
        {
            if (id != eblockParts.EblockPartsId)
            {
                return BadRequest();
            }

            _context.Entry(eblockParts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EblockPartsExists(id))
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

        // POST: api/EblockParts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EblockParts>> PostEblockParts(EblockParts eblockParts)
        {
            _context.EblockParts.Add(eblockParts);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EblockPartsExists(eblockParts.EblockPartsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEblockParts", new { id = eblockParts.EblockPartsId }, eblockParts);
        }

        // DELETE: api/EblockParts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EblockParts>> DeleteEblockParts(long id)
        {
            var eblockParts = await _context.EblockParts.FindAsync(id);
            if (eblockParts == null)
            {
                return NotFound();
            }

            _context.EblockParts.Remove(eblockParts);
            await _context.SaveChangesAsync();

            return eblockParts;
        }

        private bool EblockPartsExists(long id)
        {
            return _context.EblockParts.Any(e => e.EblockPartsId == id);
        }
    }
}
