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
    public class TcategoryController : ControllerBase
    {
        private readonly DBContext _context;

        public TcategoryController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tcategory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tcategory>>> GetTcategory()
        {
            return await _context.Tcategory.ToListAsync();
        }

        // GET: api/Tcategory/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tcategory>> GetTcategory(short id)
        {
            var tcategory = await _context.Tcategory.FindAsync(id);

            if (tcategory == null)
            {
                return NotFound();
            }

            return tcategory;
        }

        // PUT: api/Tcategory/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTcategory(short id, Tcategory tcategory)
        {
            if (id != tcategory.TcategoryId)
            {
                return BadRequest();
            }

            _context.Entry(tcategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TcategoryExists(id))
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

        // POST: api/Tcategory
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tcategory>> PostTcategory(Tcategory tcategory)
        {
            _context.Tcategory.Add(tcategory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TcategoryExists(tcategory.TcategoryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTcategory", new { id = tcategory.TcategoryId }, tcategory);
        }

        // DELETE: api/Tcategory/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tcategory>> DeleteTcategory(short id)
        {
            var tcategory = await _context.Tcategory.FindAsync(id);
            if (tcategory == null)
            {
                return NotFound();
            }

            _context.Tcategory.Remove(tcategory);
            await _context.SaveChangesAsync();

            return tcategory;
        }

        private bool TcategoryExists(short id)
        {
            return _context.Tcategory.Any(e => e.TcategoryId == id);
        }
    }
}
