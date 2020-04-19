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
    public class EformationController : ControllerBase
    {
        private readonly DBContext _context;

        public EformationController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Eformation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eformation>>> GetEformation()
        {
            return await _context.Eformation.ToListAsync();
        }

        // GET: api/Eformation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eformation>> GetEformation(short id)
        {
            var eformation = await _context.Eformation.FindAsync(id);

            if (eformation == null)
            {
                return NotFound();
            }

            return eformation;
        }

        // PUT: api/Eformation/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEformation(short id, Eformation eformation)
        {
            if (id != eformation.EformationId)
            {
                return BadRequest();
            }

            _context.Entry(eformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EformationExists(id))
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

        // POST: api/Eformation
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eformation>> PostEformation(Eformation eformation)
        {
            _context.Eformation.Add(eformation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EformationExists(eformation.EformationId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEformation", new { id = eformation.EformationId }, eformation);
        }

        // DELETE: api/Eformation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eformation>> DeleteEformation(short id)
        {
            var eformation = await _context.Eformation.FindAsync(id);
            if (eformation == null)
            {
                return NotFound();
            }

            _context.Eformation.Remove(eformation);
            await _context.SaveChangesAsync();

            return eformation;
        }

        private bool EformationExists(short id)
        {
            return _context.Eformation.Any(e => e.EformationId == id);
        }
    }
}
