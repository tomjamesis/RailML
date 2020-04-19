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
    public class TderailerController : ControllerBase
    {
        private readonly DBContext _context;

        public TderailerController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tderailer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tderailer>>> GetTderailer()
        {
            return await _context.Tderailer.ToListAsync();
        }

        // GET: api/Tderailer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tderailer>> GetTderailer(short id)
        {
            var tderailer = await _context.Tderailer.FindAsync(id);

            if (tderailer == null)
            {
                return NotFound();
            }

            return tderailer;
        }

        // PUT: api/Tderailer/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTderailer(short id, Tderailer tderailer)
        {
            if (id != tderailer.TderailerId)
            {
                return BadRequest();
            }

            _context.Entry(tderailer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TderailerExists(id))
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

        // POST: api/Tderailer
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tderailer>> PostTderailer(Tderailer tderailer)
        {
            _context.Tderailer.Add(tderailer);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TderailerExists(tderailer.TderailerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTderailer", new { id = tderailer.TderailerId }, tderailer);
        }

        // DELETE: api/Tderailer/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tderailer>> DeleteTderailer(short id)
        {
            var tderailer = await _context.Tderailer.FindAsync(id);
            if (tderailer == null)
            {
                return NotFound();
            }

            _context.Tderailer.Remove(tderailer);
            await _context.SaveChangesAsync();

            return tderailer;
        }

        private bool TderailerExists(short id)
        {
            return _context.Tderailer.Any(e => e.TderailerId == id);
        }
    }
}
