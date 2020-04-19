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
    public class EoperatorController : ControllerBase
    {
        private readonly DBContext _context;

        public EoperatorController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Eoperator
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eoperator>>> GetEoperator()
        {
            return await _context.Eoperator.ToListAsync();
        }

        // GET: api/Eoperator/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eoperator>> GetEoperator(short id)
        {
            var eoperator = await _context.Eoperator.FindAsync(id);

            if (eoperator == null)
            {
                return NotFound();
            }

            return eoperator;
        }

        // PUT: api/Eoperator/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEoperator(short id, Eoperator eoperator)
        {
            if (id != eoperator.EoperatorId)
            {
                return BadRequest();
            }

            _context.Entry(eoperator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EoperatorExists(id))
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

        // POST: api/Eoperator
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eoperator>> PostEoperator(Eoperator eoperator)
        {
            _context.Eoperator.Add(eoperator);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EoperatorExists(eoperator.EoperatorId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEoperator", new { id = eoperator.EoperatorId }, eoperator);
        }

        // DELETE: api/Eoperator/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eoperator>> DeleteEoperator(short id)
        {
            var eoperator = await _context.Eoperator.FindAsync(id);
            if (eoperator == null)
            {
                return NotFound();
            }

            _context.Eoperator.Remove(eoperator);
            await _context.SaveChangesAsync();

            return eoperator;
        }

        private bool EoperatorExists(short id)
        {
            return _context.Eoperator.Any(e => e.EoperatorId == id);
        }
    }
}
