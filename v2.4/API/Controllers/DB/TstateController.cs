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
    public class TstateController : ControllerBase
    {
        private readonly DBContext _context;

        public TstateController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tstate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tstate>>> GetTstate()
        {
            return await _context.Tstate.ToListAsync();
        }

        // GET: api/Tstate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tstate>> GetTstate(long id)
        {
            var tstate = await _context.Tstate.FindAsync(id);

            if (tstate == null)
            {
                return NotFound();
            }

            return tstate;
        }

        // PUT: api/Tstate/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTstate(long id, Tstate tstate)
        {
            if (id != tstate.TstateId)
            {
                return BadRequest();
            }

            _context.Entry(tstate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TstateExists(id))
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

        // POST: api/Tstate
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tstate>> PostTstate(Tstate tstate)
        {
            _context.Tstate.Add(tstate);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TstateExists(tstate.TstateId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTstate", new { id = tstate.TstateId }, tstate);
        }

        // DELETE: api/Tstate/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tstate>> DeleteTstate(long id)
        {
            var tstate = await _context.Tstate.FindAsync(id);
            if (tstate == null)
            {
                return NotFound();
            }

            _context.Tstate.Remove(tstate);
            await _context.SaveChangesAsync();

            return tstate;
        }

        private bool TstateExists(long id)
        {
            return _context.Tstate.Any(e => e.TstateId == id);
        }
    }
}
