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
    public class TtrainRadioController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainRadioController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrainRadio
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrainRadio>>> GetTtrainRadio()
        {
            return await _context.TtrainRadio.ToListAsync();
        }

        // GET: api/TtrainRadio/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrainRadio>> GetTtrainRadio(short id)
        {
            var ttrainRadio = await _context.TtrainRadio.FindAsync(id);

            if (ttrainRadio == null)
            {
                return NotFound();
            }

            return ttrainRadio;
        }

        // PUT: api/TtrainRadio/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrainRadio(short id, TtrainRadio ttrainRadio)
        {
            if (id != ttrainRadio.TtrainRadioId)
            {
                return BadRequest();
            }

            _context.Entry(ttrainRadio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainRadioExists(id))
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

        // POST: api/TtrainRadio
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrainRadio>> PostTtrainRadio(TtrainRadio ttrainRadio)
        {
            _context.TtrainRadio.Add(ttrainRadio);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainRadioExists(ttrainRadio.TtrainRadioId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrainRadio", new { id = ttrainRadio.TtrainRadioId }, ttrainRadio);
        }

        // DELETE: api/TtrainRadio/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrainRadio>> DeleteTtrainRadio(short id)
        {
            var ttrainRadio = await _context.TtrainRadio.FindAsync(id);
            if (ttrainRadio == null)
            {
                return NotFound();
            }

            _context.TtrainRadio.Remove(ttrainRadio);
            await _context.SaveChangesAsync();

            return ttrainRadio;
        }

        private bool TtrainRadioExists(short id)
        {
            return _context.TtrainRadio.Any(e => e.TtrainRadioId == id);
        }
    }
}
