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
    public class ToperatingPeriodRefController : ControllerBase
    {
        private readonly DBContext _context;

        public ToperatingPeriodRefController(DBContext context)
        {
            _context = context;
        }

        // GET: api/ToperatingPeriodRef
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToperatingPeriodRef>>> GetToperatingPeriodRef()
        {
            return await _context.ToperatingPeriodRef.ToListAsync();
        }

        // GET: api/ToperatingPeriodRef/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ToperatingPeriodRef>> GetToperatingPeriodRef(short id)
        {
            var toperatingPeriodRef = await _context.ToperatingPeriodRef.FindAsync(id);

            if (toperatingPeriodRef == null)
            {
                return NotFound();
            }

            return toperatingPeriodRef;
        }

        // PUT: api/ToperatingPeriodRef/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToperatingPeriodRef(short id, ToperatingPeriodRef toperatingPeriodRef)
        {
            if (id != toperatingPeriodRef.ToperatingPeriodRefId)
            {
                return BadRequest();
            }

            _context.Entry(toperatingPeriodRef).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToperatingPeriodRefExists(id))
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

        // POST: api/ToperatingPeriodRef
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ToperatingPeriodRef>> PostToperatingPeriodRef(ToperatingPeriodRef toperatingPeriodRef)
        {
            _context.ToperatingPeriodRef.Add(toperatingPeriodRef);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ToperatingPeriodRefExists(toperatingPeriodRef.ToperatingPeriodRefId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetToperatingPeriodRef", new { id = toperatingPeriodRef.ToperatingPeriodRefId }, toperatingPeriodRef);
        }

        // DELETE: api/ToperatingPeriodRef/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ToperatingPeriodRef>> DeleteToperatingPeriodRef(short id)
        {
            var toperatingPeriodRef = await _context.ToperatingPeriodRef.FindAsync(id);
            if (toperatingPeriodRef == null)
            {
                return NotFound();
            }

            _context.ToperatingPeriodRef.Remove(toperatingPeriodRef);
            await _context.SaveChangesAsync();

            return toperatingPeriodRef;
        }

        private bool ToperatingPeriodRefExists(short id)
        {
            return _context.ToperatingPeriodRef.Any(e => e.ToperatingPeriodRefId == id);
        }
    }
}
