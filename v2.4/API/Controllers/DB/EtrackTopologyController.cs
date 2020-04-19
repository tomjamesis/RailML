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
    public class EtrackTopologyController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrackTopologyController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrackTopology
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrackTopology>>> GetEtrackTopology()
        {
            return await _context.EtrackTopology.ToListAsync();
        }

        // GET: api/EtrackTopology/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrackTopology>> GetEtrackTopology(long id)
        {
            var etrackTopology = await _context.EtrackTopology.FindAsync(id);

            if (etrackTopology == null)
            {
                return NotFound();
            }

            return etrackTopology;
        }

        // PUT: api/EtrackTopology/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrackTopology(long id, EtrackTopology etrackTopology)
        {
            if (id != etrackTopology.EtrackTopologyId)
            {
                return BadRequest();
            }

            _context.Entry(etrackTopology).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrackTopologyExists(id))
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

        // POST: api/EtrackTopology
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrackTopology>> PostEtrackTopology(EtrackTopology etrackTopology)
        {
            _context.EtrackTopology.Add(etrackTopology);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrackTopologyExists(etrackTopology.EtrackTopologyId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrackTopology", new { id = etrackTopology.EtrackTopologyId }, etrackTopology);
        }

        // DELETE: api/EtrackTopology/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrackTopology>> DeleteEtrackTopology(long id)
        {
            var etrackTopology = await _context.EtrackTopology.FindAsync(id);
            if (etrackTopology == null)
            {
                return NotFound();
            }

            _context.EtrackTopology.Remove(etrackTopology);
            await _context.SaveChangesAsync();

            return etrackTopology;
        }

        private bool EtrackTopologyExists(long id)
        {
            return _context.EtrackTopology.Any(e => e.EtrackTopologyId == id);
        }
    }
}
