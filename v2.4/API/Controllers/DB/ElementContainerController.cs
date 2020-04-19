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
    public class ElementContainerController : ControllerBase
    {
        private readonly DBContext _context;

        public ElementContainerController(DBContext context)
        {
            _context = context;
        }

        // GET: api/ElementContainer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ElementContainer>>> GetElementContainer()
        {
            return await _context.ElementContainer.ToListAsync();
        }

        // GET: api/ElementContainer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ElementContainer>> GetElementContainer(long id)
        {
            var elementContainer = await _context.ElementContainer.FindAsync(id);

            if (elementContainer == null)
            {
                return NotFound();
            }

            return elementContainer;
        }

        // PUT: api/ElementContainer/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElementContainer(long id, ElementContainer elementContainer)
        {
            if (id != elementContainer.ElementContainerId)
            {
                return BadRequest();
            }

            _context.Entry(elementContainer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElementContainerExists(id))
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

        // POST: api/ElementContainer
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ElementContainer>> PostElementContainer(ElementContainer elementContainer)
        {
            _context.ElementContainer.Add(elementContainer);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ElementContainerExists(elementContainer.ElementContainerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetElementContainer", new { id = elementContainer.ElementContainerId }, elementContainer);
        }

        // DELETE: api/ElementContainer/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ElementContainer>> DeleteElementContainer(long id)
        {
            var elementContainer = await _context.ElementContainer.FindAsync(id);
            if (elementContainer == null)
            {
                return NotFound();
            }

            _context.ElementContainer.Remove(elementContainer);
            await _context.SaveChangesAsync();

            return elementContainer;
        }

        private bool ElementContainerExists(long id)
        {
            return _context.ElementContainer.Any(e => e.ElementContainerId == id);
        }
    }
}
