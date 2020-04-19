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
    public class EtrackElementsController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrackElementsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrackElements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrackElements>>> GetEtrackElements()
        {
            return await _context.EtrackElements.ToListAsync();
        }

        // GET: api/EtrackElements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrackElements>> GetEtrackElements(long id)
        {
            var etrackElements = await _context.EtrackElements.FindAsync(id);

            if (etrackElements == null)
            {
                return NotFound();
            }

            return etrackElements;
        }

        // PUT: api/EtrackElements/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrackElements(long id, EtrackElements etrackElements)
        {
            if (id != etrackElements.EtrackElementsId)
            {
                return BadRequest();
            }

            _context.Entry(etrackElements).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrackElementsExists(id))
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

        // POST: api/EtrackElements
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrackElements>> PostEtrackElements(EtrackElements etrackElements)
        {
            _context.EtrackElements.Add(etrackElements);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrackElementsExists(etrackElements.EtrackElementsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrackElements", new { id = etrackElements.EtrackElementsId }, etrackElements);
        }

        // DELETE: api/EtrackElements/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrackElements>> DeleteEtrackElements(long id)
        {
            var etrackElements = await _context.EtrackElements.FindAsync(id);
            if (etrackElements == null)
            {
                return NotFound();
            }

            _context.EtrackElements.Remove(etrackElements);
            await _context.SaveChangesAsync();

            return etrackElements;
        }

        private bool EtrackElementsExists(long id)
        {
            return _context.EtrackElements.Any(e => e.EtrackElementsId == id);
        }
    }
}
