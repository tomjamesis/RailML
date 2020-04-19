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
    public class EcrossedElementsController : ControllerBase
    {
        private readonly DBContext _context;

        public EcrossedElementsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EcrossedElements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EcrossedElements>>> GetEcrossedElements()
        {
            return await _context.EcrossedElements.ToListAsync();
        }

        // GET: api/EcrossedElements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EcrossedElements>> GetEcrossedElements(long id)
        {
            var ecrossedElements = await _context.EcrossedElements.FindAsync(id);

            if (ecrossedElements == null)
            {
                return NotFound();
            }

            return ecrossedElements;
        }

        // PUT: api/EcrossedElements/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEcrossedElements(long id, EcrossedElements ecrossedElements)
        {
            if (id != ecrossedElements.EcrossedElementsId)
            {
                return BadRequest();
            }

            _context.Entry(ecrossedElements).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EcrossedElementsExists(id))
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

        // POST: api/EcrossedElements
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EcrossedElements>> PostEcrossedElements(EcrossedElements ecrossedElements)
        {
            _context.EcrossedElements.Add(ecrossedElements);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EcrossedElementsExists(ecrossedElements.EcrossedElementsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEcrossedElements", new { id = ecrossedElements.EcrossedElementsId }, ecrossedElements);
        }

        // DELETE: api/EcrossedElements/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EcrossedElements>> DeleteEcrossedElements(long id)
        {
            var ecrossedElements = await _context.EcrossedElements.FindAsync(id);
            if (ecrossedElements == null)
            {
                return NotFound();
            }

            _context.EcrossedElements.Remove(ecrossedElements);
            await _context.SaveChangesAsync();

            return ecrossedElements;
        }

        private bool EcrossedElementsExists(long id)
        {
            return _context.EcrossedElements.Any(e => e.EcrossedElementsId == id);
        }
    }
}
