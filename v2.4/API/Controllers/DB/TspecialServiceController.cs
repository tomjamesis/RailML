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
    public class TspecialServiceController : ControllerBase
    {
        private readonly DBContext _context;

        public TspecialServiceController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TspecialService
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TspecialService>>> GetTspecialService()
        {
            return await _context.TspecialService.ToListAsync();
        }

        // GET: api/TspecialService/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TspecialService>> GetTspecialService(long id)
        {
            var tspecialService = await _context.TspecialService.FindAsync(id);

            if (tspecialService == null)
            {
                return NotFound();
            }

            return tspecialService;
        }

        // PUT: api/TspecialService/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTspecialService(long id, TspecialService tspecialService)
        {
            if (id != tspecialService.TspecialServiceId)
            {
                return BadRequest();
            }

            _context.Entry(tspecialService).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TspecialServiceExists(id))
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

        // POST: api/TspecialService
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TspecialService>> PostTspecialService(TspecialService tspecialService)
        {
            _context.TspecialService.Add(tspecialService);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TspecialServiceExists(tspecialService.TspecialServiceId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTspecialService", new { id = tspecialService.TspecialServiceId }, tspecialService);
        }

        // DELETE: api/TspecialService/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TspecialService>> DeleteTspecialService(long id)
        {
            var tspecialService = await _context.TspecialService.FindAsync(id);
            if (tspecialService == null)
            {
                return NotFound();
            }

            _context.TspecialService.Remove(tspecialService);
            await _context.SaveChangesAsync();

            return tspecialService;
        }

        private bool TspecialServiceExists(long id)
        {
            return _context.TspecialService.Any(e => e.TspecialServiceId == id);
        }
    }
}
