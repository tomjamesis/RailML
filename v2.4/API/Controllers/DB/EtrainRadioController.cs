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
    public class EtrainRadioController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrainRadioController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrainRadio
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrainRadio>>> GetEtrainRadio()
        {
            return await _context.EtrainRadio.ToListAsync();
        }

        // GET: api/EtrainRadio/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrainRadio>> GetEtrainRadio(short id)
        {
            var etrainRadio = await _context.EtrainRadio.FindAsync(id);

            if (etrainRadio == null)
            {
                return NotFound();
            }

            return etrainRadio;
        }

        // PUT: api/EtrainRadio/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrainRadio(short id, EtrainRadio etrainRadio)
        {
            if (id != etrainRadio.EtrainRadioId)
            {
                return BadRequest();
            }

            _context.Entry(etrainRadio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrainRadioExists(id))
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

        // POST: api/EtrainRadio
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrainRadio>> PostEtrainRadio(EtrainRadio etrainRadio)
        {
            _context.EtrainRadio.Add(etrainRadio);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrainRadioExists(etrainRadio.EtrainRadioId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrainRadio", new { id = etrainRadio.EtrainRadioId }, etrainRadio);
        }

        // DELETE: api/EtrainRadio/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrainRadio>> DeleteEtrainRadio(short id)
        {
            var etrainRadio = await _context.EtrainRadio.FindAsync(id);
            if (etrainRadio == null)
            {
                return NotFound();
            }

            _context.EtrainRadio.Remove(etrainRadio);
            await _context.SaveChangesAsync();

            return etrainRadio;
        }

        private bool EtrainRadioExists(short id)
        {
            return _context.EtrainRadio.Any(e => e.EtrainRadioId == id);
        }
    }
}
