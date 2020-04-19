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
    public class TclearanceGaugeTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TclearanceGaugeTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TclearanceGaugeType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TclearanceGaugeType>>> GetTclearanceGaugeType()
        {
            return await _context.TclearanceGaugeType.ToListAsync();
        }

        // GET: api/TclearanceGaugeType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TclearanceGaugeType>> GetTclearanceGaugeType(long id)
        {
            var tclearanceGaugeType = await _context.TclearanceGaugeType.FindAsync(id);

            if (tclearanceGaugeType == null)
            {
                return NotFound();
            }

            return tclearanceGaugeType;
        }

        // PUT: api/TclearanceGaugeType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTclearanceGaugeType(long id, TclearanceGaugeType tclearanceGaugeType)
        {
            if (id != tclearanceGaugeType.TclearanceGaugeTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tclearanceGaugeType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TclearanceGaugeTypeExists(id))
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

        // POST: api/TclearanceGaugeType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TclearanceGaugeType>> PostTclearanceGaugeType(TclearanceGaugeType tclearanceGaugeType)
        {
            _context.TclearanceGaugeType.Add(tclearanceGaugeType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TclearanceGaugeTypeExists(tclearanceGaugeType.TclearanceGaugeTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTclearanceGaugeType", new { id = tclearanceGaugeType.TclearanceGaugeTypeId }, tclearanceGaugeType);
        }

        // DELETE: api/TclearanceGaugeType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TclearanceGaugeType>> DeleteTclearanceGaugeType(long id)
        {
            var tclearanceGaugeType = await _context.TclearanceGaugeType.FindAsync(id);
            if (tclearanceGaugeType == null)
            {
                return NotFound();
            }

            _context.TclearanceGaugeType.Remove(tclearanceGaugeType);
            await _context.SaveChangesAsync();

            return tclearanceGaugeType;
        }

        private bool TclearanceGaugeTypeExists(long id)
        {
            return _context.TclearanceGaugeType.Any(e => e.TclearanceGaugeTypeId == id);
        }
    }
}
