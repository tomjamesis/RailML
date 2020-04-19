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
    public class EtrainProtectionElementsController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrainProtectionElementsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrainProtectionElements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrainProtectionElements>>> GetEtrainProtectionElements()
        {
            return await _context.EtrainProtectionElements.ToListAsync();
        }

        // GET: api/EtrainProtectionElements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrainProtectionElements>> GetEtrainProtectionElements(long id)
        {
            var etrainProtectionElements = await _context.EtrainProtectionElements.FindAsync(id);

            if (etrainProtectionElements == null)
            {
                return NotFound();
            }

            return etrainProtectionElements;
        }

        // PUT: api/EtrainProtectionElements/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrainProtectionElements(long id, EtrainProtectionElements etrainProtectionElements)
        {
            if (id != etrainProtectionElements.EtrainProtectionElementsId)
            {
                return BadRequest();
            }

            _context.Entry(etrainProtectionElements).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrainProtectionElementsExists(id))
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

        // POST: api/EtrainProtectionElements
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrainProtectionElements>> PostEtrainProtectionElements(EtrainProtectionElements etrainProtectionElements)
        {
            _context.EtrainProtectionElements.Add(etrainProtectionElements);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrainProtectionElementsExists(etrainProtectionElements.EtrainProtectionElementsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrainProtectionElements", new { id = etrainProtectionElements.EtrainProtectionElementsId }, etrainProtectionElements);
        }

        // DELETE: api/EtrainProtectionElements/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrainProtectionElements>> DeleteEtrainProtectionElements(long id)
        {
            var etrainProtectionElements = await _context.EtrainProtectionElements.FindAsync(id);
            if (etrainProtectionElements == null)
            {
                return NotFound();
            }

            _context.EtrainProtectionElements.Remove(etrainProtectionElements);
            await _context.SaveChangesAsync();

            return etrainProtectionElements;
        }

        private bool EtrainProtectionElementsExists(long id)
        {
            return _context.EtrainProtectionElements.Any(e => e.EtrainProtectionElementsId == id);
        }
    }
}
