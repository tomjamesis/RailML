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
    public class TsignalLevelCrossingController : ControllerBase
    {
        private readonly DBContext _context;

        public TsignalLevelCrossingController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TsignalLevelCrossing
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TsignalLevelCrossing>>> GetTsignalLevelCrossing()
        {
            return await _context.TsignalLevelCrossing.ToListAsync();
        }

        // GET: api/TsignalLevelCrossing/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TsignalLevelCrossing>> GetTsignalLevelCrossing(short id)
        {
            var tsignalLevelCrossing = await _context.TsignalLevelCrossing.FindAsync(id);

            if (tsignalLevelCrossing == null)
            {
                return NotFound();
            }

            return tsignalLevelCrossing;
        }

        // PUT: api/TsignalLevelCrossing/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTsignalLevelCrossing(short id, TsignalLevelCrossing tsignalLevelCrossing)
        {
            if (id != tsignalLevelCrossing.TsignalLevelCrossingId)
            {
                return BadRequest();
            }

            _context.Entry(tsignalLevelCrossing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TsignalLevelCrossingExists(id))
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

        // POST: api/TsignalLevelCrossing
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TsignalLevelCrossing>> PostTsignalLevelCrossing(TsignalLevelCrossing tsignalLevelCrossing)
        {
            _context.TsignalLevelCrossing.Add(tsignalLevelCrossing);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TsignalLevelCrossingExists(tsignalLevelCrossing.TsignalLevelCrossingId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTsignalLevelCrossing", new { id = tsignalLevelCrossing.TsignalLevelCrossingId }, tsignalLevelCrossing);
        }

        // DELETE: api/TsignalLevelCrossing/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TsignalLevelCrossing>> DeleteTsignalLevelCrossing(short id)
        {
            var tsignalLevelCrossing = await _context.TsignalLevelCrossing.FindAsync(id);
            if (tsignalLevelCrossing == null)
            {
                return NotFound();
            }

            _context.TsignalLevelCrossing.Remove(tsignalLevelCrossing);
            await _context.SaveChangesAsync();

            return tsignalLevelCrossing;
        }

        private bool TsignalLevelCrossingExists(short id)
        {
            return _context.TsignalLevelCrossing.Any(e => e.TsignalLevelCrossingId == id);
        }
    }
}
