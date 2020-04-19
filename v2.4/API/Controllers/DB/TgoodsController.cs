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
    public class TgoodsController : ControllerBase
    {
        private readonly DBContext _context;

        public TgoodsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tgoods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tgoods>>> GetTgoods()
        {
            return await _context.Tgoods.ToListAsync();
        }

        // GET: api/Tgoods/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tgoods>> GetTgoods(long id)
        {
            var tgoods = await _context.Tgoods.FindAsync(id);

            if (tgoods == null)
            {
                return NotFound();
            }

            return tgoods;
        }

        // PUT: api/Tgoods/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTgoods(long id, Tgoods tgoods)
        {
            if (id != tgoods.TgoodsId)
            {
                return BadRequest();
            }

            _context.Entry(tgoods).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TgoodsExists(id))
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

        // POST: api/Tgoods
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tgoods>> PostTgoods(Tgoods tgoods)
        {
            _context.Tgoods.Add(tgoods);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TgoodsExists(tgoods.TgoodsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTgoods", new { id = tgoods.TgoodsId }, tgoods);
        }

        // DELETE: api/Tgoods/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tgoods>> DeleteTgoods(long id)
        {
            var tgoods = await _context.Tgoods.FindAsync(id);
            if (tgoods == null)
            {
                return NotFound();
            }

            _context.Tgoods.Remove(tgoods);
            await _context.SaveChangesAsync();

            return tgoods;
        }

        private bool TgoodsExists(long id)
        {
            return _context.Tgoods.Any(e => e.TgoodsId == id);
        }
    }
}
