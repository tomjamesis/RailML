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
    public class EelectrificationChangesController : ControllerBase
    {
        private readonly DBContext _context;

        public EelectrificationChangesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EelectrificationChanges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EelectrificationChanges>>> GetEelectrificationChanges()
        {
            return await _context.EelectrificationChanges.ToListAsync();
        }

        // GET: api/EelectrificationChanges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EelectrificationChanges>> GetEelectrificationChanges(long id)
        {
            var eelectrificationChanges = await _context.EelectrificationChanges.FindAsync(id);

            if (eelectrificationChanges == null)
            {
                return NotFound();
            }

            return eelectrificationChanges;
        }

        // PUT: api/EelectrificationChanges/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEelectrificationChanges(long id, EelectrificationChanges eelectrificationChanges)
        {
            if (id != eelectrificationChanges.EelectrificationChangesId)
            {
                return BadRequest();
            }

            _context.Entry(eelectrificationChanges).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EelectrificationChangesExists(id))
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

        // POST: api/EelectrificationChanges
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EelectrificationChanges>> PostEelectrificationChanges(EelectrificationChanges eelectrificationChanges)
        {
            _context.EelectrificationChanges.Add(eelectrificationChanges);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EelectrificationChangesExists(eelectrificationChanges.EelectrificationChangesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEelectrificationChanges", new { id = eelectrificationChanges.EelectrificationChangesId }, eelectrificationChanges);
        }

        // DELETE: api/EelectrificationChanges/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EelectrificationChanges>> DeleteEelectrificationChanges(long id)
        {
            var eelectrificationChanges = await _context.EelectrificationChanges.FindAsync(id);
            if (eelectrificationChanges == null)
            {
                return NotFound();
            }

            _context.EelectrificationChanges.Remove(eelectrificationChanges);
            await _context.SaveChangesAsync();

            return eelectrificationChanges;
        }

        private bool EelectrificationChangesExists(long id)
        {
            return _context.EelectrificationChanges.Any(e => e.EelectrificationChangesId == id);
        }
    }
}
