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
    public class TsignalTrainRadioController : ControllerBase
    {
        private readonly DBContext _context;

        public TsignalTrainRadioController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TsignalTrainRadio
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TsignalTrainRadio>>> GetTsignalTrainRadio()
        {
            return await _context.TsignalTrainRadio.ToListAsync();
        }

        // GET: api/TsignalTrainRadio/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TsignalTrainRadio>> GetTsignalTrainRadio(short id)
        {
            var tsignalTrainRadio = await _context.TsignalTrainRadio.FindAsync(id);

            if (tsignalTrainRadio == null)
            {
                return NotFound();
            }

            return tsignalTrainRadio;
        }

        // PUT: api/TsignalTrainRadio/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTsignalTrainRadio(short id, TsignalTrainRadio tsignalTrainRadio)
        {
            if (id != tsignalTrainRadio.TsignalTrainRadioId)
            {
                return BadRequest();
            }

            _context.Entry(tsignalTrainRadio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TsignalTrainRadioExists(id))
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

        // POST: api/TsignalTrainRadio
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TsignalTrainRadio>> PostTsignalTrainRadio(TsignalTrainRadio tsignalTrainRadio)
        {
            _context.TsignalTrainRadio.Add(tsignalTrainRadio);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TsignalTrainRadioExists(tsignalTrainRadio.TsignalTrainRadioId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTsignalTrainRadio", new { id = tsignalTrainRadio.TsignalTrainRadioId }, tsignalTrainRadio);
        }

        // DELETE: api/TsignalTrainRadio/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TsignalTrainRadio>> DeleteTsignalTrainRadio(short id)
        {
            var tsignalTrainRadio = await _context.TsignalTrainRadio.FindAsync(id);
            if (tsignalTrainRadio == null)
            {
                return NotFound();
            }

            _context.TsignalTrainRadio.Remove(tsignalTrainRadio);
            await _context.SaveChangesAsync();

            return tsignalTrainRadio;
        }

        private bool TsignalTrainRadioExists(short id)
        {
            return _context.TsignalTrainRadio.Any(e => e.TsignalTrainRadioId == id);
        }
    }
}
