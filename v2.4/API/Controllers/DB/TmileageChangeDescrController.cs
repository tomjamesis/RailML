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
    public class TmileageChangeDescrController : ControllerBase
    {
        private readonly DBContext _context;

        public TmileageChangeDescrController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TmileageChangeDescr
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TmileageChangeDescr>>> GetTmileageChangeDescr()
        {
            return await _context.TmileageChangeDescr.ToListAsync();
        }

        // GET: api/TmileageChangeDescr/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TmileageChangeDescr>> GetTmileageChangeDescr(byte id)
        {
            var tmileageChangeDescr = await _context.TmileageChangeDescr.FindAsync(id);

            if (tmileageChangeDescr == null)
            {
                return NotFound();
            }

            return tmileageChangeDescr;
        }

        // PUT: api/TmileageChangeDescr/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTmileageChangeDescr(byte id, TmileageChangeDescr tmileageChangeDescr)
        {
            if (id != tmileageChangeDescr.TmileageChangeDescrId)
            {
                return BadRequest();
            }

            _context.Entry(tmileageChangeDescr).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TmileageChangeDescrExists(id))
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

        // POST: api/TmileageChangeDescr
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TmileageChangeDescr>> PostTmileageChangeDescr(TmileageChangeDescr tmileageChangeDescr)
        {
            _context.TmileageChangeDescr.Add(tmileageChangeDescr);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TmileageChangeDescrExists(tmileageChangeDescr.TmileageChangeDescrId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTmileageChangeDescr", new { id = tmileageChangeDescr.TmileageChangeDescrId }, tmileageChangeDescr);
        }

        // DELETE: api/TmileageChangeDescr/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TmileageChangeDescr>> DeleteTmileageChangeDescr(byte id)
        {
            var tmileageChangeDescr = await _context.TmileageChangeDescr.FindAsync(id);
            if (tmileageChangeDescr == null)
            {
                return NotFound();
            }

            _context.TmileageChangeDescr.Remove(tmileageChangeDescr);
            await _context.SaveChangesAsync();

            return tmileageChangeDescr;
        }

        private bool TmileageChangeDescrExists(byte id)
        {
            return _context.TmileageChangeDescr.Any(e => e.TmileageChangeDescrId == id);
        }
    }
}
