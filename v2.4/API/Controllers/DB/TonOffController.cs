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
    public class TonOffController : ControllerBase
    {
        private readonly DBContext _context;

        public TonOffController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TonOff
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TonOff>>> GetTonOff()
        {
            return await _context.TonOff.ToListAsync();
        }

        // GET: api/TonOff/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TonOff>> GetTonOff(byte id)
        {
            var tonOff = await _context.TonOff.FindAsync(id);

            if (tonOff == null)
            {
                return NotFound();
            }

            return tonOff;
        }

        // PUT: api/TonOff/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTonOff(byte id, TonOff tonOff)
        {
            if (id != tonOff.TonOffId)
            {
                return BadRequest();
            }

            _context.Entry(tonOff).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TonOffExists(id))
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

        // POST: api/TonOff
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TonOff>> PostTonOff(TonOff tonOff)
        {
            _context.TonOff.Add(tonOff);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TonOffExists(tonOff.TonOffId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTonOff", new { id = tonOff.TonOffId }, tonOff);
        }

        // DELETE: api/TonOff/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TonOff>> DeleteTonOff(byte id)
        {
            var tonOff = await _context.TonOff.FindAsync(id);
            if (tonOff == null)
            {
                return NotFound();
            }

            _context.TonOff.Remove(tonOff);
            await _context.SaveChangesAsync();

            return tonOff;
        }

        private bool TonOffExists(byte id)
        {
            return _context.TonOff.Any(e => e.TonOffId == id);
        }
    }
}
