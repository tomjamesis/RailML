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
    public class TbookingController : ControllerBase
    {
        private readonly DBContext _context;

        public TbookingController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tbooking
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tbooking>>> GetTbooking()
        {
            return await _context.Tbooking.ToListAsync();
        }

        // GET: api/Tbooking/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tbooking>> GetTbooking(long id)
        {
            var tbooking = await _context.Tbooking.FindAsync(id);

            if (tbooking == null)
            {
                return NotFound();
            }

            return tbooking;
        }

        // PUT: api/Tbooking/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbooking(long id, Tbooking tbooking)
        {
            if (id != tbooking.TbookingId)
            {
                return BadRequest();
            }

            _context.Entry(tbooking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbookingExists(id))
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

        // POST: api/Tbooking
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tbooking>> PostTbooking(Tbooking tbooking)
        {
            _context.Tbooking.Add(tbooking);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbookingExists(tbooking.TbookingId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbooking", new { id = tbooking.TbookingId }, tbooking);
        }

        // DELETE: api/Tbooking/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tbooking>> DeleteTbooking(long id)
        {
            var tbooking = await _context.Tbooking.FindAsync(id);
            if (tbooking == null)
            {
                return NotFound();
            }

            _context.Tbooking.Remove(tbooking);
            await _context.SaveChangesAsync();

            return tbooking;
        }

        private bool TbookingExists(long id)
        {
            return _context.Tbooking.Any(e => e.TbookingId == id);
        }
    }
}
