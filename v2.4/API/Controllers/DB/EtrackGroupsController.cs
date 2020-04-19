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
    public class EtrackGroupsController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrackGroupsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrackGroups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrackGroups>>> GetEtrackGroups()
        {
            return await _context.EtrackGroups.ToListAsync();
        }

        // GET: api/EtrackGroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrackGroups>> GetEtrackGroups(long id)
        {
            var etrackGroups = await _context.EtrackGroups.FindAsync(id);

            if (etrackGroups == null)
            {
                return NotFound();
            }

            return etrackGroups;
        }

        // PUT: api/EtrackGroups/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrackGroups(long id, EtrackGroups etrackGroups)
        {
            if (id != etrackGroups.EtrackGroupsId)
            {
                return BadRequest();
            }

            _context.Entry(etrackGroups).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrackGroupsExists(id))
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

        // POST: api/EtrackGroups
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrackGroups>> PostEtrackGroups(EtrackGroups etrackGroups)
        {
            _context.EtrackGroups.Add(etrackGroups);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrackGroupsExists(etrackGroups.EtrackGroupsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrackGroups", new { id = etrackGroups.EtrackGroupsId }, etrackGroups);
        }

        // DELETE: api/EtrackGroups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrackGroups>> DeleteEtrackGroups(long id)
        {
            var etrackGroups = await _context.EtrackGroups.FindAsync(id);
            if (etrackGroups == null)
            {
                return NotFound();
            }

            _context.EtrackGroups.Remove(etrackGroups);
            await _context.SaveChangesAsync();

            return etrackGroups;
        }

        private bool EtrackGroupsExists(long id)
        {
            return _context.EtrackGroups.Any(e => e.EtrackGroupsId == id);
        }
    }
}
