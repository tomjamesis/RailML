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
    public class TadditionalOcpNameController : ControllerBase
    {
        private readonly DBContext _context;

        public TadditionalOcpNameController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TadditionalOcpName
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TadditionalOcpName>>> GetTadditionalOcpName()
        {
            return await _context.TadditionalOcpName.ToListAsync();
        }

        // GET: api/TadditionalOcpName/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TadditionalOcpName>> GetTadditionalOcpName(long id)
        {
            var tadditionalOcpName = await _context.TadditionalOcpName.FindAsync(id);

            if (tadditionalOcpName == null)
            {
                return NotFound();
            }

            return tadditionalOcpName;
        }

        // PUT: api/TadditionalOcpName/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTadditionalOcpName(long id, TadditionalOcpName tadditionalOcpName)
        {
            if (id != tadditionalOcpName.TadditionalOcpNameId)
            {
                return BadRequest();
            }

            _context.Entry(tadditionalOcpName).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TadditionalOcpNameExists(id))
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

        // POST: api/TadditionalOcpName
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TadditionalOcpName>> PostTadditionalOcpName(TadditionalOcpName tadditionalOcpName)
        {
            _context.TadditionalOcpName.Add(tadditionalOcpName);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TadditionalOcpNameExists(tadditionalOcpName.TadditionalOcpNameId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTadditionalOcpName", new { id = tadditionalOcpName.TadditionalOcpNameId }, tadditionalOcpName);
        }

        // DELETE: api/TadditionalOcpName/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TadditionalOcpName>> DeleteTadditionalOcpName(long id)
        {
            var tadditionalOcpName = await _context.TadditionalOcpName.FindAsync(id);
            if (tadditionalOcpName == null)
            {
                return NotFound();
            }

            _context.TadditionalOcpName.Remove(tadditionalOcpName);
            await _context.SaveChangesAsync();

            return tadditionalOcpName;
        }

        private bool TadditionalOcpNameExists(long id)
        {
            return _context.TadditionalOcpName.Any(e => e.TadditionalOcpNameId == id);
        }
    }
}
