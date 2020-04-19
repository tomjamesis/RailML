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
    public class TpropulsionController : ControllerBase
    {
        private readonly DBContext _context;

        public TpropulsionController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tpropulsion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tpropulsion>>> GetTpropulsion()
        {
            return await _context.Tpropulsion.ToListAsync();
        }

        // GET: api/Tpropulsion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tpropulsion>> GetTpropulsion(short id)
        {
            var tpropulsion = await _context.Tpropulsion.FindAsync(id);

            if (tpropulsion == null)
            {
                return NotFound();
            }

            return tpropulsion;
        }

        // PUT: api/Tpropulsion/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTpropulsion(short id, Tpropulsion tpropulsion)
        {
            if (id != tpropulsion.TpropulsionId)
            {
                return BadRequest();
            }

            _context.Entry(tpropulsion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TpropulsionExists(id))
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

        // POST: api/Tpropulsion
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tpropulsion>> PostTpropulsion(Tpropulsion tpropulsion)
        {
            _context.Tpropulsion.Add(tpropulsion);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TpropulsionExists(tpropulsion.TpropulsionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTpropulsion", new { id = tpropulsion.TpropulsionId }, tpropulsion);
        }

        // DELETE: api/Tpropulsion/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tpropulsion>> DeleteTpropulsion(short id)
        {
            var tpropulsion = await _context.Tpropulsion.FindAsync(id);
            if (tpropulsion == null)
            {
                return NotFound();
            }

            _context.Tpropulsion.Remove(tpropulsion);
            await _context.SaveChangesAsync();

            return tpropulsion;
        }

        private bool TpropulsionExists(short id)
        {
            return _context.Tpropulsion.Any(e => e.TpropulsionId == id);
        }
    }
}
