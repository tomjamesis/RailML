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
    public class EdoorsController : ControllerBase
    {
        private readonly DBContext _context;

        public EdoorsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Edoors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Edoors>>> GetEdoors()
        {
            return await _context.Edoors.ToListAsync();
        }

        // GET: api/Edoors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Edoors>> GetEdoors(short id)
        {
            var edoors = await _context.Edoors.FindAsync(id);

            if (edoors == null)
            {
                return NotFound();
            }

            return edoors;
        }

        // PUT: api/Edoors/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEdoors(short id, Edoors edoors)
        {
            if (id != edoors.EdoorsId)
            {
                return BadRequest();
            }

            _context.Entry(edoors).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EdoorsExists(id))
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

        // POST: api/Edoors
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Edoors>> PostEdoors(Edoors edoors)
        {
            _context.Edoors.Add(edoors);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EdoorsExists(edoors.EdoorsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEdoors", new { id = edoors.EdoorsId }, edoors);
        }

        // DELETE: api/Edoors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Edoors>> DeleteEdoors(short id)
        {
            var edoors = await _context.Edoors.FindAsync(id);
            if (edoors == null)
            {
                return NotFound();
            }

            _context.Edoors.Remove(edoors);
            await _context.SaveChangesAsync();

            return edoors;
        }

        private bool EdoorsExists(short id)
        {
            return _context.Edoors.Any(e => e.EdoorsId == id);
        }
    }
}
