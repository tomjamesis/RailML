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
    public class TstatisticController : ControllerBase
    {
        private readonly DBContext _context;

        public TstatisticController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tstatistic
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tstatistic>>> GetTstatistic()
        {
            return await _context.Tstatistic.ToListAsync();
        }

        // GET: api/Tstatistic/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tstatistic>> GetTstatistic(long id)
        {
            var tstatistic = await _context.Tstatistic.FindAsync(id);

            if (tstatistic == null)
            {
                return NotFound();
            }

            return tstatistic;
        }

        // PUT: api/Tstatistic/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTstatistic(long id, Tstatistic tstatistic)
        {
            if (id != tstatistic.TstatisticId)
            {
                return BadRequest();
            }

            _context.Entry(tstatistic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TstatisticExists(id))
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

        // POST: api/Tstatistic
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tstatistic>> PostTstatistic(Tstatistic tstatistic)
        {
            _context.Tstatistic.Add(tstatistic);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TstatisticExists(tstatistic.TstatisticId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTstatistic", new { id = tstatistic.TstatisticId }, tstatistic);
        }

        // DELETE: api/Tstatistic/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tstatistic>> DeleteTstatistic(long id)
        {
            var tstatistic = await _context.Tstatistic.FindAsync(id);
            if (tstatistic == null)
            {
                return NotFound();
            }

            _context.Tstatistic.Remove(tstatistic);
            await _context.SaveChangesAsync();

            return tstatistic;
        }

        private bool TstatisticExists(long id)
        {
            return _context.Tstatistic.Any(e => e.TstatisticId == id);
        }
    }
}
