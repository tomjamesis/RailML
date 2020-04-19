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
    public class EocpPropEquipmentController : ControllerBase
    {
        private readonly DBContext _context;

        public EocpPropEquipmentController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EocpPropEquipment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EocpPropEquipment>>> GetEocpPropEquipment()
        {
            return await _context.EocpPropEquipment.ToListAsync();
        }

        // GET: api/EocpPropEquipment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EocpPropEquipment>> GetEocpPropEquipment(long id)
        {
            var eocpPropEquipment = await _context.EocpPropEquipment.FindAsync(id);

            if (eocpPropEquipment == null)
            {
                return NotFound();
            }

            return eocpPropEquipment;
        }

        // PUT: api/EocpPropEquipment/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEocpPropEquipment(long id, EocpPropEquipment eocpPropEquipment)
        {
            if (id != eocpPropEquipment.EocpPropEquipmentId)
            {
                return BadRequest();
            }

            _context.Entry(eocpPropEquipment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EocpPropEquipmentExists(id))
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

        // POST: api/EocpPropEquipment
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EocpPropEquipment>> PostEocpPropEquipment(EocpPropEquipment eocpPropEquipment)
        {
            _context.EocpPropEquipment.Add(eocpPropEquipment);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EocpPropEquipmentExists(eocpPropEquipment.EocpPropEquipmentId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEocpPropEquipment", new { id = eocpPropEquipment.EocpPropEquipmentId }, eocpPropEquipment);
        }

        // DELETE: api/EocpPropEquipment/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EocpPropEquipment>> DeleteEocpPropEquipment(long id)
        {
            var eocpPropEquipment = await _context.EocpPropEquipment.FindAsync(id);
            if (eocpPropEquipment == null)
            {
                return NotFound();
            }

            _context.EocpPropEquipment.Remove(eocpPropEquipment);
            await _context.SaveChangesAsync();

            return eocpPropEquipment;
        }

        private bool EocpPropEquipmentExists(long id)
        {
            return _context.EocpPropEquipment.Any(e => e.EocpPropEquipmentId == id);
        }
    }
}
