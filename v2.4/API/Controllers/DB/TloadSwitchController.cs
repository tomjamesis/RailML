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
    public class TloadSwitchController : ControllerBase
    {
        private readonly DBContext _context;

        public TloadSwitchController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TloadSwitch
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TloadSwitch>>> GetTloadSwitch()
        {
            return await _context.TloadSwitch.ToListAsync();
        }

        // GET: api/TloadSwitch/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TloadSwitch>> GetTloadSwitch(byte id)
        {
            var tloadSwitch = await _context.TloadSwitch.FindAsync(id);

            if (tloadSwitch == null)
            {
                return NotFound();
            }

            return tloadSwitch;
        }

        // PUT: api/TloadSwitch/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTloadSwitch(byte id, TloadSwitch tloadSwitch)
        {
            if (id != tloadSwitch.TloadSwitchId)
            {
                return BadRequest();
            }

            _context.Entry(tloadSwitch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TloadSwitchExists(id))
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

        // POST: api/TloadSwitch
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TloadSwitch>> PostTloadSwitch(TloadSwitch tloadSwitch)
        {
            _context.TloadSwitch.Add(tloadSwitch);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TloadSwitchExists(tloadSwitch.TloadSwitchId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTloadSwitch", new { id = tloadSwitch.TloadSwitchId }, tloadSwitch);
        }

        // DELETE: api/TloadSwitch/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TloadSwitch>> DeleteTloadSwitch(byte id)
        {
            var tloadSwitch = await _context.TloadSwitch.FindAsync(id);
            if (tloadSwitch == null)
            {
                return NotFound();
            }

            _context.TloadSwitch.Remove(tloadSwitch);
            await _context.SaveChangesAsync();

            return tloadSwitch;
        }

        private bool TloadSwitchExists(byte id)
        {
            return _context.TloadSwitch.Any(e => e.TloadSwitchId == id);
        }
    }
}
