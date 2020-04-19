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
    public class TblockPartRefController : ControllerBase
    {
        private readonly DBContext _context;

        public TblockPartRefController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TblockPartRef
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblockPartRef>>> GetTblockPartRef()
        {
            return await _context.TblockPartRef.ToListAsync();
        }

        // GET: api/TblockPartRef/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblockPartRef>> GetTblockPartRef(short id)
        {
            var tblockPartRef = await _context.TblockPartRef.FindAsync(id);

            if (tblockPartRef == null)
            {
                return NotFound();
            }

            return tblockPartRef;
        }

        // PUT: api/TblockPartRef/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblockPartRef(short id, TblockPartRef tblockPartRef)
        {
            if (id != tblockPartRef.TblockPartRefId)
            {
                return BadRequest();
            }

            _context.Entry(tblockPartRef).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblockPartRefExists(id))
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

        // POST: api/TblockPartRef
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblockPartRef>> PostTblockPartRef(TblockPartRef tblockPartRef)
        {
            _context.TblockPartRef.Add(tblockPartRef);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TblockPartRefExists(tblockPartRef.TblockPartRefId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTblockPartRef", new { id = tblockPartRef.TblockPartRefId }, tblockPartRef);
        }

        // DELETE: api/TblockPartRef/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblockPartRef>> DeleteTblockPartRef(short id)
        {
            var tblockPartRef = await _context.TblockPartRef.FindAsync(id);
            if (tblockPartRef == null)
            {
                return NotFound();
            }

            _context.TblockPartRef.Remove(tblockPartRef);
            await _context.SaveChangesAsync();

            return tblockPartRef;
        }

        private bool TblockPartRefExists(short id)
        {
            return _context.TblockPartRef.Any(e => e.TblockPartRefId == id);
        }
    }
}
