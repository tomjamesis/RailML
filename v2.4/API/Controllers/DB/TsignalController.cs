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
    public class TsignalController : ControllerBase
    {
        private readonly DBContext _context;

        public TsignalController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tsignal
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tsignal>>> GetTsignal()
        {
            return await _context.Tsignal.ToListAsync();
        }

        // GET: api/Tsignal/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tsignal>> GetTsignal(short id)
        {
            var tsignal = await _context.Tsignal.FindAsync(id);

            if (tsignal == null)
            {
                return NotFound();
            }

            return tsignal;
        }

        // PUT: api/Tsignal/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTsignal(short id, Tsignal tsignal)
        {
            if (id != tsignal.TsignalId)
            {
                return BadRequest();
            }

            _context.Entry(tsignal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TsignalExists(id))
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

        // POST: api/Tsignal
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tsignal>> PostTsignal(Tsignal tsignal)
        {
            _context.Tsignal.Add(tsignal);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TsignalExists(tsignal.TsignalId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTsignal", new { id = tsignal.TsignalId }, tsignal);
        }

        // DELETE: api/Tsignal/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tsignal>> DeleteTsignal(short id)
        {
            var tsignal = await _context.Tsignal.FindAsync(id);
            if (tsignal == null)
            {
                return NotFound();
            }

            _context.Tsignal.Remove(tsignal);
            await _context.SaveChangesAsync();

            return tsignal;
        }

        private bool TsignalExists(short id)
        {
            return _context.Tsignal.Any(e => e.TsignalId == id);
        }
    }
}
