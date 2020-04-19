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
    public class EoperatingPeriodRefController : ControllerBase
    {
        private readonly DBContext _context;

        public EoperatingPeriodRefController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EoperatingPeriodRef
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EoperatingPeriodRef>>> GetEoperatingPeriodRef()
        {
            return await _context.EoperatingPeriodRef.ToListAsync();
        }

        // GET: api/EoperatingPeriodRef/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EoperatingPeriodRef>> GetEoperatingPeriodRef(short id)
        {
            var eoperatingPeriodRef = await _context.EoperatingPeriodRef.FindAsync(id);

            if (eoperatingPeriodRef == null)
            {
                return NotFound();
            }

            return eoperatingPeriodRef;
        }

        // PUT: api/EoperatingPeriodRef/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEoperatingPeriodRef(short id, EoperatingPeriodRef eoperatingPeriodRef)
        {
            if (id != eoperatingPeriodRef.EoperatingPeriodRefId)
            {
                return BadRequest();
            }

            _context.Entry(eoperatingPeriodRef).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EoperatingPeriodRefExists(id))
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

        // POST: api/EoperatingPeriodRef
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EoperatingPeriodRef>> PostEoperatingPeriodRef(EoperatingPeriodRef eoperatingPeriodRef)
        {
            _context.EoperatingPeriodRef.Add(eoperatingPeriodRef);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EoperatingPeriodRefExists(eoperatingPeriodRef.EoperatingPeriodRefId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEoperatingPeriodRef", new { id = eoperatingPeriodRef.EoperatingPeriodRefId }, eoperatingPeriodRef);
        }

        // DELETE: api/EoperatingPeriodRef/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EoperatingPeriodRef>> DeleteEoperatingPeriodRef(short id)
        {
            var eoperatingPeriodRef = await _context.EoperatingPeriodRef.FindAsync(id);
            if (eoperatingPeriodRef == null)
            {
                return NotFound();
            }

            _context.EoperatingPeriodRef.Remove(eoperatingPeriodRef);
            await _context.SaveChangesAsync();

            return eoperatingPeriodRef;
        }

        private bool EoperatingPeriodRefExists(short id)
        {
            return _context.EoperatingPeriodRef.Any(e => e.EoperatingPeriodRefId == id);
        }
    }
}
