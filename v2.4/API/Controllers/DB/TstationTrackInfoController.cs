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
    public class TstationTrackInfoController : ControllerBase
    {
        private readonly DBContext _context;

        public TstationTrackInfoController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TstationTrackInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TstationTrackInfo>>> GetTstationTrackInfo()
        {
            return await _context.TstationTrackInfo.ToListAsync();
        }

        // GET: api/TstationTrackInfo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TstationTrackInfo>> GetTstationTrackInfo(long id)
        {
            var tstationTrackInfo = await _context.TstationTrackInfo.FindAsync(id);

            if (tstationTrackInfo == null)
            {
                return NotFound();
            }

            return tstationTrackInfo;
        }

        // PUT: api/TstationTrackInfo/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTstationTrackInfo(long id, TstationTrackInfo tstationTrackInfo)
        {
            if (id != tstationTrackInfo.TstationTrackInfoId)
            {
                return BadRequest();
            }

            _context.Entry(tstationTrackInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TstationTrackInfoExists(id))
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

        // POST: api/TstationTrackInfo
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TstationTrackInfo>> PostTstationTrackInfo(TstationTrackInfo tstationTrackInfo)
        {
            _context.TstationTrackInfo.Add(tstationTrackInfo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TstationTrackInfoExists(tstationTrackInfo.TstationTrackInfoId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTstationTrackInfo", new { id = tstationTrackInfo.TstationTrackInfoId }, tstationTrackInfo);
        }

        // DELETE: api/TstationTrackInfo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TstationTrackInfo>> DeleteTstationTrackInfo(long id)
        {
            var tstationTrackInfo = await _context.TstationTrackInfo.FindAsync(id);
            if (tstationTrackInfo == null)
            {
                return NotFound();
            }

            _context.TstationTrackInfo.Remove(tstationTrackInfo);
            await _context.SaveChangesAsync();

            return tstationTrackInfo;
        }

        private bool TstationTrackInfoExists(long id)
        {
            return _context.TstationTrackInfo.Any(e => e.TstationTrackInfoId == id);
        }
    }
}
