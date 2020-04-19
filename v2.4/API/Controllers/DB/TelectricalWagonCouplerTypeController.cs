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
    public class TelectricalWagonCouplerTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TelectricalWagonCouplerTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TelectricalWagonCouplerType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TelectricalWagonCouplerType>>> GetTelectricalWagonCouplerType()
        {
            return await _context.TelectricalWagonCouplerType.ToListAsync();
        }

        // GET: api/TelectricalWagonCouplerType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TelectricalWagonCouplerType>> GetTelectricalWagonCouplerType(long id)
        {
            var telectricalWagonCouplerType = await _context.TelectricalWagonCouplerType.FindAsync(id);

            if (telectricalWagonCouplerType == null)
            {
                return NotFound();
            }

            return telectricalWagonCouplerType;
        }

        // PUT: api/TelectricalWagonCouplerType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTelectricalWagonCouplerType(long id, TelectricalWagonCouplerType telectricalWagonCouplerType)
        {
            if (id != telectricalWagonCouplerType.TelectricalWagonCouplerTypeId)
            {
                return BadRequest();
            }

            _context.Entry(telectricalWagonCouplerType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TelectricalWagonCouplerTypeExists(id))
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

        // POST: api/TelectricalWagonCouplerType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TelectricalWagonCouplerType>> PostTelectricalWagonCouplerType(TelectricalWagonCouplerType telectricalWagonCouplerType)
        {
            _context.TelectricalWagonCouplerType.Add(telectricalWagonCouplerType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TelectricalWagonCouplerTypeExists(telectricalWagonCouplerType.TelectricalWagonCouplerTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTelectricalWagonCouplerType", new { id = telectricalWagonCouplerType.TelectricalWagonCouplerTypeId }, telectricalWagonCouplerType);
        }

        // DELETE: api/TelectricalWagonCouplerType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TelectricalWagonCouplerType>> DeleteTelectricalWagonCouplerType(long id)
        {
            var telectricalWagonCouplerType = await _context.TelectricalWagonCouplerType.FindAsync(id);
            if (telectricalWagonCouplerType == null)
            {
                return NotFound();
            }

            _context.TelectricalWagonCouplerType.Remove(telectricalWagonCouplerType);
            await _context.SaveChangesAsync();

            return telectricalWagonCouplerType;
        }

        private bool TelectricalWagonCouplerTypeExists(long id)
        {
            return _context.TelectricalWagonCouplerType.Any(e => e.TelectricalWagonCouplerTypeId == id);
        }
    }
}
