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
    public class TcurvingLimitationTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TcurvingLimitationTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TcurvingLimitationType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TcurvingLimitationType>>> GetTcurvingLimitationType()
        {
            return await _context.TcurvingLimitationType.ToListAsync();
        }

        // GET: api/TcurvingLimitationType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TcurvingLimitationType>> GetTcurvingLimitationType(long id)
        {
            var tcurvingLimitationType = await _context.TcurvingLimitationType.FindAsync(id);

            if (tcurvingLimitationType == null)
            {
                return NotFound();
            }

            return tcurvingLimitationType;
        }

        // PUT: api/TcurvingLimitationType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTcurvingLimitationType(long id, TcurvingLimitationType tcurvingLimitationType)
        {
            if (id != tcurvingLimitationType.TcurvingLimitationTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tcurvingLimitationType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TcurvingLimitationTypeExists(id))
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

        // POST: api/TcurvingLimitationType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TcurvingLimitationType>> PostTcurvingLimitationType(TcurvingLimitationType tcurvingLimitationType)
        {
            _context.TcurvingLimitationType.Add(tcurvingLimitationType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TcurvingLimitationTypeExists(tcurvingLimitationType.TcurvingLimitationTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTcurvingLimitationType", new { id = tcurvingLimitationType.TcurvingLimitationTypeId }, tcurvingLimitationType);
        }

        // DELETE: api/TcurvingLimitationType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TcurvingLimitationType>> DeleteTcurvingLimitationType(long id)
        {
            var tcurvingLimitationType = await _context.TcurvingLimitationType.FindAsync(id);
            if (tcurvingLimitationType == null)
            {
                return NotFound();
            }

            _context.TcurvingLimitationType.Remove(tcurvingLimitationType);
            await _context.SaveChangesAsync();

            return tcurvingLimitationType;
        }

        private bool TcurvingLimitationTypeExists(long id)
        {
            return _context.TcurvingLimitationType.Any(e => e.TcurvingLimitationTypeId == id);
        }
    }
}
