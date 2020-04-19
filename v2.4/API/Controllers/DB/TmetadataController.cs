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
    public class TmetadataController : ControllerBase
    {
        private readonly DBContext _context;

        public TmetadataController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tmetadata
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tmetadata>>> GetTmetadata()
        {
            return await _context.Tmetadata.ToListAsync();
        }

        // GET: api/Tmetadata/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tmetadata>> GetTmetadata(short id)
        {
            var tmetadata = await _context.Tmetadata.FindAsync(id);

            if (tmetadata == null)
            {
                return NotFound();
            }

            return tmetadata;
        }

        // PUT: api/Tmetadata/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTmetadata(short id, Tmetadata tmetadata)
        {
            if (id != tmetadata.TmetadataId)
            {
                return BadRequest();
            }

            _context.Entry(tmetadata).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TmetadataExists(id))
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

        // POST: api/Tmetadata
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tmetadata>> PostTmetadata(Tmetadata tmetadata)
        {
            _context.Tmetadata.Add(tmetadata);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TmetadataExists(tmetadata.TmetadataId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTmetadata", new { id = tmetadata.TmetadataId }, tmetadata);
        }

        // DELETE: api/Tmetadata/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tmetadata>> DeleteTmetadata(short id)
        {
            var tmetadata = await _context.Tmetadata.FindAsync(id);
            if (tmetadata == null)
            {
                return NotFound();
            }

            _context.Tmetadata.Remove(tmetadata);
            await _context.SaveChangesAsync();

            return tmetadata;
        }

        private bool TmetadataExists(short id)
        {
            return _context.Tmetadata.Any(e => e.TmetadataId == id);
        }
    }
}
