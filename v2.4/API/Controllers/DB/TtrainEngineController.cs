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
    public class TtrainEngineController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainEngineController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrainEngine
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrainEngine>>> GetTtrainEngine()
        {
            return await _context.TtrainEngine.ToListAsync();
        }

        // GET: api/TtrainEngine/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrainEngine>> GetTtrainEngine(long id)
        {
            var ttrainEngine = await _context.TtrainEngine.FindAsync(id);

            if (ttrainEngine == null)
            {
                return NotFound();
            }

            return ttrainEngine;
        }

        // PUT: api/TtrainEngine/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrainEngine(long id, TtrainEngine ttrainEngine)
        {
            if (id != ttrainEngine.TtrainEngineId)
            {
                return BadRequest();
            }

            _context.Entry(ttrainEngine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainEngineExists(id))
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

        // POST: api/TtrainEngine
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrainEngine>> PostTtrainEngine(TtrainEngine ttrainEngine)
        {
            _context.TtrainEngine.Add(ttrainEngine);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainEngineExists(ttrainEngine.TtrainEngineId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrainEngine", new { id = ttrainEngine.TtrainEngineId }, ttrainEngine);
        }

        // DELETE: api/TtrainEngine/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrainEngine>> DeleteTtrainEngine(long id)
        {
            var ttrainEngine = await _context.TtrainEngine.FindAsync(id);
            if (ttrainEngine == null)
            {
                return NotFound();
            }

            _context.TtrainEngine.Remove(ttrainEngine);
            await _context.SaveChangesAsync();

            return ttrainEngine;
        }

        private bool TtrainEngineExists(long id)
        {
            return _context.TtrainEngine.Any(e => e.TtrainEngineId == id);
        }
    }
}
