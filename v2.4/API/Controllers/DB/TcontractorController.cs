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
    public class TcontractorController : ControllerBase
    {
        private readonly DBContext _context;

        public TcontractorController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tcontractor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tcontractor>>> GetTcontractor()
        {
            return await _context.Tcontractor.ToListAsync();
        }

        // GET: api/Tcontractor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tcontractor>> GetTcontractor(short id)
        {
            var tcontractor = await _context.Tcontractor.FindAsync(id);

            if (tcontractor == null)
            {
                return NotFound();
            }

            return tcontractor;
        }

        // PUT: api/Tcontractor/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTcontractor(short id, Tcontractor tcontractor)
        {
            if (id != tcontractor.TcontractorId)
            {
                return BadRequest();
            }

            _context.Entry(tcontractor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TcontractorExists(id))
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

        // POST: api/Tcontractor
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tcontractor>> PostTcontractor(Tcontractor tcontractor)
        {
            _context.Tcontractor.Add(tcontractor);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TcontractorExists(tcontractor.TcontractorId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTcontractor", new { id = tcontractor.TcontractorId }, tcontractor);
        }

        // DELETE: api/Tcontractor/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tcontractor>> DeleteTcontractor(short id)
        {
            var tcontractor = await _context.Tcontractor.FindAsync(id);
            if (tcontractor == null)
            {
                return NotFound();
            }

            _context.Tcontractor.Remove(tcontractor);
            await _context.SaveChangesAsync();

            return tcontractor;
        }

        private bool TcontractorExists(short id)
        {
            return _context.Tcontractor.Any(e => e.TcontractorId == id);
        }
    }
}
