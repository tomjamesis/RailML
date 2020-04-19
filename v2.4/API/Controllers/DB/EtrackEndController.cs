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
    public class EtrackEndController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrackEndController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrackEnd
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrackEnd>>> GetEtrackEnd()
        {
            return await _context.EtrackEnd.ToListAsync();
        }

        // GET: api/EtrackEnd/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrackEnd>> GetEtrackEnd(short id)
        {
            var etrackEnd = await _context.EtrackEnd.FindAsync(id);

            if (etrackEnd == null)
            {
                return NotFound();
            }

            return etrackEnd;
        }

        // PUT: api/EtrackEnd/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrackEnd(short id, EtrackEnd etrackEnd)
        {
            if (id != etrackEnd.EtrackEndId)
            {
                return BadRequest();
            }

            _context.Entry(etrackEnd).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrackEndExists(id))
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

        // POST: api/EtrackEnd
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrackEnd>> PostEtrackEnd(EtrackEnd etrackEnd)
        {
            _context.EtrackEnd.Add(etrackEnd);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrackEndExists(etrackEnd.EtrackEndId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrackEnd", new { id = etrackEnd.EtrackEndId }, etrackEnd);
        }

        // DELETE: api/EtrackEnd/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrackEnd>> DeleteEtrackEnd(short id)
        {
            var etrackEnd = await _context.EtrackEnd.FindAsync(id);
            if (etrackEnd == null)
            {
                return NotFound();
            }

            _context.EtrackEnd.Remove(etrackEnd);
            await _context.SaveChangesAsync();

            return etrackEnd;
        }

        private bool EtrackEndExists(short id)
        {
            return _context.EtrackEnd.Any(e => e.EtrackEndId == id);
        }
    }
}
