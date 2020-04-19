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
    public class TdriversCabTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TdriversCabTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TdriversCabType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TdriversCabType>>> GetTdriversCabType()
        {
            return await _context.TdriversCabType.ToListAsync();
        }

        // GET: api/TdriversCabType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TdriversCabType>> GetTdriversCabType(long id)
        {
            var tdriversCabType = await _context.TdriversCabType.FindAsync(id);

            if (tdriversCabType == null)
            {
                return NotFound();
            }

            return tdriversCabType;
        }

        // PUT: api/TdriversCabType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdriversCabType(long id, TdriversCabType tdriversCabType)
        {
            if (id != tdriversCabType.TdriversCabTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tdriversCabType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdriversCabTypeExists(id))
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

        // POST: api/TdriversCabType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TdriversCabType>> PostTdriversCabType(TdriversCabType tdriversCabType)
        {
            _context.TdriversCabType.Add(tdriversCabType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TdriversCabTypeExists(tdriversCabType.TdriversCabTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTdriversCabType", new { id = tdriversCabType.TdriversCabTypeId }, tdriversCabType);
        }

        // DELETE: api/TdriversCabType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TdriversCabType>> DeleteTdriversCabType(long id)
        {
            var tdriversCabType = await _context.TdriversCabType.FindAsync(id);
            if (tdriversCabType == null)
            {
                return NotFound();
            }

            _context.TdriversCabType.Remove(tdriversCabType);
            await _context.SaveChangesAsync();

            return tdriversCabType;
        }

        private bool TdriversCabTypeExists(long id)
        {
            return _context.TdriversCabType.Any(e => e.TdriversCabTypeId == id);
        }
    }
}
