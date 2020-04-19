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
    public class EtunnelController : ControllerBase
    {
        private readonly DBContext _context;

        public EtunnelController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Etunnel
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Etunnel>>> GetEtunnel()
        {
            return await _context.Etunnel.ToListAsync();
        }

        // GET: api/Etunnel/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Etunnel>> GetEtunnel(short id)
        {
            var etunnel = await _context.Etunnel.FindAsync(id);

            if (etunnel == null)
            {
                return NotFound();
            }

            return etunnel;
        }

        // PUT: api/Etunnel/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtunnel(short id, Etunnel etunnel)
        {
            if (id != etunnel.EtunnelId)
            {
                return BadRequest();
            }

            _context.Entry(etunnel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtunnelExists(id))
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

        // POST: api/Etunnel
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Etunnel>> PostEtunnel(Etunnel etunnel)
        {
            _context.Etunnel.Add(etunnel);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtunnelExists(etunnel.EtunnelId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtunnel", new { id = etunnel.EtunnelId }, etunnel);
        }

        // DELETE: api/Etunnel/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Etunnel>> DeleteEtunnel(short id)
        {
            var etunnel = await _context.Etunnel.FindAsync(id);
            if (etunnel == null)
            {
                return NotFound();
            }

            _context.Etunnel.Remove(etunnel);
            await _context.SaveChangesAsync();

            return etunnel;
        }

        private bool EtunnelExists(short id)
        {
            return _context.Etunnel.Any(e => e.EtunnelId == id);
        }
    }
}
