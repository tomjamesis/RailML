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
    public class TglobalElementWithMetadataController : ControllerBase
    {
        private readonly DBContext _context;

        public TglobalElementWithMetadataController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TglobalElementWithMetadata
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TglobalElementWithMetadata>>> GetTglobalElementWithMetadata()
        {
            return await _context.TglobalElementWithMetadata.ToListAsync();
        }

        // GET: api/TglobalElementWithMetadata/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TglobalElementWithMetadata>> GetTglobalElementWithMetadata(short id)
        {
            var tglobalElementWithMetadata = await _context.TglobalElementWithMetadata.FindAsync(id);

            if (tglobalElementWithMetadata == null)
            {
                return NotFound();
            }

            return tglobalElementWithMetadata;
        }

        // PUT: api/TglobalElementWithMetadata/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTglobalElementWithMetadata(short id, TglobalElementWithMetadata tglobalElementWithMetadata)
        {
            if (id != tglobalElementWithMetadata.TglobalElementWithMetadataId)
            {
                return BadRequest();
            }

            _context.Entry(tglobalElementWithMetadata).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TglobalElementWithMetadataExists(id))
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

        // POST: api/TglobalElementWithMetadata
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TglobalElementWithMetadata>> PostTglobalElementWithMetadata(TglobalElementWithMetadata tglobalElementWithMetadata)
        {
            _context.TglobalElementWithMetadata.Add(tglobalElementWithMetadata);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TglobalElementWithMetadataExists(tglobalElementWithMetadata.TglobalElementWithMetadataId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTglobalElementWithMetadata", new { id = tglobalElementWithMetadata.TglobalElementWithMetadataId }, tglobalElementWithMetadata);
        }

        // DELETE: api/TglobalElementWithMetadata/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TglobalElementWithMetadata>> DeleteTglobalElementWithMetadata(short id)
        {
            var tglobalElementWithMetadata = await _context.TglobalElementWithMetadata.FindAsync(id);
            if (tglobalElementWithMetadata == null)
            {
                return NotFound();
            }

            _context.TglobalElementWithMetadata.Remove(tglobalElementWithMetadata);
            await _context.SaveChangesAsync();

            return tglobalElementWithMetadata;
        }

        private bool TglobalElementWithMetadataExists(short id)
        {
            return _context.TglobalElementWithMetadata.Any(e => e.TglobalElementWithMetadataId == id);
        }
    }
}
