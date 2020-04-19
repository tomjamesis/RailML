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
    public class EannotationsController : ControllerBase
    {
        private readonly DBContext _context;

        public EannotationsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Eannotations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eannotations>>> GetEannotations()
        {
            return await _context.Eannotations.ToListAsync();
        }

        // GET: api/Eannotations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eannotations>> GetEannotations(long id)
        {
            var eannotations = await _context.Eannotations.FindAsync(id);

            if (eannotations == null)
            {
                return NotFound();
            }

            return eannotations;
        }

        // PUT: api/Eannotations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEannotations(long id, Eannotations eannotations)
        {
            if (id != eannotations.EannotationsId)
            {
                return BadRequest();
            }

            _context.Entry(eannotations).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EannotationsExists(id))
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

        // POST: api/Eannotations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eannotations>> PostEannotations(Eannotations eannotations)
        {
            _context.Eannotations.Add(eannotations);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EannotationsExists(eannotations.EannotationsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEannotations", new { id = eannotations.EannotationsId }, eannotations);
        }

        // DELETE: api/Eannotations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eannotations>> DeleteEannotations(long id)
        {
            var eannotations = await _context.Eannotations.FindAsync(id);
            if (eannotations == null)
            {
                return NotFound();
            }

            _context.Eannotations.Remove(eannotations);
            await _context.SaveChangesAsync();

            return eannotations;
        }

        private bool EannotationsExists(long id)
        {
            return _context.Eannotations.Any(e => e.EannotationsId == id);
        }
    }
}
