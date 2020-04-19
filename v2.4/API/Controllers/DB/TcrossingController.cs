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
    public class TcrossingController : ControllerBase
    {
        private readonly DBContext _context;

        public TcrossingController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tcrossing
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tcrossing>>> GetTcrossing()
        {
            return await _context.Tcrossing.ToListAsync();
        }

        // GET: api/Tcrossing/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tcrossing>> GetTcrossing(short id)
        {
            var tcrossing = await _context.Tcrossing.FindAsync(id);

            if (tcrossing == null)
            {
                return NotFound();
            }

            return tcrossing;
        }

        // PUT: api/Tcrossing/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTcrossing(short id, Tcrossing tcrossing)
        {
            if (id != tcrossing.TcrossingId)
            {
                return BadRequest();
            }

            _context.Entry(tcrossing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TcrossingExists(id))
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

        // POST: api/Tcrossing
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tcrossing>> PostTcrossing(Tcrossing tcrossing)
        {
            _context.Tcrossing.Add(tcrossing);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TcrossingExists(tcrossing.TcrossingId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTcrossing", new { id = tcrossing.TcrossingId }, tcrossing);
        }

        // DELETE: api/Tcrossing/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tcrossing>> DeleteTcrossing(short id)
        {
            var tcrossing = await _context.Tcrossing.FindAsync(id);
            if (tcrossing == null)
            {
                return NotFound();
            }

            _context.Tcrossing.Remove(tcrossing);
            await _context.SaveChangesAsync();

            return tcrossing;
        }

        private bool TcrossingExists(short id)
        {
            return _context.Tcrossing.Any(e => e.TcrossingId == id);
        }
    }
}
