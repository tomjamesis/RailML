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
    public class TconcessionaireController : ControllerBase
    {
        private readonly DBContext _context;

        public TconcessionaireController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tconcessionaire
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tconcessionaire>>> GetTconcessionaire()
        {
            return await _context.Tconcessionaire.ToListAsync();
        }

        // GET: api/Tconcessionaire/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tconcessionaire>> GetTconcessionaire(short id)
        {
            var tconcessionaire = await _context.Tconcessionaire.FindAsync(id);

            if (tconcessionaire == null)
            {
                return NotFound();
            }

            return tconcessionaire;
        }

        // PUT: api/Tconcessionaire/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTconcessionaire(short id, Tconcessionaire tconcessionaire)
        {
            if (id != tconcessionaire.TconcessionaireId)
            {
                return BadRequest();
            }

            _context.Entry(tconcessionaire).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TconcessionaireExists(id))
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

        // POST: api/Tconcessionaire
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tconcessionaire>> PostTconcessionaire(Tconcessionaire tconcessionaire)
        {
            _context.Tconcessionaire.Add(tconcessionaire);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TconcessionaireExists(tconcessionaire.TconcessionaireId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTconcessionaire", new { id = tconcessionaire.TconcessionaireId }, tconcessionaire);
        }

        // DELETE: api/Tconcessionaire/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tconcessionaire>> DeleteTconcessionaire(short id)
        {
            var tconcessionaire = await _context.Tconcessionaire.FindAsync(id);
            if (tconcessionaire == null)
            {
                return NotFound();
            }

            _context.Tconcessionaire.Remove(tconcessionaire);
            await _context.SaveChangesAsync();

            return tconcessionaire;
        }

        private bool TconcessionaireExists(short id)
        {
            return _context.Tconcessionaire.Any(e => e.TconcessionaireId == id);
        }
    }
}
