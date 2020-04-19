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
    public class TcrossedElementController : ControllerBase
    {
        private readonly DBContext _context;

        public TcrossedElementController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TcrossedElement
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TcrossedElement>>> GetTcrossedElement()
        {
            return await _context.TcrossedElement.ToListAsync();
        }

        // GET: api/TcrossedElement/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TcrossedElement>> GetTcrossedElement(short id)
        {
            var tcrossedElement = await _context.TcrossedElement.FindAsync(id);

            if (tcrossedElement == null)
            {
                return NotFound();
            }

            return tcrossedElement;
        }

        // PUT: api/TcrossedElement/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTcrossedElement(short id, TcrossedElement tcrossedElement)
        {
            if (id != tcrossedElement.TcrossedElementId)
            {
                return BadRequest();
            }

            _context.Entry(tcrossedElement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TcrossedElementExists(id))
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

        // POST: api/TcrossedElement
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TcrossedElement>> PostTcrossedElement(TcrossedElement tcrossedElement)
        {
            _context.TcrossedElement.Add(tcrossedElement);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TcrossedElementExists(tcrossedElement.TcrossedElementId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTcrossedElement", new { id = tcrossedElement.TcrossedElementId }, tcrossedElement);
        }

        // DELETE: api/TcrossedElement/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TcrossedElement>> DeleteTcrossedElement(short id)
        {
            var tcrossedElement = await _context.TcrossedElement.FindAsync(id);
            if (tcrossedElement == null)
            {
                return NotFound();
            }

            _context.TcrossedElement.Remove(tcrossedElement);
            await _context.SaveChangesAsync();

            return tcrossedElement;
        }

        private bool TcrossedElementExists(short id)
        {
            return _context.TcrossedElement.Any(e => e.TcrossedElementId == id);
        }
    }
}
