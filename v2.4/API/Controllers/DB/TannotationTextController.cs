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
    public class TannotationTextController : ControllerBase
    {
        private readonly DBContext _context;

        public TannotationTextController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TannotationText
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TannotationText>>> GetTannotationText()
        {
            return await _context.TannotationText.ToListAsync();
        }

        // GET: api/TannotationText/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TannotationText>> GetTannotationText(long id)
        {
            var tannotationText = await _context.TannotationText.FindAsync(id);

            if (tannotationText == null)
            {
                return NotFound();
            }

            return tannotationText;
        }

        // PUT: api/TannotationText/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTannotationText(long id, TannotationText tannotationText)
        {
            if (id != tannotationText.TannotationTextId)
            {
                return BadRequest();
            }

            _context.Entry(tannotationText).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TannotationTextExists(id))
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

        // POST: api/TannotationText
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TannotationText>> PostTannotationText(TannotationText tannotationText)
        {
            _context.TannotationText.Add(tannotationText);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TannotationTextExists(tannotationText.TannotationTextId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTannotationText", new { id = tannotationText.TannotationTextId }, tannotationText);
        }

        // DELETE: api/TannotationText/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TannotationText>> DeleteTannotationText(long id)
        {
            var tannotationText = await _context.TannotationText.FindAsync(id);
            if (tannotationText == null)
            {
                return NotFound();
            }

            _context.TannotationText.Remove(tannotationText);
            await _context.SaveChangesAsync();

            return tannotationText;
        }

        private bool TannotationTextExists(long id)
        {
            return _context.TannotationText.Any(e => e.TannotationTextId == id);
        }
    }
}
