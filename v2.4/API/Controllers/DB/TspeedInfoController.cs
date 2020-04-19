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
    public class TspeedInfoController : ControllerBase
    {
        private readonly DBContext _context;

        public TspeedInfoController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TspeedInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TspeedInfo>>> GetTspeedInfo()
        {
            return await _context.TspeedInfo.ToListAsync();
        }

        // GET: api/TspeedInfo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TspeedInfo>> GetTspeedInfo(long id)
        {
            var tspeedInfo = await _context.TspeedInfo.FindAsync(id);

            if (tspeedInfo == null)
            {
                return NotFound();
            }

            return tspeedInfo;
        }

        // PUT: api/TspeedInfo/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTspeedInfo(long id, TspeedInfo tspeedInfo)
        {
            if (id != tspeedInfo.TspeedInfoId)
            {
                return BadRequest();
            }

            _context.Entry(tspeedInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TspeedInfoExists(id))
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

        // POST: api/TspeedInfo
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TspeedInfo>> PostTspeedInfo(TspeedInfo tspeedInfo)
        {
            _context.TspeedInfo.Add(tspeedInfo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TspeedInfoExists(tspeedInfo.TspeedInfoId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTspeedInfo", new { id = tspeedInfo.TspeedInfoId }, tspeedInfo);
        }

        // DELETE: api/TspeedInfo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TspeedInfo>> DeleteTspeedInfo(long id)
        {
            var tspeedInfo = await _context.TspeedInfo.FindAsync(id);
            if (tspeedInfo == null)
            {
                return NotFound();
            }

            _context.TspeedInfo.Remove(tspeedInfo);
            await _context.SaveChangesAsync();

            return tspeedInfo;
        }

        private bool TspeedInfoExists(long id)
        {
            return _context.TspeedInfo.Any(e => e.TspeedInfoId == id);
        }
    }
}
