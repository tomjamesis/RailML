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
    public class EplatformEdgesController : ControllerBase
    {
        private readonly DBContext _context;

        public EplatformEdgesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EplatformEdges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EplatformEdges>>> GetEplatformEdges()
        {
            return await _context.EplatformEdges.ToListAsync();
        }

        // GET: api/EplatformEdges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EplatformEdges>> GetEplatformEdges(long id)
        {
            var eplatformEdges = await _context.EplatformEdges.FindAsync(id);

            if (eplatformEdges == null)
            {
                return NotFound();
            }

            return eplatformEdges;
        }

        // PUT: api/EplatformEdges/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEplatformEdges(long id, EplatformEdges eplatformEdges)
        {
            if (id != eplatformEdges.EplatformEdgesId)
            {
                return BadRequest();
            }

            _context.Entry(eplatformEdges).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EplatformEdgesExists(id))
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

        // POST: api/EplatformEdges
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EplatformEdges>> PostEplatformEdges(EplatformEdges eplatformEdges)
        {
            _context.EplatformEdges.Add(eplatformEdges);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EplatformEdgesExists(eplatformEdges.EplatformEdgesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEplatformEdges", new { id = eplatformEdges.EplatformEdgesId }, eplatformEdges);
        }

        // DELETE: api/EplatformEdges/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EplatformEdges>> DeleteEplatformEdges(long id)
        {
            var eplatformEdges = await _context.EplatformEdges.FindAsync(id);
            if (eplatformEdges == null)
            {
                return NotFound();
            }

            _context.EplatformEdges.Remove(eplatformEdges);
            await _context.SaveChangesAsync();

            return eplatformEdges;
        }

        private bool EplatformEdgesExists(long id)
        {
            return _context.EplatformEdges.Any(e => e.EplatformEdgesId == id);
        }
    }
}
