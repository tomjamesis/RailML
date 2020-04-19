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
    public class EloadLimitController : ControllerBase
    {
        private readonly DBContext _context;

        public EloadLimitController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EloadLimit
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EloadLimit>>> GetEloadLimit()
        {
            return await _context.EloadLimit.ToListAsync();
        }

        // GET: api/EloadLimit/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EloadLimit>> GetEloadLimit(short id)
        {
            var eloadLimit = await _context.EloadLimit.FindAsync(id);

            if (eloadLimit == null)
            {
                return NotFound();
            }

            return eloadLimit;
        }

        // PUT: api/EloadLimit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEloadLimit(short id, EloadLimit eloadLimit)
        {
            if (id != eloadLimit.EloadLimitId)
            {
                return BadRequest();
            }

            _context.Entry(eloadLimit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EloadLimitExists(id))
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

        // POST: api/EloadLimit
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EloadLimit>> PostEloadLimit(EloadLimit eloadLimit)
        {
            _context.EloadLimit.Add(eloadLimit);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EloadLimitExists(eloadLimit.EloadLimitId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEloadLimit", new { id = eloadLimit.EloadLimitId }, eloadLimit);
        }

        // DELETE: api/EloadLimit/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EloadLimit>> DeleteEloadLimit(short id)
        {
            var eloadLimit = await _context.EloadLimit.FindAsync(id);
            if (eloadLimit == null)
            {
                return NotFound();
            }

            _context.EloadLimit.Remove(eloadLimit);
            await _context.SaveChangesAsync();

            return eloadLimit;
        }

        private bool EloadLimitExists(short id)
        {
            return _context.EloadLimit.Any(e => e.EloadLimitId == id);
        }
    }
}
