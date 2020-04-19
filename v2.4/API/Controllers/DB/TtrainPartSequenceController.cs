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
    public class TtrainPartSequenceController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainPartSequenceController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrainPartSequence
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrainPartSequence>>> GetTtrainPartSequence()
        {
            return await _context.TtrainPartSequence.ToListAsync();
        }

        // GET: api/TtrainPartSequence/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrainPartSequence>> GetTtrainPartSequence(long id)
        {
            var ttrainPartSequence = await _context.TtrainPartSequence.FindAsync(id);

            if (ttrainPartSequence == null)
            {
                return NotFound();
            }

            return ttrainPartSequence;
        }

        // PUT: api/TtrainPartSequence/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrainPartSequence(long id, TtrainPartSequence ttrainPartSequence)
        {
            if (id != ttrainPartSequence.TtrainPartSequenceId)
            {
                return BadRequest();
            }

            _context.Entry(ttrainPartSequence).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainPartSequenceExists(id))
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

        // POST: api/TtrainPartSequence
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrainPartSequence>> PostTtrainPartSequence(TtrainPartSequence ttrainPartSequence)
        {
            _context.TtrainPartSequence.Add(ttrainPartSequence);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainPartSequenceExists(ttrainPartSequence.TtrainPartSequenceId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrainPartSequence", new { id = ttrainPartSequence.TtrainPartSequenceId }, ttrainPartSequence);
        }

        // DELETE: api/TtrainPartSequence/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrainPartSequence>> DeleteTtrainPartSequence(long id)
        {
            var ttrainPartSequence = await _context.TtrainPartSequence.FindAsync(id);
            if (ttrainPartSequence == null)
            {
                return NotFound();
            }

            _context.TtrainPartSequence.Remove(ttrainPartSequence);
            await _context.SaveChangesAsync();

            return ttrainPartSequence;
        }

        private bool TtrainPartSequenceExists(long id)
        {
            return _context.TtrainPartSequence.Any(e => e.TtrainPartSequenceId == id);
        }
    }
}
