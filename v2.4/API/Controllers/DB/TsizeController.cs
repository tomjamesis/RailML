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
    public class TsizeController : ControllerBase
    {
        private readonly DBContext _context;

        public TsizeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tsize
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tsize>>> GetTsize()
        {
            return await _context.Tsize.ToListAsync();
        }

        // GET: api/Tsize/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tsize>> GetTsize(long id)
        {
            var tsize = await _context.Tsize.FindAsync(id);

            if (tsize == null)
            {
                return NotFound();
            }

            return tsize;
        }

        // PUT: api/Tsize/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTsize(long id, Tsize tsize)
        {
            if (id != tsize.TsizeId)
            {
                return BadRequest();
            }

            _context.Entry(tsize).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TsizeExists(id))
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

        // POST: api/Tsize
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tsize>> PostTsize(Tsize tsize)
        {
            _context.Tsize.Add(tsize);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TsizeExists(tsize.TsizeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTsize", new { id = tsize.TsizeId }, tsize);
        }

        // DELETE: api/Tsize/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tsize>> DeleteTsize(long id)
        {
            var tsize = await _context.Tsize.FindAsync(id);
            if (tsize == null)
            {
                return NotFound();
            }

            _context.Tsize.Remove(tsize);
            await _context.SaveChangesAsync();

            return tsize;
        }

        private bool TsizeExists(long id)
        {
            return _context.Tsize.Any(e => e.TsizeId == id);
        }
    }
}
