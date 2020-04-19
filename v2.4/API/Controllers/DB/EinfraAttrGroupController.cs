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
    public class EinfraAttrGroupController : ControllerBase
    {
        private readonly DBContext _context;

        public EinfraAttrGroupController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EinfraAttrGroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EinfraAttrGroup>>> GetEinfraAttrGroup()
        {
            return await _context.EinfraAttrGroup.ToListAsync();
        }

        // GET: api/EinfraAttrGroup/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EinfraAttrGroup>> GetEinfraAttrGroup(long id)
        {
            var einfraAttrGroup = await _context.EinfraAttrGroup.FindAsync(id);

            if (einfraAttrGroup == null)
            {
                return NotFound();
            }

            return einfraAttrGroup;
        }

        // PUT: api/EinfraAttrGroup/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEinfraAttrGroup(long id, EinfraAttrGroup einfraAttrGroup)
        {
            if (id != einfraAttrGroup.EinfraAttrGroupId)
            {
                return BadRequest();
            }

            _context.Entry(einfraAttrGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EinfraAttrGroupExists(id))
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

        // POST: api/EinfraAttrGroup
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EinfraAttrGroup>> PostEinfraAttrGroup(EinfraAttrGroup einfraAttrGroup)
        {
            _context.EinfraAttrGroup.Add(einfraAttrGroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EinfraAttrGroupExists(einfraAttrGroup.EinfraAttrGroupId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEinfraAttrGroup", new { id = einfraAttrGroup.EinfraAttrGroupId }, einfraAttrGroup);
        }

        // DELETE: api/EinfraAttrGroup/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EinfraAttrGroup>> DeleteEinfraAttrGroup(long id)
        {
            var einfraAttrGroup = await _context.EinfraAttrGroup.FindAsync(id);
            if (einfraAttrGroup == null)
            {
                return NotFound();
            }

            _context.EinfraAttrGroup.Remove(einfraAttrGroup);
            await _context.SaveChangesAsync();

            return einfraAttrGroup;
        }

        private bool EinfraAttrGroupExists(long id)
        {
            return _context.EinfraAttrGroup.Any(e => e.EinfraAttrGroupId == id);
        }
    }
}
