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
    public class TstopPostController : ControllerBase
    {
        private readonly DBContext _context;

        public TstopPostController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TstopPost
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TstopPost>>> GetTstopPost()
        {
            return await _context.TstopPost.ToListAsync();
        }

        // GET: api/TstopPost/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TstopPost>> GetTstopPost(short id)
        {
            var tstopPost = await _context.TstopPost.FindAsync(id);

            if (tstopPost == null)
            {
                return NotFound();
            }

            return tstopPost;
        }

        // PUT: api/TstopPost/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTstopPost(short id, TstopPost tstopPost)
        {
            if (id != tstopPost.TstopPostId)
            {
                return BadRequest();
            }

            _context.Entry(tstopPost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TstopPostExists(id))
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

        // POST: api/TstopPost
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TstopPost>> PostTstopPost(TstopPost tstopPost)
        {
            _context.TstopPost.Add(tstopPost);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TstopPostExists(tstopPost.TstopPostId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTstopPost", new { id = tstopPost.TstopPostId }, tstopPost);
        }

        // DELETE: api/TstopPost/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TstopPost>> DeleteTstopPost(short id)
        {
            var tstopPost = await _context.TstopPost.FindAsync(id);
            if (tstopPost == null)
            {
                return NotFound();
            }

            _context.TstopPost.Remove(tstopPost);
            await _context.SaveChangesAsync();

            return tstopPost;
        }

        private bool TstopPostExists(short id)
        {
            return _context.TstopPost.Any(e => e.TstopPostId == id);
        }
    }
}
