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
    public class TtunnelController : ControllerBase
    {
        private readonly DBContext _context;

        public TtunnelController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Ttunnel
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ttunnel>>> GetTtunnel()
        {
            return await _context.Ttunnel.ToListAsync();
        }

        // GET: api/Ttunnel/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ttunnel>> GetTtunnel(short id)
        {
            var ttunnel = await _context.Ttunnel.FindAsync(id);

            if (ttunnel == null)
            {
                return NotFound();
            }

            return ttunnel;
        }

        // PUT: api/Ttunnel/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtunnel(short id, Ttunnel ttunnel)
        {
            if (id != ttunnel.TtunnelId)
            {
                return BadRequest();
            }

            _context.Entry(ttunnel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtunnelExists(id))
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

        // POST: api/Ttunnel
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ttunnel>> PostTtunnel(Ttunnel ttunnel)
        {
            _context.Ttunnel.Add(ttunnel);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtunnelExists(ttunnel.TtunnelId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtunnel", new { id = ttunnel.TtunnelId }, ttunnel);
        }

        // DELETE: api/Ttunnel/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ttunnel>> DeleteTtunnel(short id)
        {
            var ttunnel = await _context.Ttunnel.FindAsync(id);
            if (ttunnel == null)
            {
                return NotFound();
            }

            _context.Ttunnel.Remove(ttunnel);
            await _context.SaveChangesAsync();

            return ttunnel;
        }

        private bool TtunnelExists(short id)
        {
            return _context.Ttunnel.Any(e => e.TtunnelId == id);
        }
    }
}
