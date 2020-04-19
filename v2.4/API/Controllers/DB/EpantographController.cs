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
    public class EpantographController : ControllerBase
    {
        private readonly DBContext _context;

        public EpantographController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Epantograph
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Epantograph>>> GetEpantograph()
        {
            return await _context.Epantograph.ToListAsync();
        }

        // GET: api/Epantograph/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Epantograph>> GetEpantograph(short id)
        {
            var epantograph = await _context.Epantograph.FindAsync(id);

            if (epantograph == null)
            {
                return NotFound();
            }

            return epantograph;
        }

        // PUT: api/Epantograph/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEpantograph(short id, Epantograph epantograph)
        {
            if (id != epantograph.EpantographId)
            {
                return BadRequest();
            }

            _context.Entry(epantograph).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EpantographExists(id))
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

        // POST: api/Epantograph
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Epantograph>> PostEpantograph(Epantograph epantograph)
        {
            _context.Epantograph.Add(epantograph);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EpantographExists(epantograph.EpantographId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEpantograph", new { id = epantograph.EpantographId }, epantograph);
        }

        // DELETE: api/Epantograph/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Epantograph>> DeleteEpantograph(short id)
        {
            var epantograph = await _context.Epantograph.FindAsync(id);
            if (epantograph == null)
            {
                return NotFound();
            }

            _context.Epantograph.Remove(epantograph);
            await _context.SaveChangesAsync();

            return epantograph;
        }

        private bool EpantographExists(short id)
        {
            return _context.Epantograph.Any(e => e.EpantographId == id);
        }
    }
}
