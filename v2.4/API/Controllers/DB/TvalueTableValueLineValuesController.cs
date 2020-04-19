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
    public class TvalueTableValueLineValuesController : ControllerBase
    {
        private readonly DBContext _context;

        public TvalueTableValueLineValuesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TvalueTableValueLineValues
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TvalueTableValueLineValues>>> GetTvalueTableValueLineValues()
        {
            return await _context.TvalueTableValueLineValues.ToListAsync();
        }

        // GET: api/TvalueTableValueLineValues/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TvalueTableValueLineValues>> GetTvalueTableValueLineValues(long id)
        {
            var tvalueTableValueLineValues = await _context.TvalueTableValueLineValues.FindAsync(id);

            if (tvalueTableValueLineValues == null)
            {
                return NotFound();
            }

            return tvalueTableValueLineValues;
        }

        // PUT: api/TvalueTableValueLineValues/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTvalueTableValueLineValues(long id, TvalueTableValueLineValues tvalueTableValueLineValues)
        {
            if (id != tvalueTableValueLineValues.TvalueTableValueLineValuesId)
            {
                return BadRequest();
            }

            _context.Entry(tvalueTableValueLineValues).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TvalueTableValueLineValuesExists(id))
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

        // POST: api/TvalueTableValueLineValues
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TvalueTableValueLineValues>> PostTvalueTableValueLineValues(TvalueTableValueLineValues tvalueTableValueLineValues)
        {
            _context.TvalueTableValueLineValues.Add(tvalueTableValueLineValues);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TvalueTableValueLineValuesExists(tvalueTableValueLineValues.TvalueTableValueLineValuesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTvalueTableValueLineValues", new { id = tvalueTableValueLineValues.TvalueTableValueLineValuesId }, tvalueTableValueLineValues);
        }

        // DELETE: api/TvalueTableValueLineValues/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TvalueTableValueLineValues>> DeleteTvalueTableValueLineValues(long id)
        {
            var tvalueTableValueLineValues = await _context.TvalueTableValueLineValues.FindAsync(id);
            if (tvalueTableValueLineValues == null)
            {
                return NotFound();
            }

            _context.TvalueTableValueLineValues.Remove(tvalueTableValueLineValues);
            await _context.SaveChangesAsync();

            return tvalueTableValueLineValues;
        }

        private bool TvalueTableValueLineValuesExists(long id)
        {
            return _context.TvalueTableValueLineValues.Any(e => e.TvalueTableValueLineValuesId == id);
        }
    }
}
