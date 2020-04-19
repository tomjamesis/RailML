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
    public class TengineController : ControllerBase
    {
        private readonly DBContext _context;

        public TengineController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tengine
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tengine>>> GetTengine()
        {
            return await _context.Tengine.ToListAsync();
        }

        // GET: api/Tengine/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tengine>> GetTengine(long id)
        {
            var tengine = await _context.Tengine.FindAsync(id);

            if (tengine == null)
            {
                return NotFound();
            }

            return tengine;
        }

        // PUT: api/Tengine/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTengine(long id, Tengine tengine)
        {
            if (id != tengine.TengineId)
            {
                return BadRequest();
            }

            _context.Entry(tengine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TengineExists(id))
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

        // POST: api/Tengine
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tengine>> PostTengine(Tengine tengine)
        {
            _context.Tengine.Add(tengine);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TengineExists(tengine.TengineId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTengine", new { id = tengine.TengineId }, tengine);
        }

        // DELETE: api/Tengine/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tengine>> DeleteTengine(long id)
        {
            var tengine = await _context.Tengine.FindAsync(id);
            if (tengine == null)
            {
                return NotFound();
            }

            _context.Tengine.Remove(tengine);
            await _context.SaveChangesAsync();

            return tengine;
        }

        private bool TengineExists(long id)
        {
            return _context.Tengine.Any(e => e.TengineId == id);
        }
    }
}
