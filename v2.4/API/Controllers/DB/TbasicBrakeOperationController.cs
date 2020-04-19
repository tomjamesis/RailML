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
    public class TbasicBrakeOperationController : ControllerBase
    {
        private readonly DBContext _context;

        public TbasicBrakeOperationController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TbasicBrakeOperation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbasicBrakeOperation>>> GetTbasicBrakeOperation()
        {
            return await _context.TbasicBrakeOperation.ToListAsync();
        }

        // GET: api/TbasicBrakeOperation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbasicBrakeOperation>> GetTbasicBrakeOperation(long id)
        {
            var tbasicBrakeOperation = await _context.TbasicBrakeOperation.FindAsync(id);

            if (tbasicBrakeOperation == null)
            {
                return NotFound();
            }

            return tbasicBrakeOperation;
        }

        // PUT: api/TbasicBrakeOperation/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbasicBrakeOperation(long id, TbasicBrakeOperation tbasicBrakeOperation)
        {
            if (id != tbasicBrakeOperation.TbasicBrakeOperationId)
            {
                return BadRequest();
            }

            _context.Entry(tbasicBrakeOperation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbasicBrakeOperationExists(id))
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

        // POST: api/TbasicBrakeOperation
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TbasicBrakeOperation>> PostTbasicBrakeOperation(TbasicBrakeOperation tbasicBrakeOperation)
        {
            _context.TbasicBrakeOperation.Add(tbasicBrakeOperation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbasicBrakeOperationExists(tbasicBrakeOperation.TbasicBrakeOperationId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbasicBrakeOperation", new { id = tbasicBrakeOperation.TbasicBrakeOperationId }, tbasicBrakeOperation);
        }

        // DELETE: api/TbasicBrakeOperation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbasicBrakeOperation>> DeleteTbasicBrakeOperation(long id)
        {
            var tbasicBrakeOperation = await _context.TbasicBrakeOperation.FindAsync(id);
            if (tbasicBrakeOperation == null)
            {
                return NotFound();
            }

            _context.TbasicBrakeOperation.Remove(tbasicBrakeOperation);
            await _context.SaveChangesAsync();

            return tbasicBrakeOperation;
        }

        private bool TbasicBrakeOperationExists(long id)
        {
            return _context.TbasicBrakeOperation.Any(e => e.TbasicBrakeOperationId == id);
        }
    }
}
