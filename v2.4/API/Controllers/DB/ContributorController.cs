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
    public class ContributorController : ControllerBase
    {
        private readonly DBContext _context;

        public ContributorController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Contributor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contributor>>> GetContributor()
        {
            return await _context.Contributor.ToListAsync();
        }

        // GET: api/Contributor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contributor>> GetContributor(short id)
        {
            var contributor = await _context.Contributor.FindAsync(id);

            if (contributor == null)
            {
                return NotFound();
            }

            return contributor;
        }

        // PUT: api/Contributor/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContributor(short id, Contributor contributor)
        {
            if (id != contributor.ContributorId)
            {
                return BadRequest();
            }

            _context.Entry(contributor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContributorExists(id))
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

        // POST: api/Contributor
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Contributor>> PostContributor(Contributor contributor)
        {
            _context.Contributor.Add(contributor);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ContributorExists(contributor.ContributorId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetContributor", new { id = contributor.ContributorId }, contributor);
        }

        // DELETE: api/Contributor/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Contributor>> DeleteContributor(short id)
        {
            var contributor = await _context.Contributor.FindAsync(id);
            if (contributor == null)
            {
                return NotFound();
            }

            _context.Contributor.Remove(contributor);
            await _context.SaveChangesAsync();

            return contributor;
        }

        private bool ContributorExists(short id)
        {
            return _context.Contributor.Any(e => e.ContributorId == id);
        }
    }
}
