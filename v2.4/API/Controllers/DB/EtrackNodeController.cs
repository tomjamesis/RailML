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
    public class EtrackNodeController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrackNodeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrackNode
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrackNode>>> GetEtrackNode()
        {
            return await _context.EtrackNode.ToListAsync();
        }

        // GET: api/EtrackNode/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrackNode>> GetEtrackNode(short id)
        {
            var etrackNode = await _context.EtrackNode.FindAsync(id);

            if (etrackNode == null)
            {
                return NotFound();
            }

            return etrackNode;
        }

        // PUT: api/EtrackNode/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrackNode(short id, EtrackNode etrackNode)
        {
            if (id != etrackNode.EtrackNodeId)
            {
                return BadRequest();
            }

            _context.Entry(etrackNode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrackNodeExists(id))
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

        // POST: api/EtrackNode
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrackNode>> PostEtrackNode(EtrackNode etrackNode)
        {
            _context.EtrackNode.Add(etrackNode);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrackNodeExists(etrackNode.EtrackNodeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrackNode", new { id = etrackNode.EtrackNodeId }, etrackNode);
        }

        // DELETE: api/EtrackNode/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrackNode>> DeleteEtrackNode(short id)
        {
            var etrackNode = await _context.EtrackNode.FindAsync(id);
            if (etrackNode == null)
            {
                return NotFound();
            }

            _context.EtrackNode.Remove(etrackNode);
            await _context.SaveChangesAsync();

            return etrackNode;
        }

        private bool EtrackNodeExists(short id)
        {
            return _context.EtrackNode.Any(e => e.EtrackNodeId == id);
        }
    }
}
