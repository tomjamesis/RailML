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
    public class EgeneralInfraAttributesController : ControllerBase
    {
        private readonly DBContext _context;

        public EgeneralInfraAttributesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EgeneralInfraAttributes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EgeneralInfraAttributes>>> GetEgeneralInfraAttributes()
        {
            return await _context.EgeneralInfraAttributes.ToListAsync();
        }

        // GET: api/EgeneralInfraAttributes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EgeneralInfraAttributes>> GetEgeneralInfraAttributes(long id)
        {
            var egeneralInfraAttributes = await _context.EgeneralInfraAttributes.FindAsync(id);

            if (egeneralInfraAttributes == null)
            {
                return NotFound();
            }

            return egeneralInfraAttributes;
        }

        // PUT: api/EgeneralInfraAttributes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEgeneralInfraAttributes(long id, EgeneralInfraAttributes egeneralInfraAttributes)
        {
            if (id != egeneralInfraAttributes.EgeneralInfraAttributesId)
            {
                return BadRequest();
            }

            _context.Entry(egeneralInfraAttributes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EgeneralInfraAttributesExists(id))
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

        // POST: api/EgeneralInfraAttributes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EgeneralInfraAttributes>> PostEgeneralInfraAttributes(EgeneralInfraAttributes egeneralInfraAttributes)
        {
            _context.EgeneralInfraAttributes.Add(egeneralInfraAttributes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EgeneralInfraAttributesExists(egeneralInfraAttributes.EgeneralInfraAttributesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEgeneralInfraAttributes", new { id = egeneralInfraAttributes.EgeneralInfraAttributesId }, egeneralInfraAttributes);
        }

        // DELETE: api/EgeneralInfraAttributes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EgeneralInfraAttributes>> DeleteEgeneralInfraAttributes(long id)
        {
            var egeneralInfraAttributes = await _context.EgeneralInfraAttributes.FindAsync(id);
            if (egeneralInfraAttributes == null)
            {
                return NotFound();
            }

            _context.EgeneralInfraAttributes.Remove(egeneralInfraAttributes);
            await _context.SaveChangesAsync();

            return egeneralInfraAttributes;
        }

        private bool EgeneralInfraAttributesExists(long id)
        {
            return _context.EgeneralInfraAttributes.Any(e => e.EgeneralInfraAttributesId == id);
        }
    }
}
