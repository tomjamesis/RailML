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
    public class TconnectionDataController : ControllerBase
    {
        private readonly DBContext _context;

        public TconnectionDataController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TconnectionData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TconnectionData>>> GetTconnectionData()
        {
            return await _context.TconnectionData.ToListAsync();
        }

        // GET: api/TconnectionData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TconnectionData>> GetTconnectionData(string id)
        {
            var tconnectionData = await _context.TconnectionData.FindAsync(id);

            if (tconnectionData == null)
            {
                return NotFound();
            }

            return tconnectionData;
        }

        // PUT: api/TconnectionData/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTconnectionData(string id, TconnectionData tconnectionData)
        {
            if (id != tconnectionData.TconnectionDataId)
            {
                return BadRequest();
            }

            _context.Entry(tconnectionData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TconnectionDataExists(id))
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

        // POST: api/TconnectionData
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TconnectionData>> PostTconnectionData(TconnectionData tconnectionData)
        {
            _context.TconnectionData.Add(tconnectionData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TconnectionDataExists(tconnectionData.TconnectionDataId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTconnectionData", new { id = tconnectionData.TconnectionDataId }, tconnectionData);
        }

        // DELETE: api/TconnectionData/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TconnectionData>> DeleteTconnectionData(string id)
        {
            var tconnectionData = await _context.TconnectionData.FindAsync(id);
            if (tconnectionData == null)
            {
                return NotFound();
            }

            _context.TconnectionData.Remove(tconnectionData);
            await _context.SaveChangesAsync();

            return tconnectionData;
        }

        private bool TconnectionDataExists(string id)
        {
            return _context.TconnectionData.Any(e => e.TconnectionDataId == id);
        }
    }
}
