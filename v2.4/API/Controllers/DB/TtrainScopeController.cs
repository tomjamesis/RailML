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
    public class TtrainScopeController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainScopeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrainScope
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrainScope>>> GetTtrainScope()
        {
            return await _context.TtrainScope.ToListAsync();
        }

        // GET: api/TtrainScope/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrainScope>> GetTtrainScope(byte id)
        {
            var ttrainScope = await _context.TtrainScope.FindAsync(id);

            if (ttrainScope == null)
            {
                return NotFound();
            }

            return ttrainScope;
        }

        // PUT: api/TtrainScope/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrainScope(byte id, TtrainScope ttrainScope)
        {
            if (id != ttrainScope.TtrainScopeId)
            {
                return BadRequest();
            }

            _context.Entry(ttrainScope).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainScopeExists(id))
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

        // POST: api/TtrainScope
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrainScope>> PostTtrainScope(TtrainScope ttrainScope)
        {
            _context.TtrainScope.Add(ttrainScope);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainScopeExists(ttrainScope.TtrainScopeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrainScope", new { id = ttrainScope.TtrainScopeId }, ttrainScope);
        }

        // DELETE: api/TtrainScope/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrainScope>> DeleteTtrainScope(byte id)
        {
            var ttrainScope = await _context.TtrainScope.FindAsync(id);
            if (ttrainScope == null)
            {
                return NotFound();
            }

            _context.TtrainScope.Remove(ttrainScope);
            await _context.SaveChangesAsync();

            return ttrainScope;
        }

        private bool TtrainScopeExists(byte id)
        {
            return _context.TtrainScope.Any(e => e.TtrainScopeId == id);
        }
    }
}
