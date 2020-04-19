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
    public class EtractionMotorController : ControllerBase
    {
        private readonly DBContext _context;

        public EtractionMotorController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtractionMotor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtractionMotor>>> GetEtractionMotor()
        {
            return await _context.EtractionMotor.ToListAsync();
        }

        // GET: api/EtractionMotor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtractionMotor>> GetEtractionMotor(short id)
        {
            var etractionMotor = await _context.EtractionMotor.FindAsync(id);

            if (etractionMotor == null)
            {
                return NotFound();
            }

            return etractionMotor;
        }

        // PUT: api/EtractionMotor/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtractionMotor(short id, EtractionMotor etractionMotor)
        {
            if (id != etractionMotor.EtractionMotorId)
            {
                return BadRequest();
            }

            _context.Entry(etractionMotor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtractionMotorExists(id))
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

        // POST: api/EtractionMotor
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtractionMotor>> PostEtractionMotor(EtractionMotor etractionMotor)
        {
            _context.EtractionMotor.Add(etractionMotor);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtractionMotorExists(etractionMotor.EtractionMotorId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtractionMotor", new { id = etractionMotor.EtractionMotorId }, etractionMotor);
        }

        // DELETE: api/EtractionMotor/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtractionMotor>> DeleteEtractionMotor(short id)
        {
            var etractionMotor = await _context.EtractionMotor.FindAsync(id);
            if (etractionMotor == null)
            {
                return NotFound();
            }

            _context.EtractionMotor.Remove(etractionMotor);
            await _context.SaveChangesAsync();

            return etractionMotor;
        }

        private bool EtractionMotorExists(short id)
        {
            return _context.EtractionMotor.Any(e => e.EtractionMotorId == id);
        }
    }
}
