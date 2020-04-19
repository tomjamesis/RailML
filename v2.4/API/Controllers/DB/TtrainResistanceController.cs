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
    public class TtrainResistanceController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainResistanceController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrainResistance
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrainResistance>>> GetTtrainResistance()
        {
            return await _context.TtrainResistance.ToListAsync();
        }

        // GET: api/TtrainResistance/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrainResistance>> GetTtrainResistance(short id)
        {
            var ttrainResistance = await _context.TtrainResistance.FindAsync(id);

            if (ttrainResistance == null)
            {
                return NotFound();
            }

            return ttrainResistance;
        }

        // PUT: api/TtrainResistance/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrainResistance(short id, TtrainResistance ttrainResistance)
        {
            if (id != ttrainResistance.TtrainResistanceId)
            {
                return BadRequest();
            }

            _context.Entry(ttrainResistance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainResistanceExists(id))
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

        // POST: api/TtrainResistance
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrainResistance>> PostTtrainResistance(TtrainResistance ttrainResistance)
        {
            _context.TtrainResistance.Add(ttrainResistance);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainResistanceExists(ttrainResistance.TtrainResistanceId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrainResistance", new { id = ttrainResistance.TtrainResistanceId }, ttrainResistance);
        }

        // DELETE: api/TtrainResistance/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrainResistance>> DeleteTtrainResistance(short id)
        {
            var ttrainResistance = await _context.TtrainResistance.FindAsync(id);
            if (ttrainResistance == null)
            {
                return NotFound();
            }

            _context.TtrainResistance.Remove(ttrainResistance);
            await _context.SaveChangesAsync();

            return ttrainResistance;
        }

        private bool TtrainResistanceExists(short id)
        {
            return _context.TtrainResistance.Any(e => e.TtrainResistanceId == id);
        }
    }
}
