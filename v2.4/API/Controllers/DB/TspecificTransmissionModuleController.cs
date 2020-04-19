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
    public class TspecificTransmissionModuleController : ControllerBase
    {
        private readonly DBContext _context;

        public TspecificTransmissionModuleController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TspecificTransmissionModule
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TspecificTransmissionModule>>> GetTspecificTransmissionModule()
        {
            return await _context.TspecificTransmissionModule.ToListAsync();
        }

        // GET: api/TspecificTransmissionModule/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TspecificTransmissionModule>> GetTspecificTransmissionModule(short id)
        {
            var tspecificTransmissionModule = await _context.TspecificTransmissionModule.FindAsync(id);

            if (tspecificTransmissionModule == null)
            {
                return NotFound();
            }

            return tspecificTransmissionModule;
        }

        // PUT: api/TspecificTransmissionModule/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTspecificTransmissionModule(short id, TspecificTransmissionModule tspecificTransmissionModule)
        {
            if (id != tspecificTransmissionModule.TspecificTransmissionModuleId)
            {
                return BadRequest();
            }

            _context.Entry(tspecificTransmissionModule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TspecificTransmissionModuleExists(id))
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

        // POST: api/TspecificTransmissionModule
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TspecificTransmissionModule>> PostTspecificTransmissionModule(TspecificTransmissionModule tspecificTransmissionModule)
        {
            _context.TspecificTransmissionModule.Add(tspecificTransmissionModule);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TspecificTransmissionModuleExists(tspecificTransmissionModule.TspecificTransmissionModuleId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTspecificTransmissionModule", new { id = tspecificTransmissionModule.TspecificTransmissionModuleId }, tspecificTransmissionModule);
        }

        // DELETE: api/TspecificTransmissionModule/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TspecificTransmissionModule>> DeleteTspecificTransmissionModule(short id)
        {
            var tspecificTransmissionModule = await _context.TspecificTransmissionModule.FindAsync(id);
            if (tspecificTransmissionModule == null)
            {
                return NotFound();
            }

            _context.TspecificTransmissionModule.Remove(tspecificTransmissionModule);
            await _context.SaveChangesAsync();

            return tspecificTransmissionModule;
        }

        private bool TspecificTransmissionModuleExists(short id)
        {
            return _context.TspecificTransmissionModule.Any(e => e.TspecificTransmissionModuleId == id);
        }
    }
}
