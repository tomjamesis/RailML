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
    public class TbasicBrakeTypeAuxiliaryBrakesController : ControllerBase
    {
        private readonly DBContext _context;

        public TbasicBrakeTypeAuxiliaryBrakesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TbasicBrakeTypeAuxiliaryBrakes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbasicBrakeTypeAuxiliaryBrakes>>> GetTbasicBrakeTypeAuxiliaryBrakes()
        {
            return await _context.TbasicBrakeTypeAuxiliaryBrakes.ToListAsync();
        }

        // GET: api/TbasicBrakeTypeAuxiliaryBrakes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbasicBrakeTypeAuxiliaryBrakes>> GetTbasicBrakeTypeAuxiliaryBrakes(long id)
        {
            var tbasicBrakeTypeAuxiliaryBrakes = await _context.TbasicBrakeTypeAuxiliaryBrakes.FindAsync(id);

            if (tbasicBrakeTypeAuxiliaryBrakes == null)
            {
                return NotFound();
            }

            return tbasicBrakeTypeAuxiliaryBrakes;
        }

        // PUT: api/TbasicBrakeTypeAuxiliaryBrakes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbasicBrakeTypeAuxiliaryBrakes(long id, TbasicBrakeTypeAuxiliaryBrakes tbasicBrakeTypeAuxiliaryBrakes)
        {
            if (id != tbasicBrakeTypeAuxiliaryBrakes.TbasicBrakeTypeAuxiliaryBrakesId)
            {
                return BadRequest();
            }

            _context.Entry(tbasicBrakeTypeAuxiliaryBrakes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbasicBrakeTypeAuxiliaryBrakesExists(id))
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

        // POST: api/TbasicBrakeTypeAuxiliaryBrakes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TbasicBrakeTypeAuxiliaryBrakes>> PostTbasicBrakeTypeAuxiliaryBrakes(TbasicBrakeTypeAuxiliaryBrakes tbasicBrakeTypeAuxiliaryBrakes)
        {
            _context.TbasicBrakeTypeAuxiliaryBrakes.Add(tbasicBrakeTypeAuxiliaryBrakes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbasicBrakeTypeAuxiliaryBrakesExists(tbasicBrakeTypeAuxiliaryBrakes.TbasicBrakeTypeAuxiliaryBrakesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbasicBrakeTypeAuxiliaryBrakes", new { id = tbasicBrakeTypeAuxiliaryBrakes.TbasicBrakeTypeAuxiliaryBrakesId }, tbasicBrakeTypeAuxiliaryBrakes);
        }

        // DELETE: api/TbasicBrakeTypeAuxiliaryBrakes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbasicBrakeTypeAuxiliaryBrakes>> DeleteTbasicBrakeTypeAuxiliaryBrakes(long id)
        {
            var tbasicBrakeTypeAuxiliaryBrakes = await _context.TbasicBrakeTypeAuxiliaryBrakes.FindAsync(id);
            if (tbasicBrakeTypeAuxiliaryBrakes == null)
            {
                return NotFound();
            }

            _context.TbasicBrakeTypeAuxiliaryBrakes.Remove(tbasicBrakeTypeAuxiliaryBrakes);
            await _context.SaveChangesAsync();

            return tbasicBrakeTypeAuxiliaryBrakes;
        }

        private bool TbasicBrakeTypeAuxiliaryBrakesExists(long id)
        {
            return _context.TbasicBrakeTypeAuxiliaryBrakes.Any(e => e.TbasicBrakeTypeAuxiliaryBrakesId == id);
        }
    }
}
