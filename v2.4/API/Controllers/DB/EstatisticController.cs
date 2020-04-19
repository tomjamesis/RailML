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
    public class EstatisticController : ControllerBase
    {
        private readonly DBContext _context;

        public EstatisticController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Estatistic
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estatistic>>> GetEstatistic()
        {
            return await _context.Estatistic.ToListAsync();
        }

        // GET: api/Estatistic/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Estatistic>> GetEstatistic(short id)
        {
            var estatistic = await _context.Estatistic.FindAsync(id);

            if (estatistic == null)
            {
                return NotFound();
            }

            return estatistic;
        }

        // PUT: api/Estatistic/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstatistic(short id, Estatistic estatistic)
        {
            if (id != estatistic.EstatisticId)
            {
                return BadRequest();
            }

            _context.Entry(estatistic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstatisticExists(id))
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

        // POST: api/Estatistic
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Estatistic>> PostEstatistic(Estatistic estatistic)
        {
            _context.Estatistic.Add(estatistic);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EstatisticExists(estatistic.EstatisticId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEstatistic", new { id = estatistic.EstatisticId }, estatistic);
        }

        // DELETE: api/Estatistic/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Estatistic>> DeleteEstatistic(short id)
        {
            var estatistic = await _context.Estatistic.FindAsync(id);
            if (estatistic == null)
            {
                return NotFound();
            }

            _context.Estatistic.Remove(estatistic);
            await _context.SaveChangesAsync();

            return estatistic;
        }

        private bool EstatisticExists(short id)
        {
            return _context.Estatistic.Any(e => e.EstatisticId == id);
        }
    }
}
