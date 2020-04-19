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
    public class TloadLimitTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TloadLimitTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TloadLimitType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TloadLimitType>>> GetTloadLimitType()
        {
            return await _context.TloadLimitType.ToListAsync();
        }

        // GET: api/TloadLimitType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TloadLimitType>> GetTloadLimitType(long id)
        {
            var tloadLimitType = await _context.TloadLimitType.FindAsync(id);

            if (tloadLimitType == null)
            {
                return NotFound();
            }

            return tloadLimitType;
        }

        // PUT: api/TloadLimitType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTloadLimitType(long id, TloadLimitType tloadLimitType)
        {
            if (id != tloadLimitType.TloadLimitTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tloadLimitType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TloadLimitTypeExists(id))
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

        // POST: api/TloadLimitType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TloadLimitType>> PostTloadLimitType(TloadLimitType tloadLimitType)
        {
            _context.TloadLimitType.Add(tloadLimitType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TloadLimitTypeExists(tloadLimitType.TloadLimitTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTloadLimitType", new { id = tloadLimitType.TloadLimitTypeId }, tloadLimitType);
        }

        // DELETE: api/TloadLimitType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TloadLimitType>> DeleteTloadLimitType(long id)
        {
            var tloadLimitType = await _context.TloadLimitType.FindAsync(id);
            if (tloadLimitType == null)
            {
                return NotFound();
            }

            _context.TloadLimitType.Remove(tloadLimitType);
            await _context.SaveChangesAsync();

            return tloadLimitType;
        }

        private bool TloadLimitTypeExists(long id)
        {
            return _context.TloadLimitType.Any(e => e.TloadLimitTypeId == id);
        }
    }
}
