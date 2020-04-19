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
    public class EblockPartSequenceController : ControllerBase
    {
        private readonly DBContext _context;

        public EblockPartSequenceController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EblockPartSequence
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EblockPartSequence>>> GetEblockPartSequence()
        {
            return await _context.EblockPartSequence.ToListAsync();
        }

        // GET: api/EblockPartSequence/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EblockPartSequence>> GetEblockPartSequence(short id)
        {
            var eblockPartSequence = await _context.EblockPartSequence.FindAsync(id);

            if (eblockPartSequence == null)
            {
                return NotFound();
            }

            return eblockPartSequence;
        }

        // PUT: api/EblockPartSequence/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEblockPartSequence(short id, EblockPartSequence eblockPartSequence)
        {
            if (id != eblockPartSequence.EblockPartSequenceId)
            {
                return BadRequest();
            }

            _context.Entry(eblockPartSequence).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EblockPartSequenceExists(id))
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

        // POST: api/EblockPartSequence
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EblockPartSequence>> PostEblockPartSequence(EblockPartSequence eblockPartSequence)
        {
            _context.EblockPartSequence.Add(eblockPartSequence);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EblockPartSequenceExists(eblockPartSequence.EblockPartSequenceId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEblockPartSequence", new { id = eblockPartSequence.EblockPartSequenceId }, eblockPartSequence);
        }

        // DELETE: api/EblockPartSequence/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EblockPartSequence>> DeleteEblockPartSequence(short id)
        {
            var eblockPartSequence = await _context.EblockPartSequence.FindAsync(id);
            if (eblockPartSequence == null)
            {
                return NotFound();
            }

            _context.EblockPartSequence.Remove(eblockPartSequence);
            await _context.SaveChangesAsync();

            return eblockPartSequence;
        }

        private bool EblockPartSequenceExists(short id)
        {
            return _context.EblockPartSequence.Any(e => e.EblockPartSequenceId == id);
        }
    }
}
