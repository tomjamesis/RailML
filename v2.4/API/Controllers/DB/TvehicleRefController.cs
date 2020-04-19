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
    public class TvehicleRefController : ControllerBase
    {
        private readonly DBContext _context;

        public TvehicleRefController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TvehicleRef
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TvehicleRef>>> GetTvehicleRef()
        {
            return await _context.TvehicleRef.ToListAsync();
        }

        // GET: api/TvehicleRef/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TvehicleRef>> GetTvehicleRef(long id)
        {
            var tvehicleRef = await _context.TvehicleRef.FindAsync(id);

            if (tvehicleRef == null)
            {
                return NotFound();
            }

            return tvehicleRef;
        }

        // PUT: api/TvehicleRef/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTvehicleRef(long id, TvehicleRef tvehicleRef)
        {
            if (id != tvehicleRef.TvehicleRefId)
            {
                return BadRequest();
            }

            _context.Entry(tvehicleRef).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TvehicleRefExists(id))
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

        // POST: api/TvehicleRef
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TvehicleRef>> PostTvehicleRef(TvehicleRef tvehicleRef)
        {
            _context.TvehicleRef.Add(tvehicleRef);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TvehicleRefExists(tvehicleRef.TvehicleRefId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTvehicleRef", new { id = tvehicleRef.TvehicleRefId }, tvehicleRef);
        }

        // DELETE: api/TvehicleRef/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TvehicleRef>> DeleteTvehicleRef(long id)
        {
            var tvehicleRef = await _context.TvehicleRef.FindAsync(id);
            if (tvehicleRef == null)
            {
                return NotFound();
            }

            _context.TvehicleRef.Remove(tvehicleRef);
            await _context.SaveChangesAsync();

            return tvehicleRef;
        }

        private bool TvehicleRefExists(long id)
        {
            return _context.TvehicleRef.Any(e => e.TvehicleRefId == id);
        }
    }
}
