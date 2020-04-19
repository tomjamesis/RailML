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
    public class TinfrastructureManagerController : ControllerBase
    {
        private readonly DBContext _context;

        public TinfrastructureManagerController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TinfrastructureManager
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TinfrastructureManager>>> GetTinfrastructureManager()
        {
            return await _context.TinfrastructureManager.ToListAsync();
        }

        // GET: api/TinfrastructureManager/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TinfrastructureManager>> GetTinfrastructureManager(short id)
        {
            var tinfrastructureManager = await _context.TinfrastructureManager.FindAsync(id);

            if (tinfrastructureManager == null)
            {
                return NotFound();
            }

            return tinfrastructureManager;
        }

        // PUT: api/TinfrastructureManager/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTinfrastructureManager(short id, TinfrastructureManager tinfrastructureManager)
        {
            if (id != tinfrastructureManager.TinfrastructureManagerId)
            {
                return BadRequest();
            }

            _context.Entry(tinfrastructureManager).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TinfrastructureManagerExists(id))
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

        // POST: api/TinfrastructureManager
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TinfrastructureManager>> PostTinfrastructureManager(TinfrastructureManager tinfrastructureManager)
        {
            _context.TinfrastructureManager.Add(tinfrastructureManager);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TinfrastructureManagerExists(tinfrastructureManager.TinfrastructureManagerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTinfrastructureManager", new { id = tinfrastructureManager.TinfrastructureManagerId }, tinfrastructureManager);
        }

        // DELETE: api/TinfrastructureManager/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TinfrastructureManager>> DeleteTinfrastructureManager(short id)
        {
            var tinfrastructureManager = await _context.TinfrastructureManager.FindAsync(id);
            if (tinfrastructureManager == null)
            {
                return NotFound();
            }

            _context.TinfrastructureManager.Remove(tinfrastructureManager);
            await _context.SaveChangesAsync();

            return tinfrastructureManager;
        }

        private bool TinfrastructureManagerExists(short id)
        {
            return _context.TinfrastructureManager.Any(e => e.TinfrastructureManagerId == id);
        }
    }
}
