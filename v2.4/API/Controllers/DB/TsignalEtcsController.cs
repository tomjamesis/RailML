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
    public class TsignalEtcsController : ControllerBase
    {
        private readonly DBContext _context;

        public TsignalEtcsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TsignalEtcs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TsignalEtcs>>> GetTsignalEtcs()
        {
            return await _context.TsignalEtcs.ToListAsync();
        }

        // GET: api/TsignalEtcs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TsignalEtcs>> GetTsignalEtcs(short id)
        {
            var tsignalEtcs = await _context.TsignalEtcs.FindAsync(id);

            if (tsignalEtcs == null)
            {
                return NotFound();
            }

            return tsignalEtcs;
        }

        // PUT: api/TsignalEtcs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTsignalEtcs(short id, TsignalEtcs tsignalEtcs)
        {
            if (id != tsignalEtcs.TsignalEtcsId)
            {
                return BadRequest();
            }

            _context.Entry(tsignalEtcs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TsignalEtcsExists(id))
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

        // POST: api/TsignalEtcs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TsignalEtcs>> PostTsignalEtcs(TsignalEtcs tsignalEtcs)
        {
            _context.TsignalEtcs.Add(tsignalEtcs);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TsignalEtcsExists(tsignalEtcs.TsignalEtcsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTsignalEtcs", new { id = tsignalEtcs.TsignalEtcsId }, tsignalEtcs);
        }

        // DELETE: api/TsignalEtcs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TsignalEtcs>> DeleteTsignalEtcs(short id)
        {
            var tsignalEtcs = await _context.TsignalEtcs.FindAsync(id);
            if (tsignalEtcs == null)
            {
                return NotFound();
            }

            _context.TsignalEtcs.Remove(tsignalEtcs);
            await _context.SaveChangesAsync();

            return tsignalEtcs;
        }

        private bool TsignalEtcsExists(short id)
        {
            return _context.TsignalEtcs.Any(e => e.TsignalEtcsId == id);
        }
    }
}
