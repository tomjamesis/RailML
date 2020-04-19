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
    public class TannotationController : ControllerBase
    {
        private readonly DBContext _context;

        public TannotationController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tannotation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tannotation>>> GetTannotation()
        {
            return await _context.Tannotation.ToListAsync();
        }

        // GET: api/Tannotation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tannotation>> GetTannotation(short id)
        {
            var tannotation = await _context.Tannotation.FindAsync(id);

            if (tannotation == null)
            {
                return NotFound();
            }

            return tannotation;
        }

        // PUT: api/Tannotation/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTannotation(short id, Tannotation tannotation)
        {
            if (id != tannotation.TannotationId)
            {
                return BadRequest();
            }

            _context.Entry(tannotation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TannotationExists(id))
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

        // POST: api/Tannotation
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tannotation>> PostTannotation(Tannotation tannotation)
        {
            _context.Tannotation.Add(tannotation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TannotationExists(tannotation.TannotationId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTannotation", new { id = tannotation.TannotationId }, tannotation);
        }

        // DELETE: api/Tannotation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tannotation>> DeleteTannotation(short id)
        {
            var tannotation = await _context.Tannotation.FindAsync(id);
            if (tannotation == null)
            {
                return NotFound();
            }

            _context.Tannotation.Remove(tannotation);
            await _context.SaveChangesAsync();

            return tannotation;
        }

        private bool TannotationExists(short id)
        {
            return _context.Tannotation.Any(e => e.TannotationId == id);
        }
    }
}
