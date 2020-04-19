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
    public class TlineClassificationController : ControllerBase
    {
        private readonly DBContext _context;

        public TlineClassificationController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TlineClassification
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TlineClassification>>> GetTlineClassification()
        {
            return await _context.TlineClassification.ToListAsync();
        }

        // GET: api/TlineClassification/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TlineClassification>> GetTlineClassification(long id)
        {
            var tlineClassification = await _context.TlineClassification.FindAsync(id);

            if (tlineClassification == null)
            {
                return NotFound();
            }

            return tlineClassification;
        }

        // PUT: api/TlineClassification/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTlineClassification(long id, TlineClassification tlineClassification)
        {
            if (id != tlineClassification.TlineClassificationId)
            {
                return BadRequest();
            }

            _context.Entry(tlineClassification).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TlineClassificationExists(id))
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

        // POST: api/TlineClassification
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TlineClassification>> PostTlineClassification(TlineClassification tlineClassification)
        {
            _context.TlineClassification.Add(tlineClassification);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TlineClassificationExists(tlineClassification.TlineClassificationId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTlineClassification", new { id = tlineClassification.TlineClassificationId }, tlineClassification);
        }

        // DELETE: api/TlineClassification/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TlineClassification>> DeleteTlineClassification(long id)
        {
            var tlineClassification = await _context.TlineClassification.FindAsync(id);
            if (tlineClassification == null)
            {
                return NotFound();
            }

            _context.TlineClassification.Remove(tlineClassification);
            await _context.SaveChangesAsync();

            return tlineClassification;
        }

        private bool TlineClassificationExists(long id)
        {
            return _context.TlineClassification.Any(e => e.TlineClassificationId == id);
        }
    }
}
