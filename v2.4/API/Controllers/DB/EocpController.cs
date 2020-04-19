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
    public class EocpController : ControllerBase
    {
        private readonly DBContext _context;

        public EocpController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Eocp
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eocp>>> GetEocp()
        {
            return await _context.Eocp.ToListAsync();
        }

        // GET: api/Eocp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eocp>> GetEocp(short id)
        {
            var eocp = await _context.Eocp.FindAsync(id);

            if (eocp == null)
            {
                return NotFound();
            }

            return eocp;
        }

        // PUT: api/Eocp/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEocp(short id, Eocp eocp)
        {
            if (id != eocp.EocpId)
            {
                return BadRequest();
            }

            _context.Entry(eocp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EocpExists(id))
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

        // POST: api/Eocp
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eocp>> PostEocp(Eocp eocp)
        {
            _context.Eocp.Add(eocp);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EocpExists(eocp.EocpId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEocp", new { id = eocp.EocpId }, eocp);
        }

        // DELETE: api/Eocp/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eocp>> DeleteEocp(short id)
        {
            var eocp = await _context.Eocp.FindAsync(id);
            if (eocp == null)
            {
                return NotFound();
            }

            _context.Eocp.Remove(eocp);
            await _context.SaveChangesAsync();

            return eocp;
        }

        private bool EocpExists(short id)
        {
            return _context.Eocp.Any(e => e.EocpId == id);
        }
    }
}
