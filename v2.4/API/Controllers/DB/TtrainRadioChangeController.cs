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
    public class TtrainRadioChangeController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainRadioChangeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrainRadioChange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrainRadioChange>>> GetTtrainRadioChange()
        {
            return await _context.TtrainRadioChange.ToListAsync();
        }

        // GET: api/TtrainRadioChange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrainRadioChange>> GetTtrainRadioChange(short id)
        {
            var ttrainRadioChange = await _context.TtrainRadioChange.FindAsync(id);

            if (ttrainRadioChange == null)
            {
                return NotFound();
            }

            return ttrainRadioChange;
        }

        // PUT: api/TtrainRadioChange/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrainRadioChange(short id, TtrainRadioChange ttrainRadioChange)
        {
            if (id != ttrainRadioChange.TtrainRadioChangeId)
            {
                return BadRequest();
            }

            _context.Entry(ttrainRadioChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainRadioChangeExists(id))
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

        // POST: api/TtrainRadioChange
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrainRadioChange>> PostTtrainRadioChange(TtrainRadioChange ttrainRadioChange)
        {
            _context.TtrainRadioChange.Add(ttrainRadioChange);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainRadioChangeExists(ttrainRadioChange.TtrainRadioChangeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrainRadioChange", new { id = ttrainRadioChange.TtrainRadioChangeId }, ttrainRadioChange);
        }

        // DELETE: api/TtrainRadioChange/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrainRadioChange>> DeleteTtrainRadioChange(short id)
        {
            var ttrainRadioChange = await _context.TtrainRadioChange.FindAsync(id);
            if (ttrainRadioChange == null)
            {
                return NotFound();
            }

            _context.TtrainRadioChange.Remove(ttrainRadioChange);
            await _context.SaveChangesAsync();

            return ttrainRadioChange;
        }

        private bool TtrainRadioChangeExists(short id)
        {
            return _context.TtrainRadioChange.Any(e => e.TtrainRadioChangeId == id);
        }
    }
}
