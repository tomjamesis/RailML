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
    public class EtrackVisController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrackVisController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrackVis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrackVis>>> GetEtrackVis()
        {
            return await _context.EtrackVis.ToListAsync();
        }

        // GET: api/EtrackVis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrackVis>> GetEtrackVis(short id)
        {
            var etrackVis = await _context.EtrackVis.FindAsync(id);

            if (etrackVis == null)
            {
                return NotFound();
            }

            return etrackVis;
        }

        // PUT: api/EtrackVis/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrackVis(short id, EtrackVis etrackVis)
        {
            if (id != etrackVis.EtrackVisId)
            {
                return BadRequest();
            }

            _context.Entry(etrackVis).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrackVisExists(id))
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

        // POST: api/EtrackVis
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrackVis>> PostEtrackVis(EtrackVis etrackVis)
        {
            _context.EtrackVis.Add(etrackVis);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrackVisExists(etrackVis.EtrackVisId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrackVis", new { id = etrackVis.EtrackVisId }, etrackVis);
        }

        // DELETE: api/EtrackVis/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrackVis>> DeleteEtrackVis(short id)
        {
            var etrackVis = await _context.EtrackVis.FindAsync(id);
            if (etrackVis == null)
            {
                return NotFound();
            }

            _context.EtrackVis.Remove(etrackVis);
            await _context.SaveChangesAsync();

            return etrackVis;
        }

        private bool EtrackVisExists(short id)
        {
            return _context.EtrackVis.Any(e => e.EtrackVisId == id);
        }
    }
}
