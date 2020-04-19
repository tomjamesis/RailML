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
    public class EinfraAttrGroupRefsController : ControllerBase
    {
        private readonly DBContext _context;

        public EinfraAttrGroupRefsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EinfraAttrGroupRefs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EinfraAttrGroupRefs>>> GetEinfraAttrGroupRefs()
        {
            return await _context.EinfraAttrGroupRefs.ToListAsync();
        }

        // GET: api/EinfraAttrGroupRefs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EinfraAttrGroupRefs>> GetEinfraAttrGroupRefs(long id)
        {
            var einfraAttrGroupRefs = await _context.EinfraAttrGroupRefs.FindAsync(id);

            if (einfraAttrGroupRefs == null)
            {
                return NotFound();
            }

            return einfraAttrGroupRefs;
        }

        // PUT: api/EinfraAttrGroupRefs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEinfraAttrGroupRefs(long id, EinfraAttrGroupRefs einfraAttrGroupRefs)
        {
            if (id != einfraAttrGroupRefs.EinfraAttrGroupRefsId)
            {
                return BadRequest();
            }

            _context.Entry(einfraAttrGroupRefs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EinfraAttrGroupRefsExists(id))
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

        // POST: api/EinfraAttrGroupRefs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EinfraAttrGroupRefs>> PostEinfraAttrGroupRefs(EinfraAttrGroupRefs einfraAttrGroupRefs)
        {
            _context.EinfraAttrGroupRefs.Add(einfraAttrGroupRefs);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EinfraAttrGroupRefsExists(einfraAttrGroupRefs.EinfraAttrGroupRefsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEinfraAttrGroupRefs", new { id = einfraAttrGroupRefs.EinfraAttrGroupRefsId }, einfraAttrGroupRefs);
        }

        // DELETE: api/EinfraAttrGroupRefs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EinfraAttrGroupRefs>> DeleteEinfraAttrGroupRefs(long id)
        {
            var einfraAttrGroupRefs = await _context.EinfraAttrGroupRefs.FindAsync(id);
            if (einfraAttrGroupRefs == null)
            {
                return NotFound();
            }

            _context.EinfraAttrGroupRefs.Remove(einfraAttrGroupRefs);
            await _context.SaveChangesAsync();

            return einfraAttrGroupRefs;
        }

        private bool EinfraAttrGroupRefsExists(long id)
        {
            return _context.EinfraAttrGroupRefs.Any(e => e.EinfraAttrGroupRefsId == id);
        }
    }
}
