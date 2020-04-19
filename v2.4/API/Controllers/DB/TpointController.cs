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
    public class TpointController : ControllerBase
    {
        private readonly DBContext _context;

        public TpointController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tpoint
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tpoint>>> GetTpoint()
        {
            return await _context.Tpoint.ToListAsync();
        }

        // GET: api/Tpoint/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tpoint>> GetTpoint(long id)
        {
            var tpoint = await _context.Tpoint.FindAsync(id);

            if (tpoint == null)
            {
                return NotFound();
            }

            return tpoint;
        }

        // PUT: api/Tpoint/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTpoint(long id, Tpoint tpoint)
        {
            if (id != tpoint.TpointId)
            {
                return BadRequest();
            }

            _context.Entry(tpoint).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TpointExists(id))
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

        // POST: api/Tpoint
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tpoint>> PostTpoint(Tpoint tpoint)
        {
            _context.Tpoint.Add(tpoint);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TpointExists(tpoint.TpointId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTpoint", new { id = tpoint.TpointId }, tpoint);
        }

        // DELETE: api/Tpoint/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tpoint>> DeleteTpoint(long id)
        {
            var tpoint = await _context.Tpoint.FindAsync(id);
            if (tpoint == null)
            {
                return NotFound();
            }

            _context.Tpoint.Remove(tpoint);
            await _context.SaveChangesAsync();

            return tpoint;
        }

        private bool TpointExists(long id)
        {
            return _context.Tpoint.Any(e => e.TpointId == id);
        }
    }
}
