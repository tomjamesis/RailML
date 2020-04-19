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
    public class EbridgeController : ControllerBase
    {
        private readonly DBContext _context;

        public EbridgeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Ebridge
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ebridge>>> GetEbridge()
        {
            return await _context.Ebridge.ToListAsync();
        }

        // GET: api/Ebridge/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ebridge>> GetEbridge(short id)
        {
            var ebridge = await _context.Ebridge.FindAsync(id);

            if (ebridge == null)
            {
                return NotFound();
            }

            return ebridge;
        }

        // PUT: api/Ebridge/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEbridge(short id, Ebridge ebridge)
        {
            if (id != ebridge.EbridgeId)
            {
                return BadRequest();
            }

            _context.Entry(ebridge).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EbridgeExists(id))
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

        // POST: api/Ebridge
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ebridge>> PostEbridge(Ebridge ebridge)
        {
            _context.Ebridge.Add(ebridge);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EbridgeExists(ebridge.EbridgeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEbridge", new { id = ebridge.EbridgeId }, ebridge);
        }

        // DELETE: api/Ebridge/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ebridge>> DeleteEbridge(short id)
        {
            var ebridge = await _context.Ebridge.FindAsync(id);
            if (ebridge == null)
            {
                return NotFound();
            }

            _context.Ebridge.Remove(ebridge);
            await _context.SaveChangesAsync();

            return ebridge;
        }

        private bool EbridgeExists(short id)
        {
            return _context.Ebridge.Any(e => e.EbridgeId == id);
        }
    }
}
