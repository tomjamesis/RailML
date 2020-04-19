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
    public class TsignalMilepostController : ControllerBase
    {
        private readonly DBContext _context;

        public TsignalMilepostController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TsignalMilepost
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TsignalMilepost>>> GetTsignalMilepost()
        {
            return await _context.TsignalMilepost.ToListAsync();
        }

        // GET: api/TsignalMilepost/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TsignalMilepost>> GetTsignalMilepost(short id)
        {
            var tsignalMilepost = await _context.TsignalMilepost.FindAsync(id);

            if (tsignalMilepost == null)
            {
                return NotFound();
            }

            return tsignalMilepost;
        }

        // PUT: api/TsignalMilepost/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTsignalMilepost(short id, TsignalMilepost tsignalMilepost)
        {
            if (id != tsignalMilepost.TsignalMilepostId)
            {
                return BadRequest();
            }

            _context.Entry(tsignalMilepost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TsignalMilepostExists(id))
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

        // POST: api/TsignalMilepost
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TsignalMilepost>> PostTsignalMilepost(TsignalMilepost tsignalMilepost)
        {
            _context.TsignalMilepost.Add(tsignalMilepost);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TsignalMilepostExists(tsignalMilepost.TsignalMilepostId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTsignalMilepost", new { id = tsignalMilepost.TsignalMilepostId }, tsignalMilepost);
        }

        // DELETE: api/TsignalMilepost/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TsignalMilepost>> DeleteTsignalMilepost(short id)
        {
            var tsignalMilepost = await _context.TsignalMilepost.FindAsync(id);
            if (tsignalMilepost == null)
            {
                return NotFound();
            }

            _context.TsignalMilepost.Remove(tsignalMilepost);
            await _context.SaveChangesAsync();

            return tsignalMilepost;
        }

        private bool TsignalMilepostExists(short id)
        {
            return _context.TsignalMilepost.Any(e => e.TsignalMilepostId == id);
        }
    }
}
