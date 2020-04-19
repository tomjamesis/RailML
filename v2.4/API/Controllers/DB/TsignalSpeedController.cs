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
    public class TsignalSpeedController : ControllerBase
    {
        private readonly DBContext _context;

        public TsignalSpeedController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TsignalSpeed
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TsignalSpeed>>> GetTsignalSpeed()
        {
            return await _context.TsignalSpeed.ToListAsync();
        }

        // GET: api/TsignalSpeed/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TsignalSpeed>> GetTsignalSpeed(short id)
        {
            var tsignalSpeed = await _context.TsignalSpeed.FindAsync(id);

            if (tsignalSpeed == null)
            {
                return NotFound();
            }

            return tsignalSpeed;
        }

        // PUT: api/TsignalSpeed/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTsignalSpeed(short id, TsignalSpeed tsignalSpeed)
        {
            if (id != tsignalSpeed.TsignalSpeedId)
            {
                return BadRequest();
            }

            _context.Entry(tsignalSpeed).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TsignalSpeedExists(id))
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

        // POST: api/TsignalSpeed
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TsignalSpeed>> PostTsignalSpeed(TsignalSpeed tsignalSpeed)
        {
            _context.TsignalSpeed.Add(tsignalSpeed);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TsignalSpeedExists(tsignalSpeed.TsignalSpeedId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTsignalSpeed", new { id = tsignalSpeed.TsignalSpeedId }, tsignalSpeed);
        }

        // DELETE: api/TsignalSpeed/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TsignalSpeed>> DeleteTsignalSpeed(short id)
        {
            var tsignalSpeed = await _context.TsignalSpeed.FindAsync(id);
            if (tsignalSpeed == null)
            {
                return NotFound();
            }

            _context.TsignalSpeed.Remove(tsignalSpeed);
            await _context.SaveChangesAsync();

            return tsignalSpeed;
        }

        private bool TsignalSpeedExists(short id)
        {
            return _context.TsignalSpeed.Any(e => e.TsignalSpeedId == id);
        }
    }
}
