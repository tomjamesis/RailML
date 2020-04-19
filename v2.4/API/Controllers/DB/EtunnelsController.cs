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
    public class EtunnelsController : ControllerBase
    {
        private readonly DBContext _context;

        public EtunnelsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Etunnels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Etunnels>>> GetEtunnels()
        {
            return await _context.Etunnels.ToListAsync();
        }

        // GET: api/Etunnels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Etunnels>> GetEtunnels(long id)
        {
            var etunnels = await _context.Etunnels.FindAsync(id);

            if (etunnels == null)
            {
                return NotFound();
            }

            return etunnels;
        }

        // PUT: api/Etunnels/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtunnels(long id, Etunnels etunnels)
        {
            if (id != etunnels.EtunnelsId)
            {
                return BadRequest();
            }

            _context.Entry(etunnels).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtunnelsExists(id))
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

        // POST: api/Etunnels
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Etunnels>> PostEtunnels(Etunnels etunnels)
        {
            _context.Etunnels.Add(etunnels);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtunnelsExists(etunnels.EtunnelsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtunnels", new { id = etunnels.EtunnelsId }, etunnels);
        }

        // DELETE: api/Etunnels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Etunnels>> DeleteEtunnels(long id)
        {
            var etunnels = await _context.Etunnels.FindAsync(id);
            if (etunnels == null)
            {
                return NotFound();
            }

            _context.Etunnels.Remove(etunnels);
            await _context.SaveChangesAsync();

            return etunnels;
        }

        private bool EtunnelsExists(long id)
        {
            return _context.Etunnels.Any(e => e.EtunnelsId == id);
        }
    }
}
