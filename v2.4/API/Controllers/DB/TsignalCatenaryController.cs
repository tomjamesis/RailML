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
    public class TsignalCatenaryController : ControllerBase
    {
        private readonly DBContext _context;

        public TsignalCatenaryController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TsignalCatenary
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TsignalCatenary>>> GetTsignalCatenary()
        {
            return await _context.TsignalCatenary.ToListAsync();
        }

        // GET: api/TsignalCatenary/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TsignalCatenary>> GetTsignalCatenary(short id)
        {
            var tsignalCatenary = await _context.TsignalCatenary.FindAsync(id);

            if (tsignalCatenary == null)
            {
                return NotFound();
            }

            return tsignalCatenary;
        }

        // PUT: api/TsignalCatenary/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTsignalCatenary(short id, TsignalCatenary tsignalCatenary)
        {
            if (id != tsignalCatenary.TsignalCatenaryId)
            {
                return BadRequest();
            }

            _context.Entry(tsignalCatenary).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TsignalCatenaryExists(id))
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

        // POST: api/TsignalCatenary
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TsignalCatenary>> PostTsignalCatenary(TsignalCatenary tsignalCatenary)
        {
            _context.TsignalCatenary.Add(tsignalCatenary);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TsignalCatenaryExists(tsignalCatenary.TsignalCatenaryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTsignalCatenary", new { id = tsignalCatenary.TsignalCatenaryId }, tsignalCatenary);
        }

        // DELETE: api/TsignalCatenary/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TsignalCatenary>> DeleteTsignalCatenary(short id)
        {
            var tsignalCatenary = await _context.TsignalCatenary.FindAsync(id);
            if (tsignalCatenary == null)
            {
                return NotFound();
            }

            _context.TsignalCatenary.Remove(tsignalCatenary);
            await _context.SaveChangesAsync();

            return tsignalCatenary;
        }

        private bool TsignalCatenaryExists(short id)
        {
            return _context.TsignalCatenary.Any(e => e.TsignalCatenaryId == id);
        }
    }
}
