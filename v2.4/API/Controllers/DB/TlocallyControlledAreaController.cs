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
    public class TlocallyControlledAreaController : ControllerBase
    {
        private readonly DBContext _context;

        public TlocallyControlledAreaController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TlocallyControlledArea
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TlocallyControlledArea>>> GetTlocallyControlledArea()
        {
            return await _context.TlocallyControlledArea.ToListAsync();
        }

        // GET: api/TlocallyControlledArea/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TlocallyControlledArea>> GetTlocallyControlledArea(short id)
        {
            var tlocallyControlledArea = await _context.TlocallyControlledArea.FindAsync(id);

            if (tlocallyControlledArea == null)
            {
                return NotFound();
            }

            return tlocallyControlledArea;
        }

        // PUT: api/TlocallyControlledArea/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTlocallyControlledArea(short id, TlocallyControlledArea tlocallyControlledArea)
        {
            if (id != tlocallyControlledArea.TlocallyControlledAreaId)
            {
                return BadRequest();
            }

            _context.Entry(tlocallyControlledArea).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TlocallyControlledAreaExists(id))
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

        // POST: api/TlocallyControlledArea
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TlocallyControlledArea>> PostTlocallyControlledArea(TlocallyControlledArea tlocallyControlledArea)
        {
            _context.TlocallyControlledArea.Add(tlocallyControlledArea);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TlocallyControlledAreaExists(tlocallyControlledArea.TlocallyControlledAreaId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTlocallyControlledArea", new { id = tlocallyControlledArea.TlocallyControlledAreaId }, tlocallyControlledArea);
        }

        // DELETE: api/TlocallyControlledArea/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TlocallyControlledArea>> DeleteTlocallyControlledArea(short id)
        {
            var tlocallyControlledArea = await _context.TlocallyControlledArea.FindAsync(id);
            if (tlocallyControlledArea == null)
            {
                return NotFound();
            }

            _context.TlocallyControlledArea.Remove(tlocallyControlledArea);
            await _context.SaveChangesAsync();

            return tlocallyControlledArea;
        }

        private bool TlocallyControlledAreaExists(short id)
        {
            return _context.TlocallyControlledArea.Any(e => e.TlocallyControlledAreaId == id);
        }
    }
}
