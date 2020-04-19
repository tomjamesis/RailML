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
    public class EreplacedTrainsController : ControllerBase
    {
        private readonly DBContext _context;

        public EreplacedTrainsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EreplacedTrains
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EreplacedTrains>>> GetEreplacedTrains()
        {
            return await _context.EreplacedTrains.ToListAsync();
        }

        // GET: api/EreplacedTrains/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EreplacedTrains>> GetEreplacedTrains(long id)
        {
            var ereplacedTrains = await _context.EreplacedTrains.FindAsync(id);

            if (ereplacedTrains == null)
            {
                return NotFound();
            }

            return ereplacedTrains;
        }

        // PUT: api/EreplacedTrains/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEreplacedTrains(long id, EreplacedTrains ereplacedTrains)
        {
            if (id != ereplacedTrains.EreplacedTrainsId)
            {
                return BadRequest();
            }

            _context.Entry(ereplacedTrains).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EreplacedTrainsExists(id))
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

        // POST: api/EreplacedTrains
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EreplacedTrains>> PostEreplacedTrains(EreplacedTrains ereplacedTrains)
        {
            _context.EreplacedTrains.Add(ereplacedTrains);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EreplacedTrainsExists(ereplacedTrains.EreplacedTrainsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEreplacedTrains", new { id = ereplacedTrains.EreplacedTrainsId }, ereplacedTrains);
        }

        // DELETE: api/EreplacedTrains/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EreplacedTrains>> DeleteEreplacedTrains(long id)
        {
            var ereplacedTrains = await _context.EreplacedTrains.FindAsync(id);
            if (ereplacedTrains == null)
            {
                return NotFound();
            }

            _context.EreplacedTrains.Remove(ereplacedTrains);
            await _context.SaveChangesAsync();

            return ereplacedTrains;
        }

        private bool EreplacedTrainsExists(long id)
        {
            return _context.EreplacedTrains.Any(e => e.EreplacedTrainsId == id);
        }
    }
}
