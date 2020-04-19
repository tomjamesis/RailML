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
    public class TlocationController : ControllerBase
    {
        private readonly DBContext _context;

        public TlocationController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tlocation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tlocation>>> GetTlocation()
        {
            return await _context.Tlocation.ToListAsync();
        }

        // GET: api/Tlocation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tlocation>> GetTlocation(long id)
        {
            var tlocation = await _context.Tlocation.FindAsync(id);

            if (tlocation == null)
            {
                return NotFound();
            }

            return tlocation;
        }

        // PUT: api/Tlocation/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTlocation(long id, Tlocation tlocation)
        {
            if (id != tlocation.TlocationId)
            {
                return BadRequest();
            }

            _context.Entry(tlocation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TlocationExists(id))
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

        // POST: api/Tlocation
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tlocation>> PostTlocation(Tlocation tlocation)
        {
            _context.Tlocation.Add(tlocation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TlocationExists(tlocation.TlocationId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTlocation", new { id = tlocation.TlocationId }, tlocation);
        }

        // DELETE: api/Tlocation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tlocation>> DeleteTlocation(long id)
        {
            var tlocation = await _context.Tlocation.FindAsync(id);
            if (tlocation == null)
            {
                return NotFound();
            }

            _context.Tlocation.Remove(tlocation);
            await _context.SaveChangesAsync();

            return tlocation;
        }

        private bool TlocationExists(long id)
        {
            return _context.Tlocation.Any(e => e.TlocationId == id);
        }
    }
}
