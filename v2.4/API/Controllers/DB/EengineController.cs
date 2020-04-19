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
    public class EengineController : ControllerBase
    {
        private readonly DBContext _context;

        public EengineController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Eengine
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eengine>>> GetEengine()
        {
            return await _context.Eengine.ToListAsync();
        }

        // GET: api/Eengine/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eengine>> GetEengine(short id)
        {
            var eengine = await _context.Eengine.FindAsync(id);

            if (eengine == null)
            {
                return NotFound();
            }

            return eengine;
        }

        // PUT: api/Eengine/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEengine(short id, Eengine eengine)
        {
            if (id != eengine.EengineId)
            {
                return BadRequest();
            }

            _context.Entry(eengine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EengineExists(id))
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

        // POST: api/Eengine
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eengine>> PostEengine(Eengine eengine)
        {
            _context.Eengine.Add(eengine);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EengineExists(eengine.EengineId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEengine", new { id = eengine.EengineId }, eengine);
        }

        // DELETE: api/Eengine/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eengine>> DeleteEengine(short id)
        {
            var eengine = await _context.Eengine.FindAsync(id);
            if (eengine == null)
            {
                return NotFound();
            }

            _context.Eengine.Remove(eengine);
            await _context.SaveChangesAsync();

            return eengine;
        }

        private bool EengineExists(short id)
        {
            return _context.Eengine.Any(e => e.EengineId == id);
        }
    }
}
