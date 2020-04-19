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
    public class EoperationControlPointsController : ControllerBase
    {
        private readonly DBContext _context;

        public EoperationControlPointsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EoperationControlPoints
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EoperationControlPoints>>> GetEoperationControlPoints()
        {
            return await _context.EoperationControlPoints.ToListAsync();
        }

        // GET: api/EoperationControlPoints/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EoperationControlPoints>> GetEoperationControlPoints(long id)
        {
            var eoperationControlPoints = await _context.EoperationControlPoints.FindAsync(id);

            if (eoperationControlPoints == null)
            {
                return NotFound();
            }

            return eoperationControlPoints;
        }

        // PUT: api/EoperationControlPoints/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEoperationControlPoints(long id, EoperationControlPoints eoperationControlPoints)
        {
            if (id != eoperationControlPoints.EoperationControlPointsId)
            {
                return BadRequest();
            }

            _context.Entry(eoperationControlPoints).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EoperationControlPointsExists(id))
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

        // POST: api/EoperationControlPoints
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EoperationControlPoints>> PostEoperationControlPoints(EoperationControlPoints eoperationControlPoints)
        {
            _context.EoperationControlPoints.Add(eoperationControlPoints);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EoperationControlPointsExists(eoperationControlPoints.EoperationControlPointsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEoperationControlPoints", new { id = eoperationControlPoints.EoperationControlPointsId }, eoperationControlPoints);
        }

        // DELETE: api/EoperationControlPoints/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EoperationControlPoints>> DeleteEoperationControlPoints(long id)
        {
            var eoperationControlPoints = await _context.EoperationControlPoints.FindAsync(id);
            if (eoperationControlPoints == null)
            {
                return NotFound();
            }

            _context.EoperationControlPoints.Remove(eoperationControlPoints);
            await _context.SaveChangesAsync();

            return eoperationControlPoints;
        }

        private bool EoperationControlPointsExists(long id)
        {
            return _context.EoperationControlPoints.Any(e => e.EoperationControlPointsId == id);
        }
    }
}
