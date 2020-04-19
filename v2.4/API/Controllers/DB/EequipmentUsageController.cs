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
    public class EequipmentUsageController : ControllerBase
    {
        private readonly DBContext _context;

        public EequipmentUsageController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EequipmentUsage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EequipmentUsage>>> GetEequipmentUsage()
        {
            return await _context.EequipmentUsage.ToListAsync();
        }

        // GET: api/EequipmentUsage/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EequipmentUsage>> GetEequipmentUsage(long id)
        {
            var eequipmentUsage = await _context.EequipmentUsage.FindAsync(id);

            if (eequipmentUsage == null)
            {
                return NotFound();
            }

            return eequipmentUsage;
        }

        // PUT: api/EequipmentUsage/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEequipmentUsage(long id, EequipmentUsage eequipmentUsage)
        {
            if (id != eequipmentUsage.EequipmentUsageId)
            {
                return BadRequest();
            }

            _context.Entry(eequipmentUsage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EequipmentUsageExists(id))
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

        // POST: api/EequipmentUsage
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EequipmentUsage>> PostEequipmentUsage(EequipmentUsage eequipmentUsage)
        {
            _context.EequipmentUsage.Add(eequipmentUsage);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EequipmentUsageExists(eequipmentUsage.EequipmentUsageId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEequipmentUsage", new { id = eequipmentUsage.EequipmentUsageId }, eequipmentUsage);
        }

        // DELETE: api/EequipmentUsage/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EequipmentUsage>> DeleteEequipmentUsage(long id)
        {
            var eequipmentUsage = await _context.EequipmentUsage.FindAsync(id);
            if (eequipmentUsage == null)
            {
                return NotFound();
            }

            _context.EequipmentUsage.Remove(eequipmentUsage);
            await _context.SaveChangesAsync();

            return eequipmentUsage;
        }

        private bool EequipmentUsageExists(long id)
        {
            return _context.EequipmentUsage.Any(e => e.EequipmentUsageId == id);
        }
    }
}
