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
    public class TotherEquipmentController : ControllerBase
    {
        private readonly DBContext _context;

        public TotherEquipmentController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TotherEquipment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TotherEquipment>>> GetTotherEquipment()
        {
            return await _context.TotherEquipment.ToListAsync();
        }

        // GET: api/TotherEquipment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TotherEquipment>> GetTotherEquipment(short id)
        {
            var totherEquipment = await _context.TotherEquipment.FindAsync(id);

            if (totherEquipment == null)
            {
                return NotFound();
            }

            return totherEquipment;
        }

        // PUT: api/TotherEquipment/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTotherEquipment(short id, TotherEquipment totherEquipment)
        {
            if (id != totherEquipment.TotherEquipmentId)
            {
                return BadRequest();
            }

            _context.Entry(totherEquipment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TotherEquipmentExists(id))
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

        // POST: api/TotherEquipment
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TotherEquipment>> PostTotherEquipment(TotherEquipment totherEquipment)
        {
            _context.TotherEquipment.Add(totherEquipment);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TotherEquipmentExists(totherEquipment.TotherEquipmentId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTotherEquipment", new { id = totherEquipment.TotherEquipmentId }, totherEquipment);
        }

        // DELETE: api/TotherEquipment/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TotherEquipment>> DeleteTotherEquipment(short id)
        {
            var totherEquipment = await _context.TotherEquipment.FindAsync(id);
            if (totherEquipment == null)
            {
                return NotFound();
            }

            _context.TotherEquipment.Remove(totherEquipment);
            await _context.SaveChangesAsync();

            return totherEquipment;
        }

        private bool TotherEquipmentExists(short id)
        {
            return _context.TotherEquipment.Any(e => e.TotherEquipmentId == id);
        }
    }
}
