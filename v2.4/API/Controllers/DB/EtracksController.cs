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
    public class EtracksController : ControllerBase
    {
        private readonly DBContext _context;

        public EtracksController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Etracks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Etracks>>> GetEtracks()
        {
            return await _context.Etracks.ToListAsync();
        }

        // GET: api/Etracks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Etracks>> GetEtracks(long id)
        {
            var etracks = await _context.Etracks.FindAsync(id);

            if (etracks == null)
            {
                return NotFound();
            }

            return etracks;
        }

        // PUT: api/Etracks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtracks(long id, Etracks etracks)
        {
            if (id != etracks.EtracksId)
            {
                return BadRequest();
            }

            _context.Entry(etracks).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtracksExists(id))
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

        // POST: api/Etracks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Etracks>> PostEtracks(Etracks etracks)
        {
            _context.Etracks.Add(etracks);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtracksExists(etracks.EtracksId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtracks", new { id = etracks.EtracksId }, etracks);
        }

        // DELETE: api/Etracks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Etracks>> DeleteEtracks(long id)
        {
            var etracks = await _context.Etracks.FindAsync(id);
            if (etracks == null)
            {
                return NotFound();
            }

            _context.Etracks.Remove(etracks);
            await _context.SaveChangesAsync();

            return etracks;
        }

        private bool EtracksExists(long id)
        {
            return _context.Etracks.Any(e => e.EtracksId == id);
        }
    }
}
