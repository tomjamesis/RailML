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
    public class TvehicleIdentificationController : ControllerBase
    {
        private readonly DBContext _context;

        public TvehicleIdentificationController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TvehicleIdentification
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TvehicleIdentification>>> GetTvehicleIdentification()
        {
            return await _context.TvehicleIdentification.ToListAsync();
        }

        // GET: api/TvehicleIdentification/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TvehicleIdentification>> GetTvehicleIdentification(long id)
        {
            var tvehicleIdentification = await _context.TvehicleIdentification.FindAsync(id);

            if (tvehicleIdentification == null)
            {
                return NotFound();
            }

            return tvehicleIdentification;
        }

        // PUT: api/TvehicleIdentification/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTvehicleIdentification(long id, TvehicleIdentification tvehicleIdentification)
        {
            if (id != tvehicleIdentification.TvehicleIdentificationId)
            {
                return BadRequest();
            }

            _context.Entry(tvehicleIdentification).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TvehicleIdentificationExists(id))
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

        // POST: api/TvehicleIdentification
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TvehicleIdentification>> PostTvehicleIdentification(TvehicleIdentification tvehicleIdentification)
        {
            _context.TvehicleIdentification.Add(tvehicleIdentification);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TvehicleIdentificationExists(tvehicleIdentification.TvehicleIdentificationId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTvehicleIdentification", new { id = tvehicleIdentification.TvehicleIdentificationId }, tvehicleIdentification);
        }

        // DELETE: api/TvehicleIdentification/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TvehicleIdentification>> DeleteTvehicleIdentification(long id)
        {
            var tvehicleIdentification = await _context.TvehicleIdentification.FindAsync(id);
            if (tvehicleIdentification == null)
            {
                return NotFound();
            }

            _context.TvehicleIdentification.Remove(tvehicleIdentification);
            await _context.SaveChangesAsync();

            return tvehicleIdentification;
        }

        private bool TvehicleIdentificationExists(long id)
        {
            return _context.TvehicleIdentification.Any(e => e.TvehicleIdentificationId == id);
        }
    }
}
