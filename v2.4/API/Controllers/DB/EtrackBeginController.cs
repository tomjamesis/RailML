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
    public class EtrackBeginController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrackBeginController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrackBegin
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrackBegin>>> GetEtrackBegin()
        {
            return await _context.EtrackBegin.ToListAsync();
        }

        // GET: api/EtrackBegin/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrackBegin>> GetEtrackBegin(short id)
        {
            var etrackBegin = await _context.EtrackBegin.FindAsync(id);

            if (etrackBegin == null)
            {
                return NotFound();
            }

            return etrackBegin;
        }

        // PUT: api/EtrackBegin/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrackBegin(short id, EtrackBegin etrackBegin)
        {
            if (id != etrackBegin.EtrackBeginId)
            {
                return BadRequest();
            }

            _context.Entry(etrackBegin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrackBeginExists(id))
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

        // POST: api/EtrackBegin
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrackBegin>> PostEtrackBegin(EtrackBegin etrackBegin)
        {
            _context.EtrackBegin.Add(etrackBegin);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrackBeginExists(etrackBegin.EtrackBeginId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrackBegin", new { id = etrackBegin.EtrackBeginId }, etrackBegin);
        }

        // DELETE: api/EtrackBegin/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrackBegin>> DeleteEtrackBegin(short id)
        {
            var etrackBegin = await _context.EtrackBegin.FindAsync(id);
            if (etrackBegin == null)
            {
                return NotFound();
            }

            _context.EtrackBegin.Remove(etrackBegin);
            await _context.SaveChangesAsync();

            return etrackBegin;
        }

        private bool EtrackBeginExists(short id)
        {
            return _context.EtrackBegin.Any(e => e.EtrackBeginId == id);
        }
    }
}
