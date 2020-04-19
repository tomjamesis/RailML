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
    public class TderailKindController : ControllerBase
    {
        private readonly DBContext _context;

        public TderailKindController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TderailKind
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TderailKind>>> GetTderailKind()
        {
            return await _context.TderailKind.ToListAsync();
        }

        // GET: api/TderailKind/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TderailKind>> GetTderailKind(byte id)
        {
            var tderailKind = await _context.TderailKind.FindAsync(id);

            if (tderailKind == null)
            {
                return NotFound();
            }

            return tderailKind;
        }

        // PUT: api/TderailKind/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTderailKind(byte id, TderailKind tderailKind)
        {
            if (id != tderailKind.TderailKindId)
            {
                return BadRequest();
            }

            _context.Entry(tderailKind).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TderailKindExists(id))
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

        // POST: api/TderailKind
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TderailKind>> PostTderailKind(TderailKind tderailKind)
        {
            _context.TderailKind.Add(tderailKind);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TderailKindExists(tderailKind.TderailKindId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTderailKind", new { id = tderailKind.TderailKindId }, tderailKind);
        }

        // DELETE: api/TderailKind/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TderailKind>> DeleteTderailKind(byte id)
        {
            var tderailKind = await _context.TderailKind.FindAsync(id);
            if (tderailKind == null)
            {
                return NotFound();
            }

            _context.TderailKind.Remove(tderailKind);
            await _context.SaveChangesAsync();

            return tderailKind;
        }

        private bool TderailKindExists(byte id)
        {
            return _context.TderailKind.Any(e => e.TderailKindId == id);
        }
    }
}
