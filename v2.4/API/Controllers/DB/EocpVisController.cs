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
    public class EocpVisController : ControllerBase
    {
        private readonly DBContext _context;

        public EocpVisController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EocpVis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EocpVis>>> GetEocpVis()
        {
            return await _context.EocpVis.ToListAsync();
        }

        // GET: api/EocpVis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EocpVis>> GetEocpVis(short id)
        {
            var eocpVis = await _context.EocpVis.FindAsync(id);

            if (eocpVis == null)
            {
                return NotFound();
            }

            return eocpVis;
        }

        // PUT: api/EocpVis/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEocpVis(short id, EocpVis eocpVis)
        {
            if (id != eocpVis.EocpVisId)
            {
                return BadRequest();
            }

            _context.Entry(eocpVis).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EocpVisExists(id))
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

        // POST: api/EocpVis
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EocpVis>> PostEocpVis(EocpVis eocpVis)
        {
            _context.EocpVis.Add(eocpVis);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EocpVisExists(eocpVis.EocpVisId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEocpVis", new { id = eocpVis.EocpVisId }, eocpVis);
        }

        // DELETE: api/EocpVis/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EocpVis>> DeleteEocpVis(short id)
        {
            var eocpVis = await _context.EocpVis.FindAsync(id);
            if (eocpVis == null)
            {
                return NotFound();
            }

            _context.EocpVis.Remove(eocpVis);
            await _context.SaveChangesAsync();

            return eocpVis;
        }

        private bool EocpVisExists(short id)
        {
            return _context.EocpVis.Any(e => e.EocpVisId == id);
        }
    }
}
