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
    public class TblockPartSequenceController : ControllerBase
    {
        private readonly DBContext _context;

        public TblockPartSequenceController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TblockPartSequence
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblockPartSequence>>> GetTblockPartSequence()
        {
            return await _context.TblockPartSequence.ToListAsync();
        }

        // GET: api/TblockPartSequence/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblockPartSequence>> GetTblockPartSequence(long id)
        {
            var tblockPartSequence = await _context.TblockPartSequence.FindAsync(id);

            if (tblockPartSequence == null)
            {
                return NotFound();
            }

            return tblockPartSequence;
        }

        // PUT: api/TblockPartSequence/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblockPartSequence(long id, TblockPartSequence tblockPartSequence)
        {
            if (id != tblockPartSequence.TblockPartSequenceId)
            {
                return BadRequest();
            }

            _context.Entry(tblockPartSequence).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblockPartSequenceExists(id))
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

        // POST: api/TblockPartSequence
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblockPartSequence>> PostTblockPartSequence(TblockPartSequence tblockPartSequence)
        {
            _context.TblockPartSequence.Add(tblockPartSequence);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TblockPartSequenceExists(tblockPartSequence.TblockPartSequenceId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTblockPartSequence", new { id = tblockPartSequence.TblockPartSequenceId }, tblockPartSequence);
        }

        // DELETE: api/TblockPartSequence/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblockPartSequence>> DeleteTblockPartSequence(long id)
        {
            var tblockPartSequence = await _context.TblockPartSequence.FindAsync(id);
            if (tblockPartSequence == null)
            {
                return NotFound();
            }

            _context.TblockPartSequence.Remove(tblockPartSequence);
            await _context.SaveChangesAsync();

            return tblockPartSequence;
        }

        private bool TblockPartSequenceExists(long id)
        {
            return _context.TblockPartSequence.Any(e => e.TblockPartSequenceId == id);
        }
    }
}
