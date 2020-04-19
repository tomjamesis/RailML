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
    public class TelectrificationController : ControllerBase
    {
        private readonly DBContext _context;

        public TelectrificationController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Telectrification
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Telectrification>>> GetTelectrification()
        {
            return await _context.Telectrification.ToListAsync();
        }

        // GET: api/Telectrification/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Telectrification>> GetTelectrification(long id)
        {
            var telectrification = await _context.Telectrification.FindAsync(id);

            if (telectrification == null)
            {
                return NotFound();
            }

            return telectrification;
        }

        // PUT: api/Telectrification/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTelectrification(long id, Telectrification telectrification)
        {
            if (id != telectrification.TelectrificationId)
            {
                return BadRequest();
            }

            _context.Entry(telectrification).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TelectrificationExists(id))
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

        // POST: api/Telectrification
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Telectrification>> PostTelectrification(Telectrification telectrification)
        {
            _context.Telectrification.Add(telectrification);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TelectrificationExists(telectrification.TelectrificationId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTelectrification", new { id = telectrification.TelectrificationId }, telectrification);
        }

        // DELETE: api/Telectrification/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Telectrification>> DeleteTelectrification(long id)
        {
            var telectrification = await _context.Telectrification.FindAsync(id);
            if (telectrification == null)
            {
                return NotFound();
            }

            _context.Telectrification.Remove(telectrification);
            await _context.SaveChangesAsync();

            return telectrification;
        }

        private bool TelectrificationExists(long id)
        {
            return _context.Telectrification.Any(e => e.TelectrificationId == id);
        }
    }
}
