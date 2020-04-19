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
    public class RelationController : ControllerBase
    {
        private readonly DBContext _context;

        public RelationController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Relation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Relation>>> GetRelation()
        {
            return await _context.Relation.ToListAsync();
        }

        // GET: api/Relation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Relation>> GetRelation(short id)
        {
            var relation = await _context.Relation.FindAsync(id);

            if (relation == null)
            {
                return NotFound();
            }

            return relation;
        }

        // PUT: api/Relation/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRelation(short id, Relation relation)
        {
            if (id != relation.RelationId)
            {
                return BadRequest();
            }

            _context.Entry(relation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RelationExists(id))
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

        // POST: api/Relation
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Relation>> PostRelation(Relation relation)
        {
            _context.Relation.Add(relation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RelationExists(relation.RelationId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRelation", new { id = relation.RelationId }, relation);
        }

        // DELETE: api/Relation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Relation>> DeleteRelation(short id)
        {
            var relation = await _context.Relation.FindAsync(id);
            if (relation == null)
            {
                return NotFound();
            }

            _context.Relation.Remove(relation);
            await _context.SaveChangesAsync();

            return relation;
        }

        private bool RelationExists(short id)
        {
            return _context.Relation.Any(e => e.RelationId == id);
        }
    }
}
