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
    public class TgearController : ControllerBase
    {
        private readonly DBContext _context;

        public TgearController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tgear
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tgear>>> GetTgear()
        {
            return await _context.Tgear.ToListAsync();
        }

        // GET: api/Tgear/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tgear>> GetTgear(long id)
        {
            var tgear = await _context.Tgear.FindAsync(id);

            if (tgear == null)
            {
                return NotFound();
            }

            return tgear;
        }

        // PUT: api/Tgear/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTgear(long id, Tgear tgear)
        {
            if (id != tgear.TgearId)
            {
                return BadRequest();
            }

            _context.Entry(tgear).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TgearExists(id))
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

        // POST: api/Tgear
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tgear>> PostTgear(Tgear tgear)
        {
            _context.Tgear.Add(tgear);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TgearExists(tgear.TgearId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTgear", new { id = tgear.TgearId }, tgear);
        }

        // DELETE: api/Tgear/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tgear>> DeleteTgear(long id)
        {
            var tgear = await _context.Tgear.FindAsync(id);
            if (tgear == null)
            {
                return NotFound();
            }

            _context.Tgear.Remove(tgear);
            await _context.SaveChangesAsync();

            return tgear;
        }

        private bool TgearExists(long id)
        {
            return _context.Tgear.Any(e => e.TgearId == id);
        }
    }
}
