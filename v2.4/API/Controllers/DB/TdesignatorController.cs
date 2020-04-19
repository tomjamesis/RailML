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
    public class TdesignatorController : ControllerBase
    {
        private readonly DBContext _context;

        public TdesignatorController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tdesignator
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tdesignator>>> GetTdesignator()
        {
            return await _context.Tdesignator.ToListAsync();
        }

        // GET: api/Tdesignator/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tdesignator>> GetTdesignator(long id)
        {
            var tdesignator = await _context.Tdesignator.FindAsync(id);

            if (tdesignator == null)
            {
                return NotFound();
            }

            return tdesignator;
        }

        // PUT: api/Tdesignator/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdesignator(long id, Tdesignator tdesignator)
        {
            if (id != tdesignator.TdesignatorId)
            {
                return BadRequest();
            }

            _context.Entry(tdesignator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdesignatorExists(id))
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

        // POST: api/Tdesignator
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tdesignator>> PostTdesignator(Tdesignator tdesignator)
        {
            _context.Tdesignator.Add(tdesignator);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TdesignatorExists(tdesignator.TdesignatorId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTdesignator", new { id = tdesignator.TdesignatorId }, tdesignator);
        }

        // DELETE: api/Tdesignator/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tdesignator>> DeleteTdesignator(long id)
        {
            var tdesignator = await _context.Tdesignator.FindAsync(id);
            if (tdesignator == null)
            {
                return NotFound();
            }

            _context.Tdesignator.Remove(tdesignator);
            await _context.SaveChangesAsync();

            return tdesignator;
        }

        private bool TdesignatorExists(long id)
        {
            return _context.Tdesignator.Any(e => e.TdesignatorId == id);
        }
    }
}
