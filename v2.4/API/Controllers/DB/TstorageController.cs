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
    public class TstorageController : ControllerBase
    {
        private readonly DBContext _context;

        public TstorageController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tstorage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tstorage>>> GetTstorage()
        {
            return await _context.Tstorage.ToListAsync();
        }

        // GET: api/Tstorage/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tstorage>> GetTstorage(short id)
        {
            var tstorage = await _context.Tstorage.FindAsync(id);

            if (tstorage == null)
            {
                return NotFound();
            }

            return tstorage;
        }

        // PUT: api/Tstorage/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTstorage(short id, Tstorage tstorage)
        {
            if (id != tstorage.TstorageId)
            {
                return BadRequest();
            }

            _context.Entry(tstorage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TstorageExists(id))
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

        // POST: api/Tstorage
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tstorage>> PostTstorage(Tstorage tstorage)
        {
            _context.Tstorage.Add(tstorage);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TstorageExists(tstorage.TstorageId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTstorage", new { id = tstorage.TstorageId }, tstorage);
        }

        // DELETE: api/Tstorage/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tstorage>> DeleteTstorage(short id)
        {
            var tstorage = await _context.Tstorage.FindAsync(id);
            if (tstorage == null)
            {
                return NotFound();
            }

            _context.Tstorage.Remove(tstorage);
            await _context.SaveChangesAsync();

            return tstorage;
        }

        private bool TstorageExists(short id)
        {
            return _context.Tstorage.Any(e => e.TstorageId == id);
        }
    }
}
