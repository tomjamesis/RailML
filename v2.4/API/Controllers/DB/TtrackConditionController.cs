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
    public class TtrackConditionController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrackConditionController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrackCondition
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrackCondition>>> GetTtrackCondition()
        {
            return await _context.TtrackCondition.ToListAsync();
        }

        // GET: api/TtrackCondition/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrackCondition>> GetTtrackCondition(short id)
        {
            var ttrackCondition = await _context.TtrackCondition.FindAsync(id);

            if (ttrackCondition == null)
            {
                return NotFound();
            }

            return ttrackCondition;
        }

        // PUT: api/TtrackCondition/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrackCondition(short id, TtrackCondition ttrackCondition)
        {
            if (id != ttrackCondition.TtrackConditionId)
            {
                return BadRequest();
            }

            _context.Entry(ttrackCondition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrackConditionExists(id))
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

        // POST: api/TtrackCondition
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrackCondition>> PostTtrackCondition(TtrackCondition ttrackCondition)
        {
            _context.TtrackCondition.Add(ttrackCondition);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrackConditionExists(ttrackCondition.TtrackConditionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrackCondition", new { id = ttrackCondition.TtrackConditionId }, ttrackCondition);
        }

        // DELETE: api/TtrackCondition/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrackCondition>> DeleteTtrackCondition(short id)
        {
            var ttrackCondition = await _context.TtrackCondition.FindAsync(id);
            if (ttrackCondition == null)
            {
                return NotFound();
            }

            _context.TtrackCondition.Remove(ttrackCondition);
            await _context.SaveChangesAsync();

            return ttrackCondition;
        }

        private bool TtrackConditionExists(short id)
        {
            return _context.TtrackCondition.Any(e => e.TtrackConditionId == id);
        }
    }
}
