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
    public class TbrakingController : ControllerBase
    {
        private readonly DBContext _context;

        public TbrakingController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tbraking
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tbraking>>> GetTbraking()
        {
            return await _context.Tbraking.ToListAsync();
        }

        // GET: api/Tbraking/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tbraking>> GetTbraking(long id)
        {
            var tbraking = await _context.Tbraking.FindAsync(id);

            if (tbraking == null)
            {
                return NotFound();
            }

            return tbraking;
        }

        // PUT: api/Tbraking/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbraking(long id, Tbraking tbraking)
        {
            if (id != tbraking.TbrakingId)
            {
                return BadRequest();
            }

            _context.Entry(tbraking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbrakingExists(id))
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

        // POST: api/Tbraking
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tbraking>> PostTbraking(Tbraking tbraking)
        {
            _context.Tbraking.Add(tbraking);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbrakingExists(tbraking.TbrakingId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbraking", new { id = tbraking.TbrakingId }, tbraking);
        }

        // DELETE: api/Tbraking/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tbraking>> DeleteTbraking(long id)
        {
            var tbraking = await _context.Tbraking.FindAsync(id);
            if (tbraking == null)
            {
                return NotFound();
            }

            _context.Tbraking.Remove(tbraking);
            await _context.SaveChangesAsync();

            return tbraking;
        }

        private bool TbrakingExists(long id)
        {
            return _context.Tbraking.Any(e => e.TbrakingId == id);
        }
    }
}
