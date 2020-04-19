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
    public class EspeedProfilesController : ControllerBase
    {
        private readonly DBContext _context;

        public EspeedProfilesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EspeedProfiles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EspeedProfiles>>> GetEspeedProfiles()
        {
            return await _context.EspeedProfiles.ToListAsync();
        }

        // GET: api/EspeedProfiles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EspeedProfiles>> GetEspeedProfiles(long id)
        {
            var espeedProfiles = await _context.EspeedProfiles.FindAsync(id);

            if (espeedProfiles == null)
            {
                return NotFound();
            }

            return espeedProfiles;
        }

        // PUT: api/EspeedProfiles/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEspeedProfiles(long id, EspeedProfiles espeedProfiles)
        {
            if (id != espeedProfiles.EspeedProfilesId)
            {
                return BadRequest();
            }

            _context.Entry(espeedProfiles).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EspeedProfilesExists(id))
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

        // POST: api/EspeedProfiles
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EspeedProfiles>> PostEspeedProfiles(EspeedProfiles espeedProfiles)
        {
            _context.EspeedProfiles.Add(espeedProfiles);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EspeedProfilesExists(espeedProfiles.EspeedProfilesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEspeedProfiles", new { id = espeedProfiles.EspeedProfilesId }, espeedProfiles);
        }

        // DELETE: api/EspeedProfiles/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EspeedProfiles>> DeleteEspeedProfiles(long id)
        {
            var espeedProfiles = await _context.EspeedProfiles.FindAsync(id);
            if (espeedProfiles == null)
            {
                return NotFound();
            }

            _context.EspeedProfiles.Remove(espeedProfiles);
            await _context.SaveChangesAsync();

            return espeedProfiles;
        }

        private bool EspeedProfilesExists(long id)
        {
            return _context.EspeedProfiles.Any(e => e.EspeedProfilesId == id);
        }
    }
}
