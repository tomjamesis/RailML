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
    public class CreatorController : ControllerBase
    {
        private readonly DBContext _context;

        public CreatorController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Creator
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Creator>>> GetCreator()
        {
            return await _context.Creator.ToListAsync();
        }

        // GET: api/Creator/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Creator>> GetCreator(short id)
        {
            var creator = await _context.Creator.FindAsync(id);

            if (creator == null)
            {
                return NotFound();
            }

            return creator;
        }

        // PUT: api/Creator/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCreator(short id, Creator creator)
        {
            if (id != creator.CreatorId)
            {
                return BadRequest();
            }

            _context.Entry(creator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CreatorExists(id))
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

        // POST: api/Creator
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Creator>> PostCreator(Creator creator)
        {
            _context.Creator.Add(creator);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CreatorExists(creator.CreatorId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCreator", new { id = creator.CreatorId }, creator);
        }

        // DELETE: api/Creator/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Creator>> DeleteCreator(short id)
        {
            var creator = await _context.Creator.FindAsync(id);
            if (creator == null)
            {
                return NotFound();
            }

            _context.Creator.Remove(creator);
            await _context.SaveChangesAsync();

            return creator;
        }

        private bool CreatorExists(short id)
        {
            return _context.Creator.Any(e => e.CreatorId == id);
        }
    }
}
