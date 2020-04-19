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
    public class EtrackElementVisController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrackElementVisController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrackElementVis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrackElementVis>>> GetEtrackElementVis()
        {
            return await _context.EtrackElementVis.ToListAsync();
        }

        // GET: api/EtrackElementVis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrackElementVis>> GetEtrackElementVis(short id)
        {
            var etrackElementVis = await _context.EtrackElementVis.FindAsync(id);

            if (etrackElementVis == null)
            {
                return NotFound();
            }

            return etrackElementVis;
        }

        // PUT: api/EtrackElementVis/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrackElementVis(short id, EtrackElementVis etrackElementVis)
        {
            if (id != etrackElementVis.EtrackElementVisId)
            {
                return BadRequest();
            }

            _context.Entry(etrackElementVis).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrackElementVisExists(id))
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

        // POST: api/EtrackElementVis
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrackElementVis>> PostEtrackElementVis(EtrackElementVis etrackElementVis)
        {
            _context.EtrackElementVis.Add(etrackElementVis);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrackElementVisExists(etrackElementVis.EtrackElementVisId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrackElementVis", new { id = etrackElementVis.EtrackElementVisId }, etrackElementVis);
        }

        // DELETE: api/EtrackElementVis/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrackElementVis>> DeleteEtrackElementVis(short id)
        {
            var etrackElementVis = await _context.EtrackElementVis.FindAsync(id);
            if (etrackElementVis == null)
            {
                return NotFound();
            }

            _context.EtrackElementVis.Remove(etrackElementVis);
            await _context.SaveChangesAsync();

            return etrackElementVis;
        }

        private bool EtrackElementVisExists(short id)
        {
            return _context.EtrackElementVis.Any(e => e.EtrackElementVisId == id);
        }
    }
}
