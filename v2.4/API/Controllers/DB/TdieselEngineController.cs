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
    public class TdieselEngineController : ControllerBase
    {
        private readonly DBContext _context;

        public TdieselEngineController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TdieselEngine
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TdieselEngine>>> GetTdieselEngine()
        {
            return await _context.TdieselEngine.ToListAsync();
        }

        // GET: api/TdieselEngine/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TdieselEngine>> GetTdieselEngine(long id)
        {
            var tdieselEngine = await _context.TdieselEngine.FindAsync(id);

            if (tdieselEngine == null)
            {
                return NotFound();
            }

            return tdieselEngine;
        }

        // PUT: api/TdieselEngine/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdieselEngine(long id, TdieselEngine tdieselEngine)
        {
            if (id != tdieselEngine.TdieselEngineId)
            {
                return BadRequest();
            }

            _context.Entry(tdieselEngine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdieselEngineExists(id))
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

        // POST: api/TdieselEngine
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TdieselEngine>> PostTdieselEngine(TdieselEngine tdieselEngine)
        {
            _context.TdieselEngine.Add(tdieselEngine);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TdieselEngineExists(tdieselEngine.TdieselEngineId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTdieselEngine", new { id = tdieselEngine.TdieselEngineId }, tdieselEngine);
        }

        // DELETE: api/TdieselEngine/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TdieselEngine>> DeleteTdieselEngine(long id)
        {
            var tdieselEngine = await _context.TdieselEngine.FindAsync(id);
            if (tdieselEngine == null)
            {
                return NotFound();
            }

            _context.TdieselEngine.Remove(tdieselEngine);
            await _context.SaveChangesAsync();

            return tdieselEngine;
        }

        private bool TdieselEngineExists(long id)
        {
            return _context.TdieselEngine.Any(e => e.TdieselEngineId == id);
        }
    }
}
