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
    public class TfourQuadrantChopperController : ControllerBase
    {
        private readonly DBContext _context;

        public TfourQuadrantChopperController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TfourQuadrantChopper
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TfourQuadrantChopper>>> GetTfourQuadrantChopper()
        {
            return await _context.TfourQuadrantChopper.ToListAsync();
        }

        // GET: api/TfourQuadrantChopper/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TfourQuadrantChopper>> GetTfourQuadrantChopper(long id)
        {
            var tfourQuadrantChopper = await _context.TfourQuadrantChopper.FindAsync(id);

            if (tfourQuadrantChopper == null)
            {
                return NotFound();
            }

            return tfourQuadrantChopper;
        }

        // PUT: api/TfourQuadrantChopper/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTfourQuadrantChopper(long id, TfourQuadrantChopper tfourQuadrantChopper)
        {
            if (id != tfourQuadrantChopper.TfourQuadrantChopperId)
            {
                return BadRequest();
            }

            _context.Entry(tfourQuadrantChopper).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TfourQuadrantChopperExists(id))
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

        // POST: api/TfourQuadrantChopper
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TfourQuadrantChopper>> PostTfourQuadrantChopper(TfourQuadrantChopper tfourQuadrantChopper)
        {
            _context.TfourQuadrantChopper.Add(tfourQuadrantChopper);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TfourQuadrantChopperExists(tfourQuadrantChopper.TfourQuadrantChopperId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTfourQuadrantChopper", new { id = tfourQuadrantChopper.TfourQuadrantChopperId }, tfourQuadrantChopper);
        }

        // DELETE: api/TfourQuadrantChopper/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TfourQuadrantChopper>> DeleteTfourQuadrantChopper(long id)
        {
            var tfourQuadrantChopper = await _context.TfourQuadrantChopper.FindAsync(id);
            if (tfourQuadrantChopper == null)
            {
                return NotFound();
            }

            _context.TfourQuadrantChopper.Remove(tfourQuadrantChopper);
            await _context.SaveChangesAsync();

            return tfourQuadrantChopper;
        }

        private bool TfourQuadrantChopperExists(long id)
        {
            return _context.TfourQuadrantChopper.Any(e => e.TfourQuadrantChopperId == id);
        }
    }
}
