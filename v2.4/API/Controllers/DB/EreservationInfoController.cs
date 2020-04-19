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
    public class EreservationInfoController : ControllerBase
    {
        private readonly DBContext _context;

        public EreservationInfoController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EreservationInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EreservationInfo>>> GetEreservationInfo()
        {
            return await _context.EreservationInfo.ToListAsync();
        }

        // GET: api/EreservationInfo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EreservationInfo>> GetEreservationInfo(long id)
        {
            var ereservationInfo = await _context.EreservationInfo.FindAsync(id);

            if (ereservationInfo == null)
            {
                return NotFound();
            }

            return ereservationInfo;
        }

        // PUT: api/EreservationInfo/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEreservationInfo(long id, EreservationInfo ereservationInfo)
        {
            if (id != ereservationInfo.EreservationInfoId)
            {
                return BadRequest();
            }

            _context.Entry(ereservationInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EreservationInfoExists(id))
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

        // POST: api/EreservationInfo
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EreservationInfo>> PostEreservationInfo(EreservationInfo ereservationInfo)
        {
            _context.EreservationInfo.Add(ereservationInfo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EreservationInfoExists(ereservationInfo.EreservationInfoId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEreservationInfo", new { id = ereservationInfo.EreservationInfoId }, ereservationInfo);
        }

        // DELETE: api/EreservationInfo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EreservationInfo>> DeleteEreservationInfo(long id)
        {
            var ereservationInfo = await _context.EreservationInfo.FindAsync(id);
            if (ereservationInfo == null)
            {
                return NotFound();
            }

            _context.EreservationInfo.Remove(ereservationInfo);
            await _context.SaveChangesAsync();

            return ereservationInfo;
        }

        private bool EreservationInfoExists(long id)
        {
            return _context.EreservationInfo.Any(e => e.EreservationInfoId == id);
        }
    }
}
