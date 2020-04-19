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
    public class TtractionMotorController : ControllerBase
    {
        private readonly DBContext _context;

        public TtractionMotorController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtractionMotor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtractionMotor>>> GetTtractionMotor()
        {
            return await _context.TtractionMotor.ToListAsync();
        }

        // GET: api/TtractionMotor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtractionMotor>> GetTtractionMotor(long id)
        {
            var ttractionMotor = await _context.TtractionMotor.FindAsync(id);

            if (ttractionMotor == null)
            {
                return NotFound();
            }

            return ttractionMotor;
        }

        // PUT: api/TtractionMotor/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtractionMotor(long id, TtractionMotor ttractionMotor)
        {
            if (id != ttractionMotor.TtractionMotorId)
            {
                return BadRequest();
            }

            _context.Entry(ttractionMotor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtractionMotorExists(id))
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

        // POST: api/TtractionMotor
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtractionMotor>> PostTtractionMotor(TtractionMotor ttractionMotor)
        {
            _context.TtractionMotor.Add(ttractionMotor);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtractionMotorExists(ttractionMotor.TtractionMotorId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtractionMotor", new { id = ttractionMotor.TtractionMotorId }, ttractionMotor);
        }

        // DELETE: api/TtractionMotor/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtractionMotor>> DeleteTtractionMotor(long id)
        {
            var ttractionMotor = await _context.TtractionMotor.FindAsync(id);
            if (ttractionMotor == null)
            {
                return NotFound();
            }

            _context.TtractionMotor.Remove(ttractionMotor);
            await _context.SaveChangesAsync();

            return ttractionMotor;
        }

        private bool TtractionMotorExists(long id)
        {
            return _context.TtractionMotor.Any(e => e.TtractionMotorId == id);
        }
    }
}
