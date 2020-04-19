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
    public class TswitchController : ControllerBase
    {
        private readonly DBContext _context;

        public TswitchController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tswitch
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tswitch>>> GetTswitch()
        {
            return await _context.Tswitch.ToListAsync();
        }

        // GET: api/Tswitch/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tswitch>> GetTswitch(short id)
        {
            var tswitch = await _context.Tswitch.FindAsync(id);

            if (tswitch == null)
            {
                return NotFound();
            }

            return tswitch;
        }

        // PUT: api/Tswitch/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTswitch(short id, Tswitch tswitch)
        {
            if (id != tswitch.TswitchId)
            {
                return BadRequest();
            }

            _context.Entry(tswitch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TswitchExists(id))
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

        // POST: api/Tswitch
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tswitch>> PostTswitch(Tswitch tswitch)
        {
            _context.Tswitch.Add(tswitch);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TswitchExists(tswitch.TswitchId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTswitch", new { id = tswitch.TswitchId }, tswitch);
        }

        // DELETE: api/Tswitch/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tswitch>> DeleteTswitch(short id)
        {
            var tswitch = await _context.Tswitch.FindAsync(id);
            if (tswitch == null)
            {
                return NotFound();
            }

            _context.Tswitch.Remove(tswitch);
            await _context.SaveChangesAsync();

            return tswitch;
        }

        private bool TswitchExists(short id)
        {
            return _context.Tswitch.Any(e => e.TswitchId == id);
        }
    }
}
