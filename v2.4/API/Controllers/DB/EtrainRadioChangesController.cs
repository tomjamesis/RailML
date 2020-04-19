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
    public class EtrainRadioChangesController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrainRadioChangesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrainRadioChanges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrainRadioChanges>>> GetEtrainRadioChanges()
        {
            return await _context.EtrainRadioChanges.ToListAsync();
        }

        // GET: api/EtrainRadioChanges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrainRadioChanges>> GetEtrainRadioChanges(long id)
        {
            var etrainRadioChanges = await _context.EtrainRadioChanges.FindAsync(id);

            if (etrainRadioChanges == null)
            {
                return NotFound();
            }

            return etrainRadioChanges;
        }

        // PUT: api/EtrainRadioChanges/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrainRadioChanges(long id, EtrainRadioChanges etrainRadioChanges)
        {
            if (id != etrainRadioChanges.EtrainRadioChangesId)
            {
                return BadRequest();
            }

            _context.Entry(etrainRadioChanges).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrainRadioChangesExists(id))
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

        // POST: api/EtrainRadioChanges
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrainRadioChanges>> PostEtrainRadioChanges(EtrainRadioChanges etrainRadioChanges)
        {
            _context.EtrainRadioChanges.Add(etrainRadioChanges);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrainRadioChangesExists(etrainRadioChanges.EtrainRadioChangesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrainRadioChanges", new { id = etrainRadioChanges.EtrainRadioChangesId }, etrainRadioChanges);
        }

        // DELETE: api/EtrainRadioChanges/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrainRadioChanges>> DeleteEtrainRadioChanges(long id)
        {
            var etrainRadioChanges = await _context.EtrainRadioChanges.FindAsync(id);
            if (etrainRadioChanges == null)
            {
                return NotFound();
            }

            _context.EtrainRadioChanges.Remove(etrainRadioChanges);
            await _context.SaveChangesAsync();

            return etrainRadioChanges;
        }

        private bool EtrainRadioChangesExists(long id)
        {
            return _context.EtrainRadioChanges.Any(e => e.EtrainRadioChangesId == id);
        }
    }
}
