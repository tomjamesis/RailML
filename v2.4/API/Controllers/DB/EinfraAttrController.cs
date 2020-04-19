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
    public class EinfraAttrController : ControllerBase
    {
        private readonly DBContext _context;

        public EinfraAttrController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EinfraAttr
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EinfraAttr>>> GetEinfraAttr()
        {
            return await _context.EinfraAttr.ToListAsync();
        }

        // GET: api/EinfraAttr/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EinfraAttr>> GetEinfraAttr(short id)
        {
            var einfraAttr = await _context.EinfraAttr.FindAsync(id);

            if (einfraAttr == null)
            {
                return NotFound();
            }

            return einfraAttr;
        }

        // PUT: api/EinfraAttr/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEinfraAttr(short id, EinfraAttr einfraAttr)
        {
            if (id != einfraAttr.EinfraAttrId)
            {
                return BadRequest();
            }

            _context.Entry(einfraAttr).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EinfraAttrExists(id))
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

        // POST: api/EinfraAttr
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EinfraAttr>> PostEinfraAttr(EinfraAttr einfraAttr)
        {
            _context.EinfraAttr.Add(einfraAttr);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EinfraAttrExists(einfraAttr.EinfraAttrId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEinfraAttr", new { id = einfraAttr.EinfraAttrId }, einfraAttr);
        }

        // DELETE: api/EinfraAttr/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EinfraAttr>> DeleteEinfraAttr(short id)
        {
            var einfraAttr = await _context.EinfraAttr.FindAsync(id);
            if (einfraAttr == null)
            {
                return NotFound();
            }

            _context.EinfraAttr.Remove(einfraAttr);
            await _context.SaveChangesAsync();

            return einfraAttr;
        }

        private bool EinfraAttrExists(short id)
        {
            return _context.EinfraAttr.Any(e => e.EinfraAttrId == id);
        }
    }
}
