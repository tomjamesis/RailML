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
    public class EborderController : ControllerBase
    {
        private readonly DBContext _context;

        public EborderController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Eborder
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eborder>>> GetEborder()
        {
            return await _context.Eborder.ToListAsync();
        }

        // GET: api/Eborder/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eborder>> GetEborder(long id)
        {
            var eborder = await _context.Eborder.FindAsync(id);

            if (eborder == null)
            {
                return NotFound();
            }

            return eborder;
        }

        // PUT: api/Eborder/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEborder(long id, Eborder eborder)
        {
            if (id != eborder.EborderId)
            {
                return BadRequest();
            }

            _context.Entry(eborder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EborderExists(id))
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

        // POST: api/Eborder
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eborder>> PostEborder(Eborder eborder)
        {
            _context.Eborder.Add(eborder);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EborderExists(eborder.EborderId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEborder", new { id = eborder.EborderId }, eborder);
        }

        // DELETE: api/Eborder/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eborder>> DeleteEborder(long id)
        {
            var eborder = await _context.Eborder.FindAsync(id);
            if (eborder == null)
            {
                return NotFound();
            }

            _context.Eborder.Remove(eborder);
            await _context.SaveChangesAsync();

            return eborder;
        }

        private bool EborderExists(long id)
        {
            return _context.Eborder.Any(e => e.EborderId == id);
        }
    }
}
