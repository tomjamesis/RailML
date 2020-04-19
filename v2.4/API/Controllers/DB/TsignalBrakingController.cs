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
    public class TsignalBrakingController : ControllerBase
    {
        private readonly DBContext _context;

        public TsignalBrakingController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TsignalBraking
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TsignalBraking>>> GetTsignalBraking()
        {
            return await _context.TsignalBraking.ToListAsync();
        }

        // GET: api/TsignalBraking/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TsignalBraking>> GetTsignalBraking(short id)
        {
            var tsignalBraking = await _context.TsignalBraking.FindAsync(id);

            if (tsignalBraking == null)
            {
                return NotFound();
            }

            return tsignalBraking;
        }

        // PUT: api/TsignalBraking/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTsignalBraking(short id, TsignalBraking tsignalBraking)
        {
            if (id != tsignalBraking.TsignalBrakingId)
            {
                return BadRequest();
            }

            _context.Entry(tsignalBraking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TsignalBrakingExists(id))
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

        // POST: api/TsignalBraking
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TsignalBraking>> PostTsignalBraking(TsignalBraking tsignalBraking)
        {
            _context.TsignalBraking.Add(tsignalBraking);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TsignalBrakingExists(tsignalBraking.TsignalBrakingId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTsignalBraking", new { id = tsignalBraking.TsignalBrakingId }, tsignalBraking);
        }

        // DELETE: api/TsignalBraking/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TsignalBraking>> DeleteTsignalBraking(short id)
        {
            var tsignalBraking = await _context.TsignalBraking.FindAsync(id);
            if (tsignalBraking == null)
            {
                return NotFound();
            }

            _context.TsignalBraking.Remove(tsignalBraking);
            await _context.SaveChangesAsync();

            return tsignalBraking;
        }

        private bool TsignalBrakingExists(short id)
        {
            return _context.TsignalBraking.Any(e => e.TsignalBrakingId == id);
        }
    }
}
