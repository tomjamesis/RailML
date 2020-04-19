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
    public class TsignalBaseController : ControllerBase
    {
        private readonly DBContext _context;

        public TsignalBaseController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TsignalBase
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TsignalBase>>> GetTsignalBase()
        {
            return await _context.TsignalBase.ToListAsync();
        }

        // GET: api/TsignalBase/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TsignalBase>> GetTsignalBase(long id)
        {
            var tsignalBase = await _context.TsignalBase.FindAsync(id);

            if (tsignalBase == null)
            {
                return NotFound();
            }

            return tsignalBase;
        }

        // PUT: api/TsignalBase/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTsignalBase(long id, TsignalBase tsignalBase)
        {
            if (id != tsignalBase.TsignalBaseId)
            {
                return BadRequest();
            }

            _context.Entry(tsignalBase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TsignalBaseExists(id))
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

        // POST: api/TsignalBase
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TsignalBase>> PostTsignalBase(TsignalBase tsignalBase)
        {
            _context.TsignalBase.Add(tsignalBase);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TsignalBaseExists(tsignalBase.TsignalBaseId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTsignalBase", new { id = tsignalBase.TsignalBaseId }, tsignalBase);
        }

        // DELETE: api/TsignalBase/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TsignalBase>> DeleteTsignalBase(long id)
        {
            var tsignalBase = await _context.TsignalBase.FindAsync(id);
            if (tsignalBase == null)
            {
                return NotFound();
            }

            _context.TsignalBase.Remove(tsignalBase);
            await _context.SaveChangesAsync();

            return tsignalBase;
        }

        private bool TsignalBaseExists(long id)
        {
            return _context.TsignalBase.Any(e => e.TsignalBaseId == id);
        }
    }
}
