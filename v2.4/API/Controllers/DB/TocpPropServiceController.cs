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
    public class TocpPropServiceController : ControllerBase
    {
        private readonly DBContext _context;

        public TocpPropServiceController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TocpPropService
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TocpPropService>>> GetTocpPropService()
        {
            return await _context.TocpPropService.ToListAsync();
        }

        // GET: api/TocpPropService/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TocpPropService>> GetTocpPropService(long id)
        {
            var tocpPropService = await _context.TocpPropService.FindAsync(id);

            if (tocpPropService == null)
            {
                return NotFound();
            }

            return tocpPropService;
        }

        // PUT: api/TocpPropService/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTocpPropService(long id, TocpPropService tocpPropService)
        {
            if (id != tocpPropService.TocpPropServiceId)
            {
                return BadRequest();
            }

            _context.Entry(tocpPropService).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TocpPropServiceExists(id))
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

        // POST: api/TocpPropService
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TocpPropService>> PostTocpPropService(TocpPropService tocpPropService)
        {
            _context.TocpPropService.Add(tocpPropService);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TocpPropServiceExists(tocpPropService.TocpPropServiceId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTocpPropService", new { id = tocpPropService.TocpPropServiceId }, tocpPropService);
        }

        // DELETE: api/TocpPropService/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TocpPropService>> DeleteTocpPropService(long id)
        {
            var tocpPropService = await _context.TocpPropService.FindAsync(id);
            if (tocpPropService == null)
            {
                return NotFound();
            }

            _context.TocpPropService.Remove(tocpPropService);
            await _context.SaveChangesAsync();

            return tocpPropService;
        }

        private bool TocpPropServiceExists(long id)
        {
            return _context.TocpPropService.Any(e => e.TocpPropServiceId == id);
        }
    }
}
