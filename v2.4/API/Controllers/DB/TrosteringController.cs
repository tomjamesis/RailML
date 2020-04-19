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
    public class TrosteringController : ControllerBase
    {
        private readonly DBContext _context;

        public TrosteringController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Trostering
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trostering>>> GetTrostering()
        {
            return await _context.Trostering.ToListAsync();
        }

        // GET: api/Trostering/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Trostering>> GetTrostering(short id)
        {
            var trostering = await _context.Trostering.FindAsync(id);

            if (trostering == null)
            {
                return NotFound();
            }

            return trostering;
        }

        // PUT: api/Trostering/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrostering(short id, Trostering trostering)
        {
            if (id != trostering.TrosteringId)
            {
                return BadRequest();
            }

            _context.Entry(trostering).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrosteringExists(id))
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

        // POST: api/Trostering
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Trostering>> PostTrostering(Trostering trostering)
        {
            _context.Trostering.Add(trostering);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TrosteringExists(trostering.TrosteringId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTrostering", new { id = trostering.TrosteringId }, trostering);
        }

        // DELETE: api/Trostering/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Trostering>> DeleteTrostering(short id)
        {
            var trostering = await _context.Trostering.FindAsync(id);
            if (trostering == null)
            {
                return NotFound();
            }

            _context.Trostering.Remove(trostering);
            await _context.SaveChangesAsync();

            return trostering;
        }

        private bool TrosteringExists(short id)
        {
            return _context.Trostering.Any(e => e.TrosteringId == id);
        }
    }
}
