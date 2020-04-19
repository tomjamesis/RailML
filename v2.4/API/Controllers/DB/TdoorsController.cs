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
    public class TdoorsController : ControllerBase
    {
        private readonly DBContext _context;

        public TdoorsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tdoors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tdoors>>> GetTdoors()
        {
            return await _context.Tdoors.ToListAsync();
        }

        // GET: api/Tdoors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tdoors>> GetTdoors(long id)
        {
            var tdoors = await _context.Tdoors.FindAsync(id);

            if (tdoors == null)
            {
                return NotFound();
            }

            return tdoors;
        }

        // PUT: api/Tdoors/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdoors(long id, Tdoors tdoors)
        {
            if (id != tdoors.TdoorsId)
            {
                return BadRequest();
            }

            _context.Entry(tdoors).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdoorsExists(id))
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

        // POST: api/Tdoors
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tdoors>> PostTdoors(Tdoors tdoors)
        {
            _context.Tdoors.Add(tdoors);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TdoorsExists(tdoors.TdoorsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTdoors", new { id = tdoors.TdoorsId }, tdoors);
        }

        // DELETE: api/Tdoors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tdoors>> DeleteTdoors(long id)
        {
            var tdoors = await _context.Tdoors.FindAsync(id);
            if (tdoors == null)
            {
                return NotFound();
            }

            _context.Tdoors.Remove(tdoors);
            await _context.SaveChangesAsync();

            return tdoors;
        }

        private bool TdoorsExists(long id)
        {
            return _context.Tdoors.Any(e => e.TdoorsId == id);
        }
    }
}
