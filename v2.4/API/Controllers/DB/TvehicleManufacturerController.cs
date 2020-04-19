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
    public class TvehicleManufacturerController : ControllerBase
    {
        private readonly DBContext _context;

        public TvehicleManufacturerController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TvehicleManufacturer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TvehicleManufacturer>>> GetTvehicleManufacturer()
        {
            return await _context.TvehicleManufacturer.ToListAsync();
        }

        // GET: api/TvehicleManufacturer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TvehicleManufacturer>> GetTvehicleManufacturer(short id)
        {
            var tvehicleManufacturer = await _context.TvehicleManufacturer.FindAsync(id);

            if (tvehicleManufacturer == null)
            {
                return NotFound();
            }

            return tvehicleManufacturer;
        }

        // PUT: api/TvehicleManufacturer/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTvehicleManufacturer(short id, TvehicleManufacturer tvehicleManufacturer)
        {
            if (id != tvehicleManufacturer.TvehicleManufacturerId)
            {
                return BadRequest();
            }

            _context.Entry(tvehicleManufacturer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TvehicleManufacturerExists(id))
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

        // POST: api/TvehicleManufacturer
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TvehicleManufacturer>> PostTvehicleManufacturer(TvehicleManufacturer tvehicleManufacturer)
        {
            _context.TvehicleManufacturer.Add(tvehicleManufacturer);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TvehicleManufacturerExists(tvehicleManufacturer.TvehicleManufacturerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTvehicleManufacturer", new { id = tvehicleManufacturer.TvehicleManufacturerId }, tvehicleManufacturer);
        }

        // DELETE: api/TvehicleManufacturer/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TvehicleManufacturer>> DeleteTvehicleManufacturer(short id)
        {
            var tvehicleManufacturer = await _context.TvehicleManufacturer.FindAsync(id);
            if (tvehicleManufacturer == null)
            {
                return NotFound();
            }

            _context.TvehicleManufacturer.Remove(tvehicleManufacturer);
            await _context.SaveChangesAsync();

            return tvehicleManufacturer;
        }

        private bool TvehicleManufacturerExists(short id)
        {
            return _context.TvehicleManufacturer.Any(e => e.TvehicleManufacturerId == id);
        }
    }
}
