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
    public class TuniqueTrainKeyController : ControllerBase
    {
        private readonly DBContext _context;

        public TuniqueTrainKeyController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TuniqueTrainKey
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TuniqueTrainKey>>> GetTuniqueTrainKey()
        {
            return await _context.TuniqueTrainKey.ToListAsync();
        }

        // GET: api/TuniqueTrainKey/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TuniqueTrainKey>> GetTuniqueTrainKey(long id)
        {
            var tuniqueTrainKey = await _context.TuniqueTrainKey.FindAsync(id);

            if (tuniqueTrainKey == null)
            {
                return NotFound();
            }

            return tuniqueTrainKey;
        }

        // PUT: api/TuniqueTrainKey/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTuniqueTrainKey(long id, TuniqueTrainKey tuniqueTrainKey)
        {
            if (id != tuniqueTrainKey.TuniqueTrainKeyId)
            {
                return BadRequest();
            }

            _context.Entry(tuniqueTrainKey).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TuniqueTrainKeyExists(id))
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

        // POST: api/TuniqueTrainKey
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TuniqueTrainKey>> PostTuniqueTrainKey(TuniqueTrainKey tuniqueTrainKey)
        {
            _context.TuniqueTrainKey.Add(tuniqueTrainKey);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TuniqueTrainKeyExists(tuniqueTrainKey.TuniqueTrainKeyId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTuniqueTrainKey", new { id = tuniqueTrainKey.TuniqueTrainKeyId }, tuniqueTrainKey);
        }

        // DELETE: api/TuniqueTrainKey/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TuniqueTrainKey>> DeleteTuniqueTrainKey(long id)
        {
            var tuniqueTrainKey = await _context.TuniqueTrainKey.FindAsync(id);
            if (tuniqueTrainKey == null)
            {
                return NotFound();
            }

            _context.TuniqueTrainKey.Remove(tuniqueTrainKey);
            await _context.SaveChangesAsync();

            return tuniqueTrainKey;
        }

        private bool TuniqueTrainKeyExists(long id)
        {
            return _context.TuniqueTrainKey.Any(e => e.TuniqueTrainKeyId == id);
        }
    }
}
