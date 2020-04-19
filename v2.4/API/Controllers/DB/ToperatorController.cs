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
    public class ToperatorController : ControllerBase
    {
        private readonly DBContext _context;

        public ToperatorController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Toperator
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Toperator>>> GetToperator()
        {
            return await _context.Toperator.ToListAsync();
        }

        // GET: api/Toperator/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Toperator>> GetToperator(long id)
        {
            var toperator = await _context.Toperator.FindAsync(id);

            if (toperator == null)
            {
                return NotFound();
            }

            return toperator;
        }

        // PUT: api/Toperator/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToperator(long id, Toperator toperator)
        {
            if (id != toperator.ToperatorId)
            {
                return BadRequest();
            }

            _context.Entry(toperator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToperatorExists(id))
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

        // POST: api/Toperator
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Toperator>> PostToperator(Toperator toperator)
        {
            _context.Toperator.Add(toperator);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ToperatorExists(toperator.ToperatorId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetToperator", new { id = toperator.ToperatorId }, toperator);
        }

        // DELETE: api/Toperator/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Toperator>> DeleteToperator(long id)
        {
            var toperator = await _context.Toperator.FindAsync(id);
            if (toperator == null)
            {
                return NotFound();
            }

            _context.Toperator.Remove(toperator);
            await _context.SaveChangesAsync();

            return toperator;
        }

        private bool ToperatorExists(long id)
        {
            return _context.Toperator.Any(e => e.ToperatorId == id);
        }
    }
}
