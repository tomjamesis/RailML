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
    public class RailmlController : ControllerBase
    {
        private readonly DBContext _context;

        public RailmlController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Railml
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Railml>>> GetRailml()
        {
            return await _context.Railml.ToListAsync();
        }

        // GET: api/Railml/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Railml>> GetRailml(long id)
        {
            var railml = await _context.Railml.FindAsync(id);

            if (railml == null)
            {
                return NotFound();
            }

            return railml;
        }

        // PUT: api/Railml/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRailml(long id, Railml railml)
        {
            if (id != railml.RailmlId)
            {
                return BadRequest();
            }

            _context.Entry(railml).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RailmlExists(id))
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

        // POST: api/Railml
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Railml>> PostRailml(Railml railml)
        {
            _context.Railml.Add(railml);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RailmlExists(railml.RailmlId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRailml", new { id = railml.RailmlId }, railml);
        }

        // DELETE: api/Railml/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Railml>> DeleteRailml(long id)
        {
            var railml = await _context.Railml.FindAsync(id);
            if (railml == null)
            {
                return NotFound();
            }

            _context.Railml.Remove(railml);
            await _context.SaveChangesAsync();

            return railml;
        }

        private bool RailmlExists(long id)
        {
            return _context.Railml.Any(e => e.RailmlId == id);
        }
    }
}
