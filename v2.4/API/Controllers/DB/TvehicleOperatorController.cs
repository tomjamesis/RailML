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
    public class TvehicleOperatorController : ControllerBase
    {
        private readonly DBContext _context;

        public TvehicleOperatorController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TvehicleOperator
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TvehicleOperator>>> GetTvehicleOperator()
        {
            return await _context.TvehicleOperator.ToListAsync();
        }

        // GET: api/TvehicleOperator/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TvehicleOperator>> GetTvehicleOperator(short id)
        {
            var tvehicleOperator = await _context.TvehicleOperator.FindAsync(id);

            if (tvehicleOperator == null)
            {
                return NotFound();
            }

            return tvehicleOperator;
        }

        // PUT: api/TvehicleOperator/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTvehicleOperator(short id, TvehicleOperator tvehicleOperator)
        {
            if (id != tvehicleOperator.TvehicleOperatorId)
            {
                return BadRequest();
            }

            _context.Entry(tvehicleOperator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TvehicleOperatorExists(id))
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

        // POST: api/TvehicleOperator
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TvehicleOperator>> PostTvehicleOperator(TvehicleOperator tvehicleOperator)
        {
            _context.TvehicleOperator.Add(tvehicleOperator);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TvehicleOperatorExists(tvehicleOperator.TvehicleOperatorId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTvehicleOperator", new { id = tvehicleOperator.TvehicleOperatorId }, tvehicleOperator);
        }

        // DELETE: api/TvehicleOperator/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TvehicleOperator>> DeleteTvehicleOperator(short id)
        {
            var tvehicleOperator = await _context.TvehicleOperator.FindAsync(id);
            if (tvehicleOperator == null)
            {
                return NotFound();
            }

            _context.TvehicleOperator.Remove(tvehicleOperator);
            await _context.SaveChangesAsync();

            return tvehicleOperator;
        }

        private bool TvehicleOperatorExists(short id)
        {
            return _context.TvehicleOperator.Any(e => e.TvehicleOperatorId == id);
        }
    }
}
