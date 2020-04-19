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
    public class ElocallyControlledAreaController : ControllerBase
    {
        private readonly DBContext _context;

        public ElocallyControlledAreaController(DBContext context)
        {
            _context = context;
        }

        // GET: api/ElocallyControlledArea
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ElocallyControlledArea>>> GetElocallyControlledArea()
        {
            return await _context.ElocallyControlledArea.ToListAsync();
        }

        // GET: api/ElocallyControlledArea/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ElocallyControlledArea>> GetElocallyControlledArea(short id)
        {
            var elocallyControlledArea = await _context.ElocallyControlledArea.FindAsync(id);

            if (elocallyControlledArea == null)
            {
                return NotFound();
            }

            return elocallyControlledArea;
        }

        // PUT: api/ElocallyControlledArea/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElocallyControlledArea(short id, ElocallyControlledArea elocallyControlledArea)
        {
            if (id != elocallyControlledArea.ElocallyControlledAreaId)
            {
                return BadRequest();
            }

            _context.Entry(elocallyControlledArea).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElocallyControlledAreaExists(id))
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

        // POST: api/ElocallyControlledArea
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ElocallyControlledArea>> PostElocallyControlledArea(ElocallyControlledArea elocallyControlledArea)
        {
            _context.ElocallyControlledArea.Add(elocallyControlledArea);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ElocallyControlledAreaExists(elocallyControlledArea.ElocallyControlledAreaId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetElocallyControlledArea", new { id = elocallyControlledArea.ElocallyControlledAreaId }, elocallyControlledArea);
        }

        // DELETE: api/ElocallyControlledArea/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ElocallyControlledArea>> DeleteElocallyControlledArea(short id)
        {
            var elocallyControlledArea = await _context.ElocallyControlledArea.FindAsync(id);
            if (elocallyControlledArea == null)
            {
                return NotFound();
            }

            _context.ElocallyControlledArea.Remove(elocallyControlledArea);
            await _context.SaveChangesAsync();

            return elocallyControlledArea;
        }

        private bool ElocallyControlledAreaExists(short id)
        {
            return _context.ElocallyControlledArea.Any(e => e.ElocallyControlledAreaId == id);
        }
    }
}
