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
    public class TmaxTrainCurrentValidForController : ControllerBase
    {
        private readonly DBContext _context;

        public TmaxTrainCurrentValidForController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TmaxTrainCurrentValidFor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TmaxTrainCurrentValidFor>>> GetTmaxTrainCurrentValidFor()
        {
            return await _context.TmaxTrainCurrentValidFor.ToListAsync();
        }

        // GET: api/TmaxTrainCurrentValidFor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TmaxTrainCurrentValidFor>> GetTmaxTrainCurrentValidFor(byte id)
        {
            var tmaxTrainCurrentValidFor = await _context.TmaxTrainCurrentValidFor.FindAsync(id);

            if (tmaxTrainCurrentValidFor == null)
            {
                return NotFound();
            }

            return tmaxTrainCurrentValidFor;
        }

        // PUT: api/TmaxTrainCurrentValidFor/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTmaxTrainCurrentValidFor(byte id, TmaxTrainCurrentValidFor tmaxTrainCurrentValidFor)
        {
            if (id != tmaxTrainCurrentValidFor.TmaxTrainCurrentValidForId)
            {
                return BadRequest();
            }

            _context.Entry(tmaxTrainCurrentValidFor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TmaxTrainCurrentValidForExists(id))
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

        // POST: api/TmaxTrainCurrentValidFor
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TmaxTrainCurrentValidFor>> PostTmaxTrainCurrentValidFor(TmaxTrainCurrentValidFor tmaxTrainCurrentValidFor)
        {
            _context.TmaxTrainCurrentValidFor.Add(tmaxTrainCurrentValidFor);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TmaxTrainCurrentValidForExists(tmaxTrainCurrentValidFor.TmaxTrainCurrentValidForId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTmaxTrainCurrentValidFor", new { id = tmaxTrainCurrentValidFor.TmaxTrainCurrentValidForId }, tmaxTrainCurrentValidFor);
        }

        // DELETE: api/TmaxTrainCurrentValidFor/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TmaxTrainCurrentValidFor>> DeleteTmaxTrainCurrentValidFor(byte id)
        {
            var tmaxTrainCurrentValidFor = await _context.TmaxTrainCurrentValidFor.FindAsync(id);
            if (tmaxTrainCurrentValidFor == null)
            {
                return NotFound();
            }

            _context.TmaxTrainCurrentValidFor.Remove(tmaxTrainCurrentValidFor);
            await _context.SaveChangesAsync();

            return tmaxTrainCurrentValidFor;
        }

        private bool TmaxTrainCurrentValidForExists(byte id)
        {
            return _context.TmaxTrainCurrentValidFor.Any(e => e.TmaxTrainCurrentValidForId == id);
        }
    }
}
