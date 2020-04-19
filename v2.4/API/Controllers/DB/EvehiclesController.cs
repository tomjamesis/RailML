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
    public class EvehiclesController : ControllerBase
    {
        private readonly DBContext _context;

        public EvehiclesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Evehicles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Evehicles>>> GetEvehicles()
        {
            return await _context.Evehicles.ToListAsync();
        }

        // GET: api/Evehicles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Evehicles>> GetEvehicles(long id)
        {
            var evehicles = await _context.Evehicles.FindAsync(id);

            if (evehicles == null)
            {
                return NotFound();
            }

            return evehicles;
        }

        // PUT: api/Evehicles/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvehicles(long id, Evehicles evehicles)
        {
            if (id != evehicles.EvehiclesId)
            {
                return BadRequest();
            }

            _context.Entry(evehicles).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EvehiclesExists(id))
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

        // POST: api/Evehicles
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Evehicles>> PostEvehicles(Evehicles evehicles)
        {
            _context.Evehicles.Add(evehicles);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EvehiclesExists(evehicles.EvehiclesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEvehicles", new { id = evehicles.EvehiclesId }, evehicles);
        }

        // DELETE: api/Evehicles/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Evehicles>> DeleteEvehicles(long id)
        {
            var evehicles = await _context.Evehicles.FindAsync(id);
            if (evehicles == null)
            {
                return NotFound();
            }

            _context.Evehicles.Remove(evehicles);
            await _context.SaveChangesAsync();

            return evehicles;
        }

        private bool EvehiclesExists(long id)
        {
            return _context.Evehicles.Any(e => e.EvehiclesId == id);
        }
    }
}
