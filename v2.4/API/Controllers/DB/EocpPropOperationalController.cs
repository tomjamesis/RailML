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
    public class EocpPropOperationalController : ControllerBase
    {
        private readonly DBContext _context;

        public EocpPropOperationalController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EocpPropOperational
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EocpPropOperational>>> GetEocpPropOperational()
        {
            return await _context.EocpPropOperational.ToListAsync();
        }

        // GET: api/EocpPropOperational/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EocpPropOperational>> GetEocpPropOperational(short id)
        {
            var eocpPropOperational = await _context.EocpPropOperational.FindAsync(id);

            if (eocpPropOperational == null)
            {
                return NotFound();
            }

            return eocpPropOperational;
        }

        // PUT: api/EocpPropOperational/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEocpPropOperational(short id, EocpPropOperational eocpPropOperational)
        {
            if (id != eocpPropOperational.EocpPropOperationalId)
            {
                return BadRequest();
            }

            _context.Entry(eocpPropOperational).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EocpPropOperationalExists(id))
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

        // POST: api/EocpPropOperational
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EocpPropOperational>> PostEocpPropOperational(EocpPropOperational eocpPropOperational)
        {
            _context.EocpPropOperational.Add(eocpPropOperational);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EocpPropOperationalExists(eocpPropOperational.EocpPropOperationalId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEocpPropOperational", new { id = eocpPropOperational.EocpPropOperationalId }, eocpPropOperational);
        }

        // DELETE: api/EocpPropOperational/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EocpPropOperational>> DeleteEocpPropOperational(short id)
        {
            var eocpPropOperational = await _context.EocpPropOperational.FindAsync(id);
            if (eocpPropOperational == null)
            {
                return NotFound();
            }

            _context.EocpPropOperational.Remove(eocpPropOperational);
            await _context.SaveChangesAsync();

            return eocpPropOperational;
        }

        private bool EocpPropOperationalExists(short id)
        {
            return _context.EocpPropOperational.Any(e => e.EocpPropOperationalId == id);
        }
    }
}
