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
    public class EannotationController : ControllerBase
    {
        private readonly DBContext _context;

        public EannotationController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Eannotation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eannotation>>> GetEannotation()
        {
            return await _context.Eannotation.ToListAsync();
        }

        // GET: api/Eannotation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eannotation>> GetEannotation(short id)
        {
            var eannotation = await _context.Eannotation.FindAsync(id);

            if (eannotation == null)
            {
                return NotFound();
            }

            return eannotation;
        }

        // PUT: api/Eannotation/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEannotation(short id, Eannotation eannotation)
        {
            if (id != eannotation.EannotationId)
            {
                return BadRequest();
            }

            _context.Entry(eannotation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EannotationExists(id))
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

        // POST: api/Eannotation
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eannotation>> PostEannotation(Eannotation eannotation)
        {
            _context.Eannotation.Add(eannotation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EannotationExists(eannotation.EannotationId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEannotation", new { id = eannotation.EannotationId }, eannotation);
        }

        // DELETE: api/Eannotation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eannotation>> DeleteEannotation(short id)
        {
            var eannotation = await _context.Eannotation.FindAsync(id);
            if (eannotation == null)
            {
                return NotFound();
            }

            _context.Eannotation.Remove(eannotation);
            await _context.SaveChangesAsync();

            return eannotation;
        }

        private bool EannotationExists(short id)
        {
            return _context.Eannotation.Any(e => e.EannotationId == id);
        }
    }
}
