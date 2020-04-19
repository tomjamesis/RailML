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
    public class TtiltingActuationTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TtiltingActuationTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtiltingActuationType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtiltingActuationType>>> GetTtiltingActuationType()
        {
            return await _context.TtiltingActuationType.ToListAsync();
        }

        // GET: api/TtiltingActuationType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtiltingActuationType>> GetTtiltingActuationType(byte id)
        {
            var ttiltingActuationType = await _context.TtiltingActuationType.FindAsync(id);

            if (ttiltingActuationType == null)
            {
                return NotFound();
            }

            return ttiltingActuationType;
        }

        // PUT: api/TtiltingActuationType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtiltingActuationType(byte id, TtiltingActuationType ttiltingActuationType)
        {
            if (id != ttiltingActuationType.TtiltingActuationTypeId)
            {
                return BadRequest();
            }

            _context.Entry(ttiltingActuationType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtiltingActuationTypeExists(id))
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

        // POST: api/TtiltingActuationType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtiltingActuationType>> PostTtiltingActuationType(TtiltingActuationType ttiltingActuationType)
        {
            _context.TtiltingActuationType.Add(ttiltingActuationType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtiltingActuationTypeExists(ttiltingActuationType.TtiltingActuationTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtiltingActuationType", new { id = ttiltingActuationType.TtiltingActuationTypeId }, ttiltingActuationType);
        }

        // DELETE: api/TtiltingActuationType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtiltingActuationType>> DeleteTtiltingActuationType(byte id)
        {
            var ttiltingActuationType = await _context.TtiltingActuationType.FindAsync(id);
            if (ttiltingActuationType == null)
            {
                return NotFound();
            }

            _context.TtiltingActuationType.Remove(ttiltingActuationType);
            await _context.SaveChangesAsync();

            return ttiltingActuationType;
        }

        private bool TtiltingActuationTypeExists(byte id)
        {
            return _context.TtiltingActuationType.Any(e => e.TtiltingActuationTypeId == id);
        }
    }
}
