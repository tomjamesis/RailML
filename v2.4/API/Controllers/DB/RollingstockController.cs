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
    public class RollingstockController : ControllerBase
    {
        private readonly DBContext _context;

        public RollingstockController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Rollingstock
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rollingstock>>> GetRollingstock()
        {
            return await _context.Rollingstock.ToListAsync();
        }

        // GET: api/Rollingstock/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rollingstock>> GetRollingstock(short id)
        {
            var rollingstock = await _context.Rollingstock.FindAsync(id);

            if (rollingstock == null)
            {
                return NotFound();
            }

            return rollingstock;
        }

        // PUT: api/Rollingstock/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRollingstock(short id, Rollingstock rollingstock)
        {
            if (id != rollingstock.RollingstockId)
            {
                return BadRequest();
            }

            _context.Entry(rollingstock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RollingstockExists(id))
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

        // POST: api/Rollingstock
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Rollingstock>> PostRollingstock(Rollingstock rollingstock)
        {
            _context.Rollingstock.Add(rollingstock);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RollingstockExists(rollingstock.RollingstockId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRollingstock", new { id = rollingstock.RollingstockId }, rollingstock);
        }

        // DELETE: api/Rollingstock/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Rollingstock>> DeleteRollingstock(short id)
        {
            var rollingstock = await _context.Rollingstock.FindAsync(id);
            if (rollingstock == null)
            {
                return NotFound();
            }

            _context.Rollingstock.Remove(rollingstock);
            await _context.SaveChangesAsync();

            return rollingstock;
        }

        private bool RollingstockExists(short id)
        {
            return _context.Rollingstock.Any(e => e.RollingstockId == id);
        }
    }
}
