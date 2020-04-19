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
    public class TbufferStopController : ControllerBase
    {
        private readonly DBContext _context;

        public TbufferStopController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TbufferStop
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbufferStop>>> GetTbufferStop()
        {
            return await _context.TbufferStop.ToListAsync();
        }

        // GET: api/TbufferStop/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbufferStop>> GetTbufferStop(short id)
        {
            var tbufferStop = await _context.TbufferStop.FindAsync(id);

            if (tbufferStop == null)
            {
                return NotFound();
            }

            return tbufferStop;
        }

        // PUT: api/TbufferStop/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbufferStop(short id, TbufferStop tbufferStop)
        {
            if (id != tbufferStop.TbufferStopId)
            {
                return BadRequest();
            }

            _context.Entry(tbufferStop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbufferStopExists(id))
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

        // POST: api/TbufferStop
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TbufferStop>> PostTbufferStop(TbufferStop tbufferStop)
        {
            _context.TbufferStop.Add(tbufferStop);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbufferStopExists(tbufferStop.TbufferStopId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbufferStop", new { id = tbufferStop.TbufferStopId }, tbufferStop);
        }

        // DELETE: api/TbufferStop/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbufferStop>> DeleteTbufferStop(short id)
        {
            var tbufferStop = await _context.TbufferStop.FindAsync(id);
            if (tbufferStop == null)
            {
                return NotFound();
            }

            _context.TbufferStop.Remove(tbufferStop);
            await _context.SaveChangesAsync();

            return tbufferStop;
        }

        private bool TbufferStopExists(short id)
        {
            return _context.TbufferStop.Any(e => e.TbufferStopId == id);
        }
    }
}
