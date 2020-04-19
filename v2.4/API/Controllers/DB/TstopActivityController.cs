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
    public class TstopActivityController : ControllerBase
    {
        private readonly DBContext _context;

        public TstopActivityController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TstopActivity
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TstopActivity>>> GetTstopActivity()
        {
            return await _context.TstopActivity.ToListAsync();
        }

        // GET: api/TstopActivity/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TstopActivity>> GetTstopActivity(long id)
        {
            var tstopActivity = await _context.TstopActivity.FindAsync(id);

            if (tstopActivity == null)
            {
                return NotFound();
            }

            return tstopActivity;
        }

        // PUT: api/TstopActivity/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTstopActivity(long id, TstopActivity tstopActivity)
        {
            if (id != tstopActivity.TstopActivityId)
            {
                return BadRequest();
            }

            _context.Entry(tstopActivity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TstopActivityExists(id))
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

        // POST: api/TstopActivity
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TstopActivity>> PostTstopActivity(TstopActivity tstopActivity)
        {
            _context.TstopActivity.Add(tstopActivity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TstopActivityExists(tstopActivity.TstopActivityId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTstopActivity", new { id = tstopActivity.TstopActivityId }, tstopActivity);
        }

        // DELETE: api/TstopActivity/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TstopActivity>> DeleteTstopActivity(long id)
        {
            var tstopActivity = await _context.TstopActivity.FindAsync(id);
            if (tstopActivity == null)
            {
                return NotFound();
            }

            _context.TstopActivity.Remove(tstopActivity);
            await _context.SaveChangesAsync();

            return tstopActivity;
        }

        private bool TstopActivityExists(long id)
        {
            return _context.TstopActivity.Any(e => e.TstopActivityId == id);
        }
    }
}
