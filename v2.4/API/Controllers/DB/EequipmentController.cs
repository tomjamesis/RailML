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
    public class EequipmentController : ControllerBase
    {
        private readonly DBContext _context;

        public EequipmentController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Eequipment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eequipment>>> GetEequipment()
        {
            return await _context.Eequipment.ToListAsync();
        }

        // GET: api/Eequipment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eequipment>> GetEequipment(short id)
        {
            var eequipment = await _context.Eequipment.FindAsync(id);

            if (eequipment == null)
            {
                return NotFound();
            }

            return eequipment;
        }

        // PUT: api/Eequipment/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEequipment(short id, Eequipment eequipment)
        {
            if (id != eequipment.EequipmentId)
            {
                return BadRequest();
            }

            _context.Entry(eequipment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EequipmentExists(id))
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

        // POST: api/Eequipment
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eequipment>> PostEequipment(Eequipment eequipment)
        {
            _context.Eequipment.Add(eequipment);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EequipmentExists(eequipment.EequipmentId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEequipment", new { id = eequipment.EequipmentId }, eequipment);
        }

        // DELETE: api/Eequipment/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eequipment>> DeleteEequipment(short id)
        {
            var eequipment = await _context.Eequipment.FindAsync(id);
            if (eequipment == null)
            {
                return NotFound();
            }

            _context.Eequipment.Remove(eequipment);
            await _context.SaveChangesAsync();

            return eequipment;
        }

        private bool EequipmentExists(short id)
        {
            return _context.Eequipment.Any(e => e.EequipmentId == id);
        }
    }
}
