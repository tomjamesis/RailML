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
    public class EpropulsionController : ControllerBase
    {
        private readonly DBContext _context;

        public EpropulsionController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Epropulsion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Epropulsion>>> GetEpropulsion()
        {
            return await _context.Epropulsion.ToListAsync();
        }

        // GET: api/Epropulsion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Epropulsion>> GetEpropulsion(short id)
        {
            var epropulsion = await _context.Epropulsion.FindAsync(id);

            if (epropulsion == null)
            {
                return NotFound();
            }

            return epropulsion;
        }

        // PUT: api/Epropulsion/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEpropulsion(short id, Epropulsion epropulsion)
        {
            if (id != epropulsion.EpropulsionId)
            {
                return BadRequest();
            }

            _context.Entry(epropulsion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EpropulsionExists(id))
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

        // POST: api/Epropulsion
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Epropulsion>> PostEpropulsion(Epropulsion epropulsion)
        {
            _context.Epropulsion.Add(epropulsion);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EpropulsionExists(epropulsion.EpropulsionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEpropulsion", new { id = epropulsion.EpropulsionId }, epropulsion);
        }

        // DELETE: api/Epropulsion/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Epropulsion>> DeleteEpropulsion(short id)
        {
            var epropulsion = await _context.Epropulsion.FindAsync(id);
            if (epropulsion == null)
            {
                return NotFound();
            }

            _context.Epropulsion.Remove(epropulsion);
            await _context.SaveChangesAsync();

            return epropulsion;
        }

        private bool EpropulsionExists(short id)
        {
            return _context.Epropulsion.Any(e => e.EpropulsionId == id);
        }
    }
}
