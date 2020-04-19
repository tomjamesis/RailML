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
    public class TadditionalNameController : ControllerBase
    {
        private readonly DBContext _context;

        public TadditionalNameController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TadditionalName
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TadditionalName>>> GetTadditionalName()
        {
            return await _context.TadditionalName.ToListAsync();
        }

        // GET: api/TadditionalName/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TadditionalName>> GetTadditionalName(long id)
        {
            var tadditionalName = await _context.TadditionalName.FindAsync(id);

            if (tadditionalName == null)
            {
                return NotFound();
            }

            return tadditionalName;
        }

        // PUT: api/TadditionalName/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTadditionalName(long id, TadditionalName tadditionalName)
        {
            if (id != tadditionalName.TadditionalNameId)
            {
                return BadRequest();
            }

            _context.Entry(tadditionalName).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TadditionalNameExists(id))
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

        // POST: api/TadditionalName
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TadditionalName>> PostTadditionalName(TadditionalName tadditionalName)
        {
            _context.TadditionalName.Add(tadditionalName);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TadditionalNameExists(tadditionalName.TadditionalNameId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTadditionalName", new { id = tadditionalName.TadditionalNameId }, tadditionalName);
        }

        // DELETE: api/TadditionalName/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TadditionalName>> DeleteTadditionalName(long id)
        {
            var tadditionalName = await _context.TadditionalName.FindAsync(id);
            if (tadditionalName == null)
            {
                return NotFound();
            }

            _context.TadditionalName.Remove(tadditionalName);
            await _context.SaveChangesAsync();

            return tadditionalName;
        }

        private bool TadditionalNameExists(long id)
        {
            return _context.TadditionalName.Any(e => e.TadditionalNameId == id);
        }
    }
}
