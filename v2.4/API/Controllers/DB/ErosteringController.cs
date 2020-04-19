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
    public class ErosteringController : ControllerBase
    {
        private readonly DBContext _context;

        public ErosteringController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Erostering
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Erostering>>> GetErostering()
        {
            return await _context.Erostering.ToListAsync();
        }

        // GET: api/Erostering/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Erostering>> GetErostering(short id)
        {
            var erostering = await _context.Erostering.FindAsync(id);

            if (erostering == null)
            {
                return NotFound();
            }

            return erostering;
        }

        // PUT: api/Erostering/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutErostering(short id, Erostering erostering)
        {
            if (id != erostering.ErosteringId)
            {
                return BadRequest();
            }

            _context.Entry(erostering).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ErosteringExists(id))
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

        // POST: api/Erostering
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Erostering>> PostErostering(Erostering erostering)
        {
            _context.Erostering.Add(erostering);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ErosteringExists(erostering.ErosteringId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetErostering", new { id = erostering.ErosteringId }, erostering);
        }

        // DELETE: api/Erostering/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Erostering>> DeleteErostering(short id)
        {
            var erostering = await _context.Erostering.FindAsync(id);
            if (erostering == null)
            {
                return NotFound();
            }

            _context.Erostering.Remove(erostering);
            await _context.SaveChangesAsync();

            return erostering;
        }

        private bool ErosteringExists(short id)
        {
            return _context.Erostering.Any(e => e.ErosteringId == id);
        }
    }
}
