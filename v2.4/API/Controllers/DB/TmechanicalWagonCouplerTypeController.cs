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
    public class TmechanicalWagonCouplerTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TmechanicalWagonCouplerTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TmechanicalWagonCouplerType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TmechanicalWagonCouplerType>>> GetTmechanicalWagonCouplerType()
        {
            return await _context.TmechanicalWagonCouplerType.ToListAsync();
        }

        // GET: api/TmechanicalWagonCouplerType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TmechanicalWagonCouplerType>> GetTmechanicalWagonCouplerType(long id)
        {
            var tmechanicalWagonCouplerType = await _context.TmechanicalWagonCouplerType.FindAsync(id);

            if (tmechanicalWagonCouplerType == null)
            {
                return NotFound();
            }

            return tmechanicalWagonCouplerType;
        }

        // PUT: api/TmechanicalWagonCouplerType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTmechanicalWagonCouplerType(long id, TmechanicalWagonCouplerType tmechanicalWagonCouplerType)
        {
            if (id != tmechanicalWagonCouplerType.TmechanicalWagonCouplerTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tmechanicalWagonCouplerType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TmechanicalWagonCouplerTypeExists(id))
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

        // POST: api/TmechanicalWagonCouplerType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TmechanicalWagonCouplerType>> PostTmechanicalWagonCouplerType(TmechanicalWagonCouplerType tmechanicalWagonCouplerType)
        {
            _context.TmechanicalWagonCouplerType.Add(tmechanicalWagonCouplerType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TmechanicalWagonCouplerTypeExists(tmechanicalWagonCouplerType.TmechanicalWagonCouplerTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTmechanicalWagonCouplerType", new { id = tmechanicalWagonCouplerType.TmechanicalWagonCouplerTypeId }, tmechanicalWagonCouplerType);
        }

        // DELETE: api/TmechanicalWagonCouplerType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TmechanicalWagonCouplerType>> DeleteTmechanicalWagonCouplerType(long id)
        {
            var tmechanicalWagonCouplerType = await _context.TmechanicalWagonCouplerType.FindAsync(id);
            if (tmechanicalWagonCouplerType == null)
            {
                return NotFound();
            }

            _context.TmechanicalWagonCouplerType.Remove(tmechanicalWagonCouplerType);
            await _context.SaveChangesAsync();

            return tmechanicalWagonCouplerType;
        }

        private bool TmechanicalWagonCouplerTypeExists(long id)
        {
            return _context.TmechanicalWagonCouplerType.Any(e => e.TmechanicalWagonCouplerTypeId == id);
        }
    }
}
