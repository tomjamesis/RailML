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
    public class TclearanceGaugeChangeController : ControllerBase
    {
        private readonly DBContext _context;

        public TclearanceGaugeChangeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TclearanceGaugeChange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TclearanceGaugeChange>>> GetTclearanceGaugeChange()
        {
            return await _context.TclearanceGaugeChange.ToListAsync();
        }

        // GET: api/TclearanceGaugeChange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TclearanceGaugeChange>> GetTclearanceGaugeChange(short id)
        {
            var tclearanceGaugeChange = await _context.TclearanceGaugeChange.FindAsync(id);

            if (tclearanceGaugeChange == null)
            {
                return NotFound();
            }

            return tclearanceGaugeChange;
        }

        // PUT: api/TclearanceGaugeChange/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTclearanceGaugeChange(short id, TclearanceGaugeChange tclearanceGaugeChange)
        {
            if (id != tclearanceGaugeChange.TclearanceGaugeChangeId)
            {
                return BadRequest();
            }

            _context.Entry(tclearanceGaugeChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TclearanceGaugeChangeExists(id))
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

        // POST: api/TclearanceGaugeChange
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TclearanceGaugeChange>> PostTclearanceGaugeChange(TclearanceGaugeChange tclearanceGaugeChange)
        {
            _context.TclearanceGaugeChange.Add(tclearanceGaugeChange);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TclearanceGaugeChangeExists(tclearanceGaugeChange.TclearanceGaugeChangeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTclearanceGaugeChange", new { id = tclearanceGaugeChange.TclearanceGaugeChangeId }, tclearanceGaugeChange);
        }

        // DELETE: api/TclearanceGaugeChange/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TclearanceGaugeChange>> DeleteTclearanceGaugeChange(short id)
        {
            var tclearanceGaugeChange = await _context.TclearanceGaugeChange.FindAsync(id);
            if (tclearanceGaugeChange == null)
            {
                return NotFound();
            }

            _context.TclearanceGaugeChange.Remove(tclearanceGaugeChange);
            await _context.SaveChangesAsync();

            return tclearanceGaugeChange;
        }

        private bool TclearanceGaugeChangeExists(short id)
        {
            return _context.TclearanceGaugeChange.Any(e => e.TclearanceGaugeChangeId == id);
        }
    }
}
