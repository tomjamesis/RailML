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
    public class EcontrollersController : ControllerBase
    {
        private readonly DBContext _context;

        public EcontrollersController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Econtrollers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Econtrollers>>> GetEcontrollers()
        {
            return await _context.Econtrollers.ToListAsync();
        }

        // GET: api/Econtrollers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Econtrollers>> GetEcontrollers(long id)
        {
            var econtrollers = await _context.Econtrollers.FindAsync(id);

            if (econtrollers == null)
            {
                return NotFound();
            }

            return econtrollers;
        }

        // PUT: api/Econtrollers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEcontrollers(long id, Econtrollers econtrollers)
        {
            if (id != econtrollers.EcontrollersId)
            {
                return BadRequest();
            }

            _context.Entry(econtrollers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EcontrollersExists(id))
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

        // POST: api/Econtrollers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Econtrollers>> PostEcontrollers(Econtrollers econtrollers)
        {
            _context.Econtrollers.Add(econtrollers);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EcontrollersExists(econtrollers.EcontrollersId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEcontrollers", new { id = econtrollers.EcontrollersId }, econtrollers);
        }

        // DELETE: api/Econtrollers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Econtrollers>> DeleteEcontrollers(long id)
        {
            var econtrollers = await _context.Econtrollers.FindAsync(id);
            if (econtrollers == null)
            {
                return NotFound();
            }

            _context.Econtrollers.Remove(econtrollers);
            await _context.SaveChangesAsync();

            return econtrollers;
        }

        private bool EcontrollersExists(long id)
        {
            return _context.Econtrollers.Any(e => e.EcontrollersId == id);
        }
    }
}
