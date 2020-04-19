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
    public class ElineController : ControllerBase
    {
        private readonly DBContext _context;

        public ElineController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Eline
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eline>>> GetEline()
        {
            return await _context.Eline.ToListAsync();
        }

        // GET: api/Eline/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eline>> GetEline(short id)
        {
            var eline = await _context.Eline.FindAsync(id);

            if (eline == null)
            {
                return NotFound();
            }

            return eline;
        }

        // PUT: api/Eline/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEline(short id, Eline eline)
        {
            if (id != eline.ElineId)
            {
                return BadRequest();
            }

            _context.Entry(eline).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElineExists(id))
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

        // POST: api/Eline
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eline>> PostEline(Eline eline)
        {
            _context.Eline.Add(eline);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ElineExists(eline.ElineId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEline", new { id = eline.ElineId }, eline);
        }

        // DELETE: api/Eline/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eline>> DeleteEline(short id)
        {
            var eline = await _context.Eline.FindAsync(id);
            if (eline == null)
            {
                return NotFound();
            }

            _context.Eline.Remove(eline);
            await _context.SaveChangesAsync();

            return eline;
        }

        private bool ElineExists(short id)
        {
            return _context.Eline.Any(e => e.ElineId == id);
        }
    }
}
