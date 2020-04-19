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
    public class EpassengerFacilityController : ControllerBase
    {
        private readonly DBContext _context;

        public EpassengerFacilityController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EpassengerFacility
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EpassengerFacility>>> GetEpassengerFacility()
        {
            return await _context.EpassengerFacility.ToListAsync();
        }

        // GET: api/EpassengerFacility/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EpassengerFacility>> GetEpassengerFacility(long id)
        {
            var epassengerFacility = await _context.EpassengerFacility.FindAsync(id);

            if (epassengerFacility == null)
            {
                return NotFound();
            }

            return epassengerFacility;
        }

        // PUT: api/EpassengerFacility/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEpassengerFacility(long id, EpassengerFacility epassengerFacility)
        {
            if (id != epassengerFacility.EpassengerFacilityId)
            {
                return BadRequest();
            }

            _context.Entry(epassengerFacility).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EpassengerFacilityExists(id))
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

        // POST: api/EpassengerFacility
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EpassengerFacility>> PostEpassengerFacility(EpassengerFacility epassengerFacility)
        {
            _context.EpassengerFacility.Add(epassengerFacility);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EpassengerFacilityExists(epassengerFacility.EpassengerFacilityId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEpassengerFacility", new { id = epassengerFacility.EpassengerFacilityId }, epassengerFacility);
        }

        // DELETE: api/EpassengerFacility/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EpassengerFacility>> DeleteEpassengerFacility(long id)
        {
            var epassengerFacility = await _context.EpassengerFacility.FindAsync(id);
            if (epassengerFacility == null)
            {
                return NotFound();
            }

            _context.EpassengerFacility.Remove(epassengerFacility);
            await _context.SaveChangesAsync();

            return epassengerFacility;
        }

        private bool EpassengerFacilityExists(long id)
        {
            return _context.EpassengerFacility.Any(e => e.EpassengerFacilityId == id);
        }
    }
}
