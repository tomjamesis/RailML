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
    public class TypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Type
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.DB.Type>>> GetType()
        {
            return await _context.Type.ToListAsync();
        }

        // GET: api/Type/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Models.DB.Type>> GetType(short id)
        {
            var @type = await _context.Type.FindAsync(id);

            if (@type == null)
            {
                return NotFound();
            }

            return @type;
        }

        // PUT: api/Type/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutType(short id, Models.DB.Type @type)
        {
            if (id != @type.TypeId)
            {
                return BadRequest();
            }

            _context.Entry(@type).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeExists(id))
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

        // POST: api/Type
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Models.DB.Type>> PostType(Models.DB.Type @type)
        {
            _context.Type.Add(@type);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TypeExists(@type.TypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetType", new { id = @type.TypeId }, @type);
        }

        // DELETE: api/Type/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Models.DB.Type>> DeleteType(short id)
        {
            var @type = await _context.Type.FindAsync(id);
            if (@type == null)
            {
                return NotFound();
            }

            _context.Type.Remove(@type);
            await _context.SaveChangesAsync();

            return @type;
        }

        private bool TypeExists(short id)
        {
            return _context.Type.Any(e => e.TypeId == id);
        }
    }
}
