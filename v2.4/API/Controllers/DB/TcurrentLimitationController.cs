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
    public class TcurrentLimitationController : ControllerBase
    {
        private readonly DBContext _context;

        public TcurrentLimitationController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TcurrentLimitation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TcurrentLimitation>>> GetTcurrentLimitation()
        {
            return await _context.TcurrentLimitation.ToListAsync();
        }

        // GET: api/TcurrentLimitation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TcurrentLimitation>> GetTcurrentLimitation(short id)
        {
            var tcurrentLimitation = await _context.TcurrentLimitation.FindAsync(id);

            if (tcurrentLimitation == null)
            {
                return NotFound();
            }

            return tcurrentLimitation;
        }

        // PUT: api/TcurrentLimitation/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTcurrentLimitation(short id, TcurrentLimitation tcurrentLimitation)
        {
            if (id != tcurrentLimitation.TcurrentLimitationId)
            {
                return BadRequest();
            }

            _context.Entry(tcurrentLimitation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TcurrentLimitationExists(id))
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

        // POST: api/TcurrentLimitation
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TcurrentLimitation>> PostTcurrentLimitation(TcurrentLimitation tcurrentLimitation)
        {
            _context.TcurrentLimitation.Add(tcurrentLimitation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TcurrentLimitationExists(tcurrentLimitation.TcurrentLimitationId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTcurrentLimitation", new { id = tcurrentLimitation.TcurrentLimitationId }, tcurrentLimitation);
        }

        // DELETE: api/TcurrentLimitation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TcurrentLimitation>> DeleteTcurrentLimitation(short id)
        {
            var tcurrentLimitation = await _context.TcurrentLimitation.FindAsync(id);
            if (tcurrentLimitation == null)
            {
                return NotFound();
            }

            _context.TcurrentLimitation.Remove(tcurrentLimitation);
            await _context.SaveChangesAsync();

            return tcurrentLimitation;
        }

        private bool TcurrentLimitationExists(short id)
        {
            return _context.TcurrentLimitation.Any(e => e.TcurrentLimitationId == id);
        }
    }
}
