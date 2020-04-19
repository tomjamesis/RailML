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
    public class TinterlockingTypesController : ControllerBase
    {
        private readonly DBContext _context;

        public TinterlockingTypesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TinterlockingTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TinterlockingTypes>>> GetTinterlockingTypes()
        {
            return await _context.TinterlockingTypes.ToListAsync();
        }

        // GET: api/TinterlockingTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TinterlockingTypes>> GetTinterlockingTypes(byte id)
        {
            var tinterlockingTypes = await _context.TinterlockingTypes.FindAsync(id);

            if (tinterlockingTypes == null)
            {
                return NotFound();
            }

            return tinterlockingTypes;
        }

        // PUT: api/TinterlockingTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTinterlockingTypes(byte id, TinterlockingTypes tinterlockingTypes)
        {
            if (id != tinterlockingTypes.TinterlockingTypesId)
            {
                return BadRequest();
            }

            _context.Entry(tinterlockingTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TinterlockingTypesExists(id))
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

        // POST: api/TinterlockingTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TinterlockingTypes>> PostTinterlockingTypes(TinterlockingTypes tinterlockingTypes)
        {
            _context.TinterlockingTypes.Add(tinterlockingTypes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TinterlockingTypesExists(tinterlockingTypes.TinterlockingTypesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTinterlockingTypes", new { id = tinterlockingTypes.TinterlockingTypesId }, tinterlockingTypes);
        }

        // DELETE: api/TinterlockingTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TinterlockingTypes>> DeleteTinterlockingTypes(byte id)
        {
            var tinterlockingTypes = await _context.TinterlockingTypes.FindAsync(id);
            if (tinterlockingTypes == null)
            {
                return NotFound();
            }

            _context.TinterlockingTypes.Remove(tinterlockingTypes);
            await _context.SaveChangesAsync();

            return tinterlockingTypes;
        }

        private bool TinterlockingTypesExists(byte id)
        {
            return _context.TinterlockingTypes.Any(e => e.TinterlockingTypesId == id);
        }
    }
}
