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
    public class TtechnicalStopActivityController : ControllerBase
    {
        private readonly DBContext _context;

        public TtechnicalStopActivityController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtechnicalStopActivity
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtechnicalStopActivity>>> GetTtechnicalStopActivity()
        {
            return await _context.TtechnicalStopActivity.ToListAsync();
        }

        // GET: api/TtechnicalStopActivity/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtechnicalStopActivity>> GetTtechnicalStopActivity(long id)
        {
            var ttechnicalStopActivity = await _context.TtechnicalStopActivity.FindAsync(id);

            if (ttechnicalStopActivity == null)
            {
                return NotFound();
            }

            return ttechnicalStopActivity;
        }

        // PUT: api/TtechnicalStopActivity/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtechnicalStopActivity(long id, TtechnicalStopActivity ttechnicalStopActivity)
        {
            if (id != ttechnicalStopActivity.TtechnicalStopActivityId)
            {
                return BadRequest();
            }

            _context.Entry(ttechnicalStopActivity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtechnicalStopActivityExists(id))
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

        // POST: api/TtechnicalStopActivity
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtechnicalStopActivity>> PostTtechnicalStopActivity(TtechnicalStopActivity ttechnicalStopActivity)
        {
            _context.TtechnicalStopActivity.Add(ttechnicalStopActivity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtechnicalStopActivityExists(ttechnicalStopActivity.TtechnicalStopActivityId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtechnicalStopActivity", new { id = ttechnicalStopActivity.TtechnicalStopActivityId }, ttechnicalStopActivity);
        }

        // DELETE: api/TtechnicalStopActivity/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtechnicalStopActivity>> DeleteTtechnicalStopActivity(long id)
        {
            var ttechnicalStopActivity = await _context.TtechnicalStopActivity.FindAsync(id);
            if (ttechnicalStopActivity == null)
            {
                return NotFound();
            }

            _context.TtechnicalStopActivity.Remove(ttechnicalStopActivity);
            await _context.SaveChangesAsync();

            return ttechnicalStopActivity;
        }

        private bool TtechnicalStopActivityExists(long id)
        {
            return _context.TtechnicalStopActivity.Any(e => e.TtechnicalStopActivityId == id);
        }
    }
}
