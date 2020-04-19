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
    public class TmaxTrainCurrentTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TmaxTrainCurrentTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TmaxTrainCurrentType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TmaxTrainCurrentType>>> GetTmaxTrainCurrentType()
        {
            return await _context.TmaxTrainCurrentType.ToListAsync();
        }

        // GET: api/TmaxTrainCurrentType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TmaxTrainCurrentType>> GetTmaxTrainCurrentType(byte id)
        {
            var tmaxTrainCurrentType = await _context.TmaxTrainCurrentType.FindAsync(id);

            if (tmaxTrainCurrentType == null)
            {
                return NotFound();
            }

            return tmaxTrainCurrentType;
        }

        // PUT: api/TmaxTrainCurrentType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTmaxTrainCurrentType(byte id, TmaxTrainCurrentType tmaxTrainCurrentType)
        {
            if (id != tmaxTrainCurrentType.TmaxTrainCurrentTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tmaxTrainCurrentType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TmaxTrainCurrentTypeExists(id))
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

        // POST: api/TmaxTrainCurrentType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TmaxTrainCurrentType>> PostTmaxTrainCurrentType(TmaxTrainCurrentType tmaxTrainCurrentType)
        {
            _context.TmaxTrainCurrentType.Add(tmaxTrainCurrentType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TmaxTrainCurrentTypeExists(tmaxTrainCurrentType.TmaxTrainCurrentTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTmaxTrainCurrentType", new { id = tmaxTrainCurrentType.TmaxTrainCurrentTypeId }, tmaxTrainCurrentType);
        }

        // DELETE: api/TmaxTrainCurrentType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TmaxTrainCurrentType>> DeleteTmaxTrainCurrentType(byte id)
        {
            var tmaxTrainCurrentType = await _context.TmaxTrainCurrentType.FindAsync(id);
            if (tmaxTrainCurrentType == null)
            {
                return NotFound();
            }

            _context.TmaxTrainCurrentType.Remove(tmaxTrainCurrentType);
            await _context.SaveChangesAsync();

            return tmaxTrainCurrentType;
        }

        private bool TmaxTrainCurrentTypeExists(byte id)
        {
            return _context.TmaxTrainCurrentType.Any(e => e.TmaxTrainCurrentTypeId == id);
        }
    }
}
