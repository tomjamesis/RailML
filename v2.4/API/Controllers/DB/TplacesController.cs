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
    public class TplacesController : ControllerBase
    {
        private readonly DBContext _context;

        public TplacesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tplaces
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tplaces>>> GetTplaces()
        {
            return await _context.Tplaces.ToListAsync();
        }

        // GET: api/Tplaces/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tplaces>> GetTplaces(long id)
        {
            var tplaces = await _context.Tplaces.FindAsync(id);

            if (tplaces == null)
            {
                return NotFound();
            }

            return tplaces;
        }

        // PUT: api/Tplaces/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTplaces(long id, Tplaces tplaces)
        {
            if (id != tplaces.TplacesId)
            {
                return BadRequest();
            }

            _context.Entry(tplaces).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TplacesExists(id))
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

        // POST: api/Tplaces
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tplaces>> PostTplaces(Tplaces tplaces)
        {
            _context.Tplaces.Add(tplaces);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TplacesExists(tplaces.TplacesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTplaces", new { id = tplaces.TplacesId }, tplaces);
        }

        // DELETE: api/Tplaces/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tplaces>> DeleteTplaces(long id)
        {
            var tplaces = await _context.Tplaces.FindAsync(id);
            if (tplaces == null)
            {
                return NotFound();
            }

            _context.Tplaces.Remove(tplaces);
            await _context.SaveChangesAsync();

            return tplaces;
        }

        private bool TplacesExists(long id)
        {
            return _context.Tplaces.Any(e => e.TplacesId == id);
        }
    }
}
