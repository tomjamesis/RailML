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
    public class EgoodsController : ControllerBase
    {
        private readonly DBContext _context;

        public EgoodsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Egoods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Egoods>>> GetEgoods()
        {
            return await _context.Egoods.ToListAsync();
        }

        // GET: api/Egoods/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Egoods>> GetEgoods(short id)
        {
            var egoods = await _context.Egoods.FindAsync(id);

            if (egoods == null)
            {
                return NotFound();
            }

            return egoods;
        }

        // PUT: api/Egoods/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEgoods(short id, Egoods egoods)
        {
            if (id != egoods.EgoodsId)
            {
                return BadRequest();
            }

            _context.Entry(egoods).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EgoodsExists(id))
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

        // POST: api/Egoods
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Egoods>> PostEgoods(Egoods egoods)
        {
            _context.Egoods.Add(egoods);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EgoodsExists(egoods.EgoodsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEgoods", new { id = egoods.EgoodsId }, egoods);
        }

        // DELETE: api/Egoods/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Egoods>> DeleteEgoods(short id)
        {
            var egoods = await _context.Egoods.FindAsync(id);
            if (egoods == null)
            {
                return NotFound();
            }

            _context.Egoods.Remove(egoods);
            await _context.SaveChangesAsync();

            return egoods;
        }

        private bool EgoodsExists(short id)
        {
            return _context.Egoods.Any(e => e.EgoodsId == id);
        }
    }
}
