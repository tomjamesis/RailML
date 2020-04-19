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
    public class TmaxTrainCurrentController : ControllerBase
    {
        private readonly DBContext _context;

        public TmaxTrainCurrentController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TmaxTrainCurrent
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TmaxTrainCurrent>>> GetTmaxTrainCurrent()
        {
            return await _context.TmaxTrainCurrent.ToListAsync();
        }

        // GET: api/TmaxTrainCurrent/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TmaxTrainCurrent>> GetTmaxTrainCurrent(long id)
        {
            var tmaxTrainCurrent = await _context.TmaxTrainCurrent.FindAsync(id);

            if (tmaxTrainCurrent == null)
            {
                return NotFound();
            }

            return tmaxTrainCurrent;
        }

        // PUT: api/TmaxTrainCurrent/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTmaxTrainCurrent(long id, TmaxTrainCurrent tmaxTrainCurrent)
        {
            if (id != tmaxTrainCurrent.TmaxTrainCurrentId)
            {
                return BadRequest();
            }

            _context.Entry(tmaxTrainCurrent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TmaxTrainCurrentExists(id))
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

        // POST: api/TmaxTrainCurrent
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TmaxTrainCurrent>> PostTmaxTrainCurrent(TmaxTrainCurrent tmaxTrainCurrent)
        {
            _context.TmaxTrainCurrent.Add(tmaxTrainCurrent);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TmaxTrainCurrentExists(tmaxTrainCurrent.TmaxTrainCurrentId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTmaxTrainCurrent", new { id = tmaxTrainCurrent.TmaxTrainCurrentId }, tmaxTrainCurrent);
        }

        // DELETE: api/TmaxTrainCurrent/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TmaxTrainCurrent>> DeleteTmaxTrainCurrent(long id)
        {
            var tmaxTrainCurrent = await _context.TmaxTrainCurrent.FindAsync(id);
            if (tmaxTrainCurrent == null)
            {
                return NotFound();
            }

            _context.TmaxTrainCurrent.Remove(tmaxTrainCurrent);
            await _context.SaveChangesAsync();

            return tmaxTrainCurrent;
        }

        private bool TmaxTrainCurrentExists(long id)
        {
            return _context.TmaxTrainCurrent.Any(e => e.TmaxTrainCurrentId == id);
        }
    }
}
