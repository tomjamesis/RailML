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
    public class EloadLimitMatrixController : ControllerBase
    {
        private readonly DBContext _context;

        public EloadLimitMatrixController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EloadLimitMatrix
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EloadLimitMatrix>>> GetEloadLimitMatrix()
        {
            return await _context.EloadLimitMatrix.ToListAsync();
        }

        // GET: api/EloadLimitMatrix/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EloadLimitMatrix>> GetEloadLimitMatrix(short id)
        {
            var eloadLimitMatrix = await _context.EloadLimitMatrix.FindAsync(id);

            if (eloadLimitMatrix == null)
            {
                return NotFound();
            }

            return eloadLimitMatrix;
        }

        // PUT: api/EloadLimitMatrix/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEloadLimitMatrix(short id, EloadLimitMatrix eloadLimitMatrix)
        {
            if (id != eloadLimitMatrix.EloadLimitMatrixId)
            {
                return BadRequest();
            }

            _context.Entry(eloadLimitMatrix).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EloadLimitMatrixExists(id))
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

        // POST: api/EloadLimitMatrix
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EloadLimitMatrix>> PostEloadLimitMatrix(EloadLimitMatrix eloadLimitMatrix)
        {
            _context.EloadLimitMatrix.Add(eloadLimitMatrix);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EloadLimitMatrixExists(eloadLimitMatrix.EloadLimitMatrixId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEloadLimitMatrix", new { id = eloadLimitMatrix.EloadLimitMatrixId }, eloadLimitMatrix);
        }

        // DELETE: api/EloadLimitMatrix/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EloadLimitMatrix>> DeleteEloadLimitMatrix(short id)
        {
            var eloadLimitMatrix = await _context.EloadLimitMatrix.FindAsync(id);
            if (eloadLimitMatrix == null)
            {
                return NotFound();
            }

            _context.EloadLimitMatrix.Remove(eloadLimitMatrix);
            await _context.SaveChangesAsync();

            return eloadLimitMatrix;
        }

        private bool EloadLimitMatrixExists(short id)
        {
            return _context.EloadLimitMatrix.Any(e => e.EloadLimitMatrixId == id);
        }
    }
}
