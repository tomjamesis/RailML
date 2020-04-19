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
    public class EfourQuadrantChopperController : ControllerBase
    {
        private readonly DBContext _context;

        public EfourQuadrantChopperController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EfourQuadrantChopper
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EfourQuadrantChopper>>> GetEfourQuadrantChopper()
        {
            return await _context.EfourQuadrantChopper.ToListAsync();
        }

        // GET: api/EfourQuadrantChopper/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EfourQuadrantChopper>> GetEfourQuadrantChopper(short id)
        {
            var efourQuadrantChopper = await _context.EfourQuadrantChopper.FindAsync(id);

            if (efourQuadrantChopper == null)
            {
                return NotFound();
            }

            return efourQuadrantChopper;
        }

        // PUT: api/EfourQuadrantChopper/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEfourQuadrantChopper(short id, EfourQuadrantChopper efourQuadrantChopper)
        {
            if (id != efourQuadrantChopper.EfourQuadrantChopperId)
            {
                return BadRequest();
            }

            _context.Entry(efourQuadrantChopper).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EfourQuadrantChopperExists(id))
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

        // POST: api/EfourQuadrantChopper
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EfourQuadrantChopper>> PostEfourQuadrantChopper(EfourQuadrantChopper efourQuadrantChopper)
        {
            _context.EfourQuadrantChopper.Add(efourQuadrantChopper);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EfourQuadrantChopperExists(efourQuadrantChopper.EfourQuadrantChopperId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEfourQuadrantChopper", new { id = efourQuadrantChopper.EfourQuadrantChopperId }, efourQuadrantChopper);
        }

        // DELETE: api/EfourQuadrantChopper/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EfourQuadrantChopper>> DeleteEfourQuadrantChopper(short id)
        {
            var efourQuadrantChopper = await _context.EfourQuadrantChopper.FindAsync(id);
            if (efourQuadrantChopper == null)
            {
                return NotFound();
            }

            _context.EfourQuadrantChopper.Remove(efourQuadrantChopper);
            await _context.SaveChangesAsync();

            return efourQuadrantChopper;
        }

        private bool EfourQuadrantChopperExists(short id)
        {
            return _context.EfourQuadrantChopper.Any(e => e.EfourQuadrantChopperId == id);
        }
    }
}
