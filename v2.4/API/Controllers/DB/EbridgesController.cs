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
    public class EbridgesController : ControllerBase
    {
        private readonly DBContext _context;

        public EbridgesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Ebridges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ebridges>>> GetEbridges()
        {
            return await _context.Ebridges.ToListAsync();
        }

        // GET: api/Ebridges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ebridges>> GetEbridges(long id)
        {
            var ebridges = await _context.Ebridges.FindAsync(id);

            if (ebridges == null)
            {
                return NotFound();
            }

            return ebridges;
        }

        // PUT: api/Ebridges/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEbridges(long id, Ebridges ebridges)
        {
            if (id != ebridges.EbridgesId)
            {
                return BadRequest();
            }

            _context.Entry(ebridges).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EbridgesExists(id))
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

        // POST: api/Ebridges
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ebridges>> PostEbridges(Ebridges ebridges)
        {
            _context.Ebridges.Add(ebridges);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EbridgesExists(ebridges.EbridgesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEbridges", new { id = ebridges.EbridgesId }, ebridges);
        }

        // DELETE: api/Ebridges/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ebridges>> DeleteEbridges(long id)
        {
            var ebridges = await _context.Ebridges.FindAsync(id);
            if (ebridges == null)
            {
                return NotFound();
            }

            _context.Ebridges.Remove(ebridges);
            await _context.SaveChangesAsync();

            return ebridges;
        }

        private bool EbridgesExists(long id)
        {
            return _context.Ebridges.Any(e => e.EbridgesId == id);
        }
    }
}
