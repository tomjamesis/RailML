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
    public class EtrainDetectionElementsController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrainDetectionElementsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrainDetectionElements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrainDetectionElements>>> GetEtrainDetectionElements()
        {
            return await _context.EtrainDetectionElements.ToListAsync();
        }

        // GET: api/EtrainDetectionElements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrainDetectionElements>> GetEtrainDetectionElements(long id)
        {
            var etrainDetectionElements = await _context.EtrainDetectionElements.FindAsync(id);

            if (etrainDetectionElements == null)
            {
                return NotFound();
            }

            return etrainDetectionElements;
        }

        // PUT: api/EtrainDetectionElements/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrainDetectionElements(long id, EtrainDetectionElements etrainDetectionElements)
        {
            if (id != etrainDetectionElements.EtrainDetectionElementsId)
            {
                return BadRequest();
            }

            _context.Entry(etrainDetectionElements).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrainDetectionElementsExists(id))
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

        // POST: api/EtrainDetectionElements
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrainDetectionElements>> PostEtrainDetectionElements(EtrainDetectionElements etrainDetectionElements)
        {
            _context.EtrainDetectionElements.Add(etrainDetectionElements);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrainDetectionElementsExists(etrainDetectionElements.EtrainDetectionElementsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrainDetectionElements", new { id = etrainDetectionElements.EtrainDetectionElementsId }, etrainDetectionElements);
        }

        // DELETE: api/EtrainDetectionElements/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrainDetectionElements>> DeleteEtrainDetectionElements(long id)
        {
            var etrainDetectionElements = await _context.EtrainDetectionElements.FindAsync(id);
            if (etrainDetectionElements == null)
            {
                return NotFound();
            }

            _context.EtrainDetectionElements.Remove(etrainDetectionElements);
            await _context.SaveChangesAsync();

            return etrainDetectionElements;
        }

        private bool EtrainDetectionElementsExists(long id)
        {
            return _context.EtrainDetectionElements.Any(e => e.EtrainDetectionElementsId == id);
        }
    }
}
