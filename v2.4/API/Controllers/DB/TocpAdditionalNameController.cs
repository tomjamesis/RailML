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
    public class TocpAdditionalNameController : ControllerBase
    {
        private readonly DBContext _context;

        public TocpAdditionalNameController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TocpAdditionalName
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TocpAdditionalName>>> GetTocpAdditionalName()
        {
            return await _context.TocpAdditionalName.ToListAsync();
        }

        // GET: api/TocpAdditionalName/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TocpAdditionalName>> GetTocpAdditionalName(long id)
        {
            var tocpAdditionalName = await _context.TocpAdditionalName.FindAsync(id);

            if (tocpAdditionalName == null)
            {
                return NotFound();
            }

            return tocpAdditionalName;
        }

        // PUT: api/TocpAdditionalName/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTocpAdditionalName(long id, TocpAdditionalName tocpAdditionalName)
        {
            if (id != tocpAdditionalName.TocpAdditionalNameId)
            {
                return BadRequest();
            }

            _context.Entry(tocpAdditionalName).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TocpAdditionalNameExists(id))
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

        // POST: api/TocpAdditionalName
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TocpAdditionalName>> PostTocpAdditionalName(TocpAdditionalName tocpAdditionalName)
        {
            _context.TocpAdditionalName.Add(tocpAdditionalName);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TocpAdditionalNameExists(tocpAdditionalName.TocpAdditionalNameId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTocpAdditionalName", new { id = tocpAdditionalName.TocpAdditionalNameId }, tocpAdditionalName);
        }

        // DELETE: api/TocpAdditionalName/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TocpAdditionalName>> DeleteTocpAdditionalName(long id)
        {
            var tocpAdditionalName = await _context.TocpAdditionalName.FindAsync(id);
            if (tocpAdditionalName == null)
            {
                return NotFound();
            }

            _context.TocpAdditionalName.Remove(tocpAdditionalName);
            await _context.SaveChangesAsync();

            return tocpAdditionalName;
        }

        private bool TocpAdditionalNameExists(long id)
        {
            return _context.TocpAdditionalName.Any(e => e.TocpAdditionalNameId == id);
        }
    }
}
