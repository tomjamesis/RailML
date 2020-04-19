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
    public class TcommonSwitchAndCrossingDataController : ControllerBase
    {
        private readonly DBContext _context;

        public TcommonSwitchAndCrossingDataController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TcommonSwitchAndCrossingData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TcommonSwitchAndCrossingData>>> GetTcommonSwitchAndCrossingData()
        {
            return await _context.TcommonSwitchAndCrossingData.ToListAsync();
        }

        // GET: api/TcommonSwitchAndCrossingData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TcommonSwitchAndCrossingData>> GetTcommonSwitchAndCrossingData(short id)
        {
            var tcommonSwitchAndCrossingData = await _context.TcommonSwitchAndCrossingData.FindAsync(id);

            if (tcommonSwitchAndCrossingData == null)
            {
                return NotFound();
            }

            return tcommonSwitchAndCrossingData;
        }

        // PUT: api/TcommonSwitchAndCrossingData/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTcommonSwitchAndCrossingData(short id, TcommonSwitchAndCrossingData tcommonSwitchAndCrossingData)
        {
            if (id != tcommonSwitchAndCrossingData.TcommonSwitchAndCrossingDataId)
            {
                return BadRequest();
            }

            _context.Entry(tcommonSwitchAndCrossingData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TcommonSwitchAndCrossingDataExists(id))
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

        // POST: api/TcommonSwitchAndCrossingData
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TcommonSwitchAndCrossingData>> PostTcommonSwitchAndCrossingData(TcommonSwitchAndCrossingData tcommonSwitchAndCrossingData)
        {
            _context.TcommonSwitchAndCrossingData.Add(tcommonSwitchAndCrossingData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TcommonSwitchAndCrossingDataExists(tcommonSwitchAndCrossingData.TcommonSwitchAndCrossingDataId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTcommonSwitchAndCrossingData", new { id = tcommonSwitchAndCrossingData.TcommonSwitchAndCrossingDataId }, tcommonSwitchAndCrossingData);
        }

        // DELETE: api/TcommonSwitchAndCrossingData/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TcommonSwitchAndCrossingData>> DeleteTcommonSwitchAndCrossingData(short id)
        {
            var tcommonSwitchAndCrossingData = await _context.TcommonSwitchAndCrossingData.FindAsync(id);
            if (tcommonSwitchAndCrossingData == null)
            {
                return NotFound();
            }

            _context.TcommonSwitchAndCrossingData.Remove(tcommonSwitchAndCrossingData);
            await _context.SaveChangesAsync();

            return tcommonSwitchAndCrossingData;
        }

        private bool TcommonSwitchAndCrossingDataExists(short id)
        {
            return _context.TcommonSwitchAndCrossingData.Any(e => e.TcommonSwitchAndCrossingDataId == id);
        }
    }
}
