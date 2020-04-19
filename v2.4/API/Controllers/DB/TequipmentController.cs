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
    public class TequipmentController : ControllerBase
    {
        private readonly DBContext _context;

        public TequipmentController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tequipment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tequipment>>> GetTequipment()
        {
            return await _context.Tequipment.ToListAsync();
        }

        // GET: api/Tequipment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tequipment>> GetTequipment(long id)
        {
            var tequipment = await _context.Tequipment.FindAsync(id);

            if (tequipment == null)
            {
                return NotFound();
            }

            return tequipment;
        }

        // PUT: api/Tequipment/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTequipment(long id, Tequipment tequipment)
        {
            if (id != tequipment.TequipmentId)
            {
                return BadRequest();
            }

            _context.Entry(tequipment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TequipmentExists(id))
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

        // POST: api/Tequipment
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tequipment>> PostTequipment(Tequipment tequipment)
        {
            _context.Tequipment.Add(tequipment);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TequipmentExists(tequipment.TequipmentId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTequipment", new { id = tequipment.TequipmentId }, tequipment);
        }

        // DELETE: api/Tequipment/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tequipment>> DeleteTequipment(long id)
        {
            var tequipment = await _context.Tequipment.FindAsync(id);
            if (tequipment == null)
            {
                return NotFound();
            }

            _context.Tequipment.Remove(tequipment);
            await _context.SaveChangesAsync();

            return tequipment;
        }

        private bool TequipmentExists(long id)
        {
            return _context.Tequipment.Any(e => e.TequipmentId == id);
        }
    }
}
