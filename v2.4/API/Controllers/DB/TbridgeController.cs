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
    public class TbridgeController : ControllerBase
    {
        private readonly DBContext _context;

        public TbridgeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tbridge
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tbridge>>> GetTbridge()
        {
            return await _context.Tbridge.ToListAsync();
        }

        // GET: api/Tbridge/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tbridge>> GetTbridge(short id)
        {
            var tbridge = await _context.Tbridge.FindAsync(id);

            if (tbridge == null)
            {
                return NotFound();
            }

            return tbridge;
        }

        // PUT: api/Tbridge/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbridge(short id, Tbridge tbridge)
        {
            if (id != tbridge.TbridgeId)
            {
                return BadRequest();
            }

            _context.Entry(tbridge).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbridgeExists(id))
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

        // POST: api/Tbridge
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tbridge>> PostTbridge(Tbridge tbridge)
        {
            _context.Tbridge.Add(tbridge);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbridgeExists(tbridge.TbridgeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbridge", new { id = tbridge.TbridgeId }, tbridge);
        }

        // DELETE: api/Tbridge/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tbridge>> DeleteTbridge(short id)
        {
            var tbridge = await _context.Tbridge.FindAsync(id);
            if (tbridge == null)
            {
                return NotFound();
            }

            _context.Tbridge.Remove(tbridge);
            await _context.SaveChangesAsync();

            return tbridge;
        }

        private bool TbridgeExists(short id)
        {
            return _context.Tbridge.Any(e => e.TbridgeId == id);
        }
    }
}
