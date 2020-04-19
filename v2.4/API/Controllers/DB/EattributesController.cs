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
    public class EattributesController : ControllerBase
    {
        private readonly DBContext _context;

        public EattributesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Eattributes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eattributes>>> GetEattributes()
        {
            return await _context.Eattributes.ToListAsync();
        }

        // GET: api/Eattributes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eattributes>> GetEattributes(long id)
        {
            var eattributes = await _context.Eattributes.FindAsync(id);

            if (eattributes == null)
            {
                return NotFound();
            }

            return eattributes;
        }

        // PUT: api/Eattributes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEattributes(long id, Eattributes eattributes)
        {
            if (id != eattributes.EattributesId)
            {
                return BadRequest();
            }

            _context.Entry(eattributes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EattributesExists(id))
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

        // POST: api/Eattributes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eattributes>> PostEattributes(Eattributes eattributes)
        {
            _context.Eattributes.Add(eattributes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EattributesExists(eattributes.EattributesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEattributes", new { id = eattributes.EattributesId }, eattributes);
        }

        // DELETE: api/Eattributes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eattributes>> DeleteEattributes(long id)
        {
            var eattributes = await _context.Eattributes.FindAsync(id);
            if (eattributes == null)
            {
                return NotFound();
            }

            _context.Eattributes.Remove(eattributes);
            await _context.SaveChangesAsync();

            return eattributes;
        }

        private bool EattributesExists(long id)
        {
            return _context.Eattributes.Any(e => e.EattributesId == id);
        }
    }
}
