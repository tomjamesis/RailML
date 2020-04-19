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
    public class EgaugeChangesController : ControllerBase
    {
        private readonly DBContext _context;

        public EgaugeChangesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EgaugeChanges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EgaugeChanges>>> GetEgaugeChanges()
        {
            return await _context.EgaugeChanges.ToListAsync();
        }

        // GET: api/EgaugeChanges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EgaugeChanges>> GetEgaugeChanges(long id)
        {
            var egaugeChanges = await _context.EgaugeChanges.FindAsync(id);

            if (egaugeChanges == null)
            {
                return NotFound();
            }

            return egaugeChanges;
        }

        // PUT: api/EgaugeChanges/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEgaugeChanges(long id, EgaugeChanges egaugeChanges)
        {
            if (id != egaugeChanges.EgaugeChangesId)
            {
                return BadRequest();
            }

            _context.Entry(egaugeChanges).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EgaugeChangesExists(id))
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

        // POST: api/EgaugeChanges
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EgaugeChanges>> PostEgaugeChanges(EgaugeChanges egaugeChanges)
        {
            _context.EgaugeChanges.Add(egaugeChanges);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EgaugeChangesExists(egaugeChanges.EgaugeChangesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEgaugeChanges", new { id = egaugeChanges.EgaugeChangesId }, egaugeChanges);
        }

        // DELETE: api/EgaugeChanges/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EgaugeChanges>> DeleteEgaugeChanges(long id)
        {
            var egaugeChanges = await _context.EgaugeChanges.FindAsync(id);
            if (egaugeChanges == null)
            {
                return NotFound();
            }

            _context.EgaugeChanges.Remove(egaugeChanges);
            await _context.SaveChangesAsync();

            return egaugeChanges;
        }

        private bool EgaugeChangesExists(long id)
        {
            return _context.EgaugeChanges.Any(e => e.EgaugeChangesId == id);
        }
    }
}
