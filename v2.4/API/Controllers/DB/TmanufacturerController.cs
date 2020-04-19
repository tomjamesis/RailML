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
    public class TmanufacturerController : ControllerBase
    {
        private readonly DBContext _context;

        public TmanufacturerController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tmanufacturer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tmanufacturer>>> GetTmanufacturer()
        {
            return await _context.Tmanufacturer.ToListAsync();
        }

        // GET: api/Tmanufacturer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tmanufacturer>> GetTmanufacturer(long id)
        {
            var tmanufacturer = await _context.Tmanufacturer.FindAsync(id);

            if (tmanufacturer == null)
            {
                return NotFound();
            }

            return tmanufacturer;
        }

        // PUT: api/Tmanufacturer/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTmanufacturer(long id, Tmanufacturer tmanufacturer)
        {
            if (id != tmanufacturer.TmanufacturerId)
            {
                return BadRequest();
            }

            _context.Entry(tmanufacturer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TmanufacturerExists(id))
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

        // POST: api/Tmanufacturer
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tmanufacturer>> PostTmanufacturer(Tmanufacturer tmanufacturer)
        {
            _context.Tmanufacturer.Add(tmanufacturer);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TmanufacturerExists(tmanufacturer.TmanufacturerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTmanufacturer", new { id = tmanufacturer.TmanufacturerId }, tmanufacturer);
        }

        // DELETE: api/Tmanufacturer/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tmanufacturer>> DeleteTmanufacturer(long id)
        {
            var tmanufacturer = await _context.Tmanufacturer.FindAsync(id);
            if (tmanufacturer == null)
            {
                return NotFound();
            }

            _context.Tmanufacturer.Remove(tmanufacturer);
            await _context.SaveChangesAsync();

            return tmanufacturer;
        }

        private bool TmanufacturerExists(long id)
        {
            return _context.Tmanufacturer.Any(e => e.TmanufacturerId == id);
        }
    }
}
