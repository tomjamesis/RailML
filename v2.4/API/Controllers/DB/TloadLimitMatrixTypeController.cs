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
    public class TloadLimitMatrixTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TloadLimitMatrixTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TloadLimitMatrixType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TloadLimitMatrixType>>> GetTloadLimitMatrixType()
        {
            return await _context.TloadLimitMatrixType.ToListAsync();
        }

        // GET: api/TloadLimitMatrixType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TloadLimitMatrixType>> GetTloadLimitMatrixType(long id)
        {
            var tloadLimitMatrixType = await _context.TloadLimitMatrixType.FindAsync(id);

            if (tloadLimitMatrixType == null)
            {
                return NotFound();
            }

            return tloadLimitMatrixType;
        }

        // PUT: api/TloadLimitMatrixType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTloadLimitMatrixType(long id, TloadLimitMatrixType tloadLimitMatrixType)
        {
            if (id != tloadLimitMatrixType.TloadLimitMatrixTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tloadLimitMatrixType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TloadLimitMatrixTypeExists(id))
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

        // POST: api/TloadLimitMatrixType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TloadLimitMatrixType>> PostTloadLimitMatrixType(TloadLimitMatrixType tloadLimitMatrixType)
        {
            _context.TloadLimitMatrixType.Add(tloadLimitMatrixType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TloadLimitMatrixTypeExists(tloadLimitMatrixType.TloadLimitMatrixTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTloadLimitMatrixType", new { id = tloadLimitMatrixType.TloadLimitMatrixTypeId }, tloadLimitMatrixType);
        }

        // DELETE: api/TloadLimitMatrixType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TloadLimitMatrixType>> DeleteTloadLimitMatrixType(long id)
        {
            var tloadLimitMatrixType = await _context.TloadLimitMatrixType.FindAsync(id);
            if (tloadLimitMatrixType == null)
            {
                return NotFound();
            }

            _context.TloadLimitMatrixType.Remove(tloadLimitMatrixType);
            await _context.SaveChangesAsync();

            return tloadLimitMatrixType;
        }

        private bool TloadLimitMatrixTypeExists(long id)
        {
            return _context.TloadLimitMatrixType.Any(e => e.TloadLimitMatrixTypeId == id);
        }
    }
}
