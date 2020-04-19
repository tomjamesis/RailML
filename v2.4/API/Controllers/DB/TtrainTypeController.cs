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
    public class TtrainTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrainType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrainType>>> GetTtrainType()
        {
            return await _context.TtrainType.ToListAsync();
        }

        // GET: api/TtrainType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrainType>> GetTtrainType(byte id)
        {
            var ttrainType = await _context.TtrainType.FindAsync(id);

            if (ttrainType == null)
            {
                return NotFound();
            }

            return ttrainType;
        }

        // PUT: api/TtrainType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrainType(byte id, TtrainType ttrainType)
        {
            if (id != ttrainType.TtrainTypeId)
            {
                return BadRequest();
            }

            _context.Entry(ttrainType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainTypeExists(id))
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

        // POST: api/TtrainType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrainType>> PostTtrainType(TtrainType ttrainType)
        {
            _context.TtrainType.Add(ttrainType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainTypeExists(ttrainType.TtrainTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrainType", new { id = ttrainType.TtrainTypeId }, ttrainType);
        }

        // DELETE: api/TtrainType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrainType>> DeleteTtrainType(byte id)
        {
            var ttrainType = await _context.TtrainType.FindAsync(id);
            if (ttrainType == null)
            {
                return NotFound();
            }

            _context.TtrainType.Remove(ttrainType);
            await _context.SaveChangesAsync();

            return ttrainType;
        }

        private bool TtrainTypeExists(byte id)
        {
            return _context.TtrainType.Any(e => e.TtrainTypeId == id);
        }
    }
}
