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
    public class EstopPostsController : ControllerBase
    {
        private readonly DBContext _context;

        public EstopPostsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EstopPosts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstopPosts>>> GetEstopPosts()
        {
            return await _context.EstopPosts.ToListAsync();
        }

        // GET: api/EstopPosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EstopPosts>> GetEstopPosts(long id)
        {
            var estopPosts = await _context.EstopPosts.FindAsync(id);

            if (estopPosts == null)
            {
                return NotFound();
            }

            return estopPosts;
        }

        // PUT: api/EstopPosts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstopPosts(long id, EstopPosts estopPosts)
        {
            if (id != estopPosts.EstopPostsId)
            {
                return BadRequest();
            }

            _context.Entry(estopPosts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstopPostsExists(id))
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

        // POST: api/EstopPosts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EstopPosts>> PostEstopPosts(EstopPosts estopPosts)
        {
            _context.EstopPosts.Add(estopPosts);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EstopPostsExists(estopPosts.EstopPostsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEstopPosts", new { id = estopPosts.EstopPostsId }, estopPosts);
        }

        // DELETE: api/EstopPosts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EstopPosts>> DeleteEstopPosts(long id)
        {
            var estopPosts = await _context.EstopPosts.FindAsync(id);
            if (estopPosts == null)
            {
                return NotFound();
            }

            _context.EstopPosts.Remove(estopPosts);
            await _context.SaveChangesAsync();

            return estopPosts;
        }

        private bool EstopPostsExists(long id)
        {
            return _context.EstopPosts.Any(e => e.EstopPostsId == id);
        }
    }
}
