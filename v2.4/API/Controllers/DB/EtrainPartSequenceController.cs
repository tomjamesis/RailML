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
    public class EtrainPartSequenceController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrainPartSequenceController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrainPartSequence
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrainPartSequence>>> GetEtrainPartSequence()
        {
            return await _context.EtrainPartSequence.ToListAsync();
        }

        // GET: api/EtrainPartSequence/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrainPartSequence>> GetEtrainPartSequence(short id)
        {
            var etrainPartSequence = await _context.EtrainPartSequence.FindAsync(id);

            if (etrainPartSequence == null)
            {
                return NotFound();
            }

            return etrainPartSequence;
        }

        // PUT: api/EtrainPartSequence/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrainPartSequence(short id, EtrainPartSequence etrainPartSequence)
        {
            if (id != etrainPartSequence.EtrainPartSequenceId)
            {
                return BadRequest();
            }

            _context.Entry(etrainPartSequence).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrainPartSequenceExists(id))
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

        // POST: api/EtrainPartSequence
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrainPartSequence>> PostEtrainPartSequence(EtrainPartSequence etrainPartSequence)
        {
            _context.EtrainPartSequence.Add(etrainPartSequence);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrainPartSequenceExists(etrainPartSequence.EtrainPartSequenceId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrainPartSequence", new { id = etrainPartSequence.EtrainPartSequenceId }, etrainPartSequence);
        }

        // DELETE: api/EtrainPartSequence/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrainPartSequence>> DeleteEtrainPartSequence(short id)
        {
            var etrainPartSequence = await _context.EtrainPartSequence.FindAsync(id);
            if (etrainPartSequence == null)
            {
                return NotFound();
            }

            _context.EtrainPartSequence.Remove(etrainPartSequence);
            await _context.SaveChangesAsync();

            return etrainPartSequence;
        }

        private bool EtrainPartSequenceExists(short id)
        {
            return _context.EtrainPartSequence.Any(e => e.EtrainPartSequenceId == id);
        }
    }
}
