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
    public class TswitchConnectionDataController : ControllerBase
    {
        private readonly DBContext _context;

        public TswitchConnectionDataController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TswitchConnectionData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TswitchConnectionData>>> GetTswitchConnectionData()
        {
            return await _context.TswitchConnectionData.ToListAsync();
        }

        // GET: api/TswitchConnectionData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TswitchConnectionData>> GetTswitchConnectionData(short id)
        {
            var tswitchConnectionData = await _context.TswitchConnectionData.FindAsync(id);

            if (tswitchConnectionData == null)
            {
                return NotFound();
            }

            return tswitchConnectionData;
        }

        // PUT: api/TswitchConnectionData/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTswitchConnectionData(short id, TswitchConnectionData tswitchConnectionData)
        {
            if (id != tswitchConnectionData.TswitchConnectionDataId)
            {
                return BadRequest();
            }

            _context.Entry(tswitchConnectionData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TswitchConnectionDataExists(id))
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

        // POST: api/TswitchConnectionData
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TswitchConnectionData>> PostTswitchConnectionData(TswitchConnectionData tswitchConnectionData)
        {
            _context.TswitchConnectionData.Add(tswitchConnectionData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TswitchConnectionDataExists(tswitchConnectionData.TswitchConnectionDataId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTswitchConnectionData", new { id = tswitchConnectionData.TswitchConnectionDataId }, tswitchConnectionData);
        }

        // DELETE: api/TswitchConnectionData/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TswitchConnectionData>> DeleteTswitchConnectionData(short id)
        {
            var tswitchConnectionData = await _context.TswitchConnectionData.FindAsync(id);
            if (tswitchConnectionData == null)
            {
                return NotFound();
            }

            _context.TswitchConnectionData.Remove(tswitchConnectionData);
            await _context.SaveChangesAsync();

            return tswitchConnectionData;
        }

        private bool TswitchConnectionDataExists(short id)
        {
            return _context.TswitchConnectionData.Any(e => e.TswitchConnectionDataId == id);
        }
    }
}
