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
    public class TusageTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TusageTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TusageType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TusageType>>> GetTusageType()
        {
            return await _context.TusageType.ToListAsync();
        }

        // GET: api/TusageType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TusageType>> GetTusageType(byte id)
        {
            var tusageType = await _context.TusageType.FindAsync(id);

            if (tusageType == null)
            {
                return NotFound();
            }

            return tusageType;
        }

        // PUT: api/TusageType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTusageType(byte id, TusageType tusageType)
        {
            if (id != tusageType.TusageTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tusageType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TusageTypeExists(id))
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

        // POST: api/TusageType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TusageType>> PostTusageType(TusageType tusageType)
        {
            _context.TusageType.Add(tusageType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TusageTypeExists(tusageType.TusageTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTusageType", new { id = tusageType.TusageTypeId }, tusageType);
        }

        // DELETE: api/TusageType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TusageType>> DeleteTusageType(byte id)
        {
            var tusageType = await _context.TusageType.FindAsync(id);
            if (tusageType == null)
            {
                return NotFound();
            }

            _context.TusageType.Remove(tusageType);
            await _context.SaveChangesAsync();

            return tusageType;
        }

        private bool TusageTypeExists(byte id)
        {
            return _context.TusageType.Any(e => e.TusageTypeId == id);
        }
    }
}
