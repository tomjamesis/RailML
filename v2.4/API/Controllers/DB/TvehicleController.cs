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
    public class TvehicleController : ControllerBase
    {
        private readonly DBContext _context;

        public TvehicleController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tvehicle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tvehicle>>> GetTvehicle()
        {
            return await _context.Tvehicle.ToListAsync();
        }

        // GET: api/Tvehicle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tvehicle>> GetTvehicle(short id)
        {
            var tvehicle = await _context.Tvehicle.FindAsync(id);

            if (tvehicle == null)
            {
                return NotFound();
            }

            return tvehicle;
        }

        // PUT: api/Tvehicle/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTvehicle(short id, Tvehicle tvehicle)
        {
            if (id != tvehicle.TvehicleId)
            {
                return BadRequest();
            }

            _context.Entry(tvehicle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TvehicleExists(id))
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

        // POST: api/Tvehicle
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tvehicle>> PostTvehicle(Tvehicle tvehicle)
        {
            _context.Tvehicle.Add(tvehicle);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TvehicleExists(tvehicle.TvehicleId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTvehicle", new { id = tvehicle.TvehicleId }, tvehicle);
        }

        // DELETE: api/Tvehicle/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tvehicle>> DeleteTvehicle(short id)
        {
            var tvehicle = await _context.Tvehicle.FindAsync(id);
            if (tvehicle == null)
            {
                return NotFound();
            }

            _context.Tvehicle.Remove(tvehicle);
            await _context.SaveChangesAsync();

            return tvehicle;
        }

        private bool TvehicleExists(short id)
        {
            return _context.Tvehicle.Any(e => e.TvehicleId == id);
        }
    }
}
