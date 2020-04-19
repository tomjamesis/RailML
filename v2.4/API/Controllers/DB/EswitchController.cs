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
    public class EswitchController : ControllerBase
    {
        private readonly DBContext _context;

        public EswitchController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Eswitch
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eswitch>>> GetEswitch()
        {
            return await _context.Eswitch.ToListAsync();
        }

        // GET: api/Eswitch/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eswitch>> GetEswitch(short id)
        {
            var eswitch = await _context.Eswitch.FindAsync(id);

            if (eswitch == null)
            {
                return NotFound();
            }

            return eswitch;
        }

        // PUT: api/Eswitch/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEswitch(short id, Eswitch eswitch)
        {
            if (id != eswitch.EswitchId)
            {
                return BadRequest();
            }

            _context.Entry(eswitch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EswitchExists(id))
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

        // POST: api/Eswitch
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eswitch>> PostEswitch(Eswitch eswitch)
        {
            _context.Eswitch.Add(eswitch);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EswitchExists(eswitch.EswitchId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEswitch", new { id = eswitch.EswitchId }, eswitch);
        }

        // DELETE: api/Eswitch/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eswitch>> DeleteEswitch(short id)
        {
            var eswitch = await _context.Eswitch.FindAsync(id);
            if (eswitch == null)
            {
                return NotFound();
            }

            _context.Eswitch.Remove(eswitch);
            await _context.SaveChangesAsync();

            return eswitch;
        }

        private bool EswitchExists(short id)
        {
            return _context.Eswitch.Any(e => e.EswitchId == id);
        }
    }
}
