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
    public class EgeneralInfraAttributeController : ControllerBase
    {
        private readonly DBContext _context;

        public EgeneralInfraAttributeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EgeneralInfraAttribute
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EgeneralInfraAttribute>>> GetEgeneralInfraAttribute()
        {
            return await _context.EgeneralInfraAttribute.ToListAsync();
        }

        // GET: api/EgeneralInfraAttribute/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EgeneralInfraAttribute>> GetEgeneralInfraAttribute(long id)
        {
            var egeneralInfraAttribute = await _context.EgeneralInfraAttribute.FindAsync(id);

            if (egeneralInfraAttribute == null)
            {
                return NotFound();
            }

            return egeneralInfraAttribute;
        }

        // PUT: api/EgeneralInfraAttribute/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEgeneralInfraAttribute(long id, EgeneralInfraAttribute egeneralInfraAttribute)
        {
            if (id != egeneralInfraAttribute.EgeneralInfraAttributeId)
            {
                return BadRequest();
            }

            _context.Entry(egeneralInfraAttribute).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EgeneralInfraAttributeExists(id))
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

        // POST: api/EgeneralInfraAttribute
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EgeneralInfraAttribute>> PostEgeneralInfraAttribute(EgeneralInfraAttribute egeneralInfraAttribute)
        {
            _context.EgeneralInfraAttribute.Add(egeneralInfraAttribute);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EgeneralInfraAttributeExists(egeneralInfraAttribute.EgeneralInfraAttributeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEgeneralInfraAttribute", new { id = egeneralInfraAttribute.EgeneralInfraAttributeId }, egeneralInfraAttribute);
        }

        // DELETE: api/EgeneralInfraAttribute/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EgeneralInfraAttribute>> DeleteEgeneralInfraAttribute(long id)
        {
            var egeneralInfraAttribute = await _context.EgeneralInfraAttribute.FindAsync(id);
            if (egeneralInfraAttribute == null)
            {
                return NotFound();
            }

            _context.EgeneralInfraAttribute.Remove(egeneralInfraAttribute);
            await _context.SaveChangesAsync();

            return egeneralInfraAttribute;
        }

        private bool EgeneralInfraAttributeExists(long id)
        {
            return _context.EgeneralInfraAttribute.Any(e => e.EgeneralInfraAttributeId == id);
        }
    }
}
