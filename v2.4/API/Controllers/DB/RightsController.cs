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
    public class RightsController : ControllerBase
    {
        private readonly DBContext _context;

        public RightsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Rights
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rights>>> GetRights()
        {
            return await _context.Rights.ToListAsync();
        }

        // GET: api/Rights/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rights>> GetRights(short id)
        {
            var rights = await _context.Rights.FindAsync(id);

            if (rights == null)
            {
                return NotFound();
            }

            return rights;
        }

        // PUT: api/Rights/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRights(short id, Rights rights)
        {
            if (id != rights.RightsId)
            {
                return BadRequest();
            }

            _context.Entry(rights).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RightsExists(id))
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

        // POST: api/Rights
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Rights>> PostRights(Rights rights)
        {
            _context.Rights.Add(rights);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RightsExists(rights.RightsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRights", new { id = rights.RightsId }, rights);
        }

        // DELETE: api/Rights/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Rights>> DeleteRights(short id)
        {
            var rights = await _context.Rights.FindAsync(id);
            if (rights == null)
            {
                return NotFound();
            }

            _context.Rights.Remove(rights);
            await _context.SaveChangesAsync();

            return rights;
        }

        private bool RightsExists(short id)
        {
            return _context.Rights.Any(e => e.RightsId == id);
        }
    }
}
