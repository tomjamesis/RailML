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
    public class TborderController : ControllerBase
    {
        private readonly DBContext _context;

        public TborderController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tborder
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tborder>>> GetTborder()
        {
            return await _context.Tborder.ToListAsync();
        }

        // GET: api/Tborder/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tborder>> GetTborder(short id)
        {
            var tborder = await _context.Tborder.FindAsync(id);

            if (tborder == null)
            {
                return NotFound();
            }

            return tborder;
        }

        // PUT: api/Tborder/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTborder(short id, Tborder tborder)
        {
            if (id != tborder.TborderId)
            {
                return BadRequest();
            }

            _context.Entry(tborder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TborderExists(id))
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

        // POST: api/Tborder
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tborder>> PostTborder(Tborder tborder)
        {
            _context.Tborder.Add(tborder);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TborderExists(tborder.TborderId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTborder", new { id = tborder.TborderId }, tborder);
        }

        // DELETE: api/Tborder/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tborder>> DeleteTborder(short id)
        {
            var tborder = await _context.Tborder.FindAsync(id);
            if (tborder == null)
            {
                return NotFound();
            }

            _context.Tborder.Remove(tborder);
            await _context.SaveChangesAsync();

            return tborder;
        }

        private bool TborderExists(short id)
        {
            return _context.Tborder.Any(e => e.TborderId == id);
        }
    }
}
