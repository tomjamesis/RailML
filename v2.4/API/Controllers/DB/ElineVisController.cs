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
    public class ElineVisController : ControllerBase
    {
        private readonly DBContext _context;

        public ElineVisController(DBContext context)
        {
            _context = context;
        }

        // GET: api/ElineVis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ElineVis>>> GetElineVis()
        {
            return await _context.ElineVis.ToListAsync();
        }

        // GET: api/ElineVis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ElineVis>> GetElineVis(short id)
        {
            var elineVis = await _context.ElineVis.FindAsync(id);

            if (elineVis == null)
            {
                return NotFound();
            }

            return elineVis;
        }

        // PUT: api/ElineVis/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElineVis(short id, ElineVis elineVis)
        {
            if (id != elineVis.ElineVisId)
            {
                return BadRequest();
            }

            _context.Entry(elineVis).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElineVisExists(id))
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

        // POST: api/ElineVis
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ElineVis>> PostElineVis(ElineVis elineVis)
        {
            _context.ElineVis.Add(elineVis);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ElineVisExists(elineVis.ElineVisId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetElineVis", new { id = elineVis.ElineVisId }, elineVis);
        }

        // DELETE: api/ElineVis/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ElineVis>> DeleteElineVis(short id)
        {
            var elineVis = await _context.ElineVis.FindAsync(id);
            if (elineVis == null)
            {
                return NotFound();
            }

            _context.ElineVis.Remove(elineVis);
            await _context.SaveChangesAsync();

            return elineVis;
        }

        private bool ElineVisExists(short id)
        {
            return _context.ElineVis.Any(e => e.ElineVisId == id);
        }
    }
}
