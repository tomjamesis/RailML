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
    public class EbrakeUsageController : ControllerBase
    {
        private readonly DBContext _context;

        public EbrakeUsageController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EbrakeUsage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EbrakeUsage>>> GetEbrakeUsage()
        {
            return await _context.EbrakeUsage.ToListAsync();
        }

        // GET: api/EbrakeUsage/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EbrakeUsage>> GetEbrakeUsage(short id)
        {
            var ebrakeUsage = await _context.EbrakeUsage.FindAsync(id);

            if (ebrakeUsage == null)
            {
                return NotFound();
            }

            return ebrakeUsage;
        }

        // PUT: api/EbrakeUsage/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEbrakeUsage(short id, EbrakeUsage ebrakeUsage)
        {
            if (id != ebrakeUsage.EbrakeUsageId)
            {
                return BadRequest();
            }

            _context.Entry(ebrakeUsage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EbrakeUsageExists(id))
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

        // POST: api/EbrakeUsage
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EbrakeUsage>> PostEbrakeUsage(EbrakeUsage ebrakeUsage)
        {
            _context.EbrakeUsage.Add(ebrakeUsage);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EbrakeUsageExists(ebrakeUsage.EbrakeUsageId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEbrakeUsage", new { id = ebrakeUsage.EbrakeUsageId }, ebrakeUsage);
        }

        // DELETE: api/EbrakeUsage/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EbrakeUsage>> DeleteEbrakeUsage(short id)
        {
            var ebrakeUsage = await _context.EbrakeUsage.FindAsync(id);
            if (ebrakeUsage == null)
            {
                return NotFound();
            }

            _context.EbrakeUsage.Remove(ebrakeUsage);
            await _context.SaveChangesAsync();

            return ebrakeUsage;
        }

        private bool EbrakeUsageExists(short id)
        {
            return _context.EbrakeUsage.Any(e => e.EbrakeUsageId == id);
        }
    }
}
