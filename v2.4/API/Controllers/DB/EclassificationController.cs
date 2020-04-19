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
    public class EclassificationController : ControllerBase
    {
        private readonly DBContext _context;

        public EclassificationController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Eclassification
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eclassification>>> GetEclassification()
        {
            return await _context.Eclassification.ToListAsync();
        }

        // GET: api/Eclassification/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eclassification>> GetEclassification(long id)
        {
            var eclassification = await _context.Eclassification.FindAsync(id);

            if (eclassification == null)
            {
                return NotFound();
            }

            return eclassification;
        }

        // PUT: api/Eclassification/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEclassification(long id, Eclassification eclassification)
        {
            if (id != eclassification.EclassificationId)
            {
                return BadRequest();
            }

            _context.Entry(eclassification).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EclassificationExists(id))
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

        // POST: api/Eclassification
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eclassification>> PostEclassification(Eclassification eclassification)
        {
            _context.Eclassification.Add(eclassification);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EclassificationExists(eclassification.EclassificationId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEclassification", new { id = eclassification.EclassificationId }, eclassification);
        }

        // DELETE: api/Eclassification/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eclassification>> DeleteEclassification(long id)
        {
            var eclassification = await _context.Eclassification.FindAsync(id);
            if (eclassification == null)
            {
                return NotFound();
            }

            _context.Eclassification.Remove(eclassification);
            await _context.SaveChangesAsync();

            return eclassification;
        }

        private bool EclassificationExists(long id)
        {
            return _context.Eclassification.Any(e => e.EclassificationId == id);
        }
    }
}
