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
    public class TcabPositionTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TcabPositionTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TcabPositionType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TcabPositionType>>> GetTcabPositionType()
        {
            return await _context.TcabPositionType.ToListAsync();
        }

        // GET: api/TcabPositionType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TcabPositionType>> GetTcabPositionType(byte id)
        {
            var tcabPositionType = await _context.TcabPositionType.FindAsync(id);

            if (tcabPositionType == null)
            {
                return NotFound();
            }

            return tcabPositionType;
        }

        // PUT: api/TcabPositionType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTcabPositionType(byte id, TcabPositionType tcabPositionType)
        {
            if (id != tcabPositionType.TcabPositionTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tcabPositionType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TcabPositionTypeExists(id))
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

        // POST: api/TcabPositionType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TcabPositionType>> PostTcabPositionType(TcabPositionType tcabPositionType)
        {
            _context.TcabPositionType.Add(tcabPositionType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TcabPositionTypeExists(tcabPositionType.TcabPositionTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTcabPositionType", new { id = tcabPositionType.TcabPositionTypeId }, tcabPositionType);
        }

        // DELETE: api/TcabPositionType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TcabPositionType>> DeleteTcabPositionType(byte id)
        {
            var tcabPositionType = await _context.TcabPositionType.FindAsync(id);
            if (tcabPositionType == null)
            {
                return NotFound();
            }

            _context.TcabPositionType.Remove(tcabPositionType);
            await _context.SaveChangesAsync();

            return tcabPositionType;
        }

        private bool TcabPositionTypeExists(byte id)
        {
            return _context.TcabPositionType.Any(e => e.TcabPositionTypeId == id);
        }
    }
}
