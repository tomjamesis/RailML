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
    public class EtrainGroupsController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrainGroupsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrainGroups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrainGroups>>> GetEtrainGroups()
        {
            return await _context.EtrainGroups.ToListAsync();
        }

        // GET: api/EtrainGroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrainGroups>> GetEtrainGroups(long id)
        {
            var etrainGroups = await _context.EtrainGroups.FindAsync(id);

            if (etrainGroups == null)
            {
                return NotFound();
            }

            return etrainGroups;
        }

        // PUT: api/EtrainGroups/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrainGroups(long id, EtrainGroups etrainGroups)
        {
            if (id != etrainGroups.EtrainGroupsId)
            {
                return BadRequest();
            }

            _context.Entry(etrainGroups).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrainGroupsExists(id))
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

        // POST: api/EtrainGroups
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrainGroups>> PostEtrainGroups(EtrainGroups etrainGroups)
        {
            _context.EtrainGroups.Add(etrainGroups);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrainGroupsExists(etrainGroups.EtrainGroupsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrainGroups", new { id = etrainGroups.EtrainGroupsId }, etrainGroups);
        }

        // DELETE: api/EtrainGroups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrainGroups>> DeleteEtrainGroups(long id)
        {
            var etrainGroups = await _context.EtrainGroups.FindAsync(id);
            if (etrainGroups == null)
            {
                return NotFound();
            }

            _context.EtrainGroups.Remove(etrainGroups);
            await _context.SaveChangesAsync();

            return etrainGroups;
        }

        private bool EtrainGroupsExists(long id)
        {
            return _context.EtrainGroups.Any(e => e.EtrainGroupsId == id);
        }
    }
}
