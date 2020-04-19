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
    public class EstatisticsController : ControllerBase
    {
        private readonly DBContext _context;

        public EstatisticsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Estatistics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estatistics>>> GetEstatistics()
        {
            return await _context.Estatistics.ToListAsync();
        }

        // GET: api/Estatistics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Estatistics>> GetEstatistics(long id)
        {
            var estatistics = await _context.Estatistics.FindAsync(id);

            if (estatistics == null)
            {
                return NotFound();
            }

            return estatistics;
        }

        // PUT: api/Estatistics/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstatistics(long id, Estatistics estatistics)
        {
            if (id != estatistics.EstatisticsId)
            {
                return BadRequest();
            }

            _context.Entry(estatistics).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstatisticsExists(id))
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

        // POST: api/Estatistics
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Estatistics>> PostEstatistics(Estatistics estatistics)
        {
            _context.Estatistics.Add(estatistics);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EstatisticsExists(estatistics.EstatisticsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEstatistics", new { id = estatistics.EstatisticsId }, estatistics);
        }

        // DELETE: api/Estatistics/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Estatistics>> DeleteEstatistics(long id)
        {
            var estatistics = await _context.Estatistics.FindAsync(id);
            if (estatistics == null)
            {
                return NotFound();
            }

            _context.Estatistics.Remove(estatistics);
            await _context.SaveChangesAsync();

            return estatistics;
        }

        private bool EstatisticsExists(long id)
        {
            return _context.Estatistics.Any(e => e.EstatisticsId == id);
        }
    }
}
