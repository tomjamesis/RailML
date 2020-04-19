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
    public class EtrainsController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrainsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Etrains
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Etrains>>> GetEtrains()
        {
            return await _context.Etrains.ToListAsync();
        }

        // GET: api/Etrains/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Etrains>> GetEtrains(long id)
        {
            var etrains = await _context.Etrains.FindAsync(id);

            if (etrains == null)
            {
                return NotFound();
            }

            return etrains;
        }

        // PUT: api/Etrains/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrains(long id, Etrains etrains)
        {
            if (id != etrains.EtrainsId)
            {
                return BadRequest();
            }

            _context.Entry(etrains).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrainsExists(id))
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

        // POST: api/Etrains
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Etrains>> PostEtrains(Etrains etrains)
        {
            _context.Etrains.Add(etrains);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrainsExists(etrains.EtrainsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrains", new { id = etrains.EtrainsId }, etrains);
        }

        // DELETE: api/Etrains/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Etrains>> DeleteEtrains(long id)
        {
            var etrains = await _context.Etrains.FindAsync(id);
            if (etrains == null)
            {
                return NotFound();
            }

            _context.Etrains.Remove(etrains);
            await _context.SaveChangesAsync();

            return etrains;
        }

        private bool EtrainsExists(long id)
        {
            return _context.Etrains.Any(e => e.EtrainsId == id);
        }
    }
}
