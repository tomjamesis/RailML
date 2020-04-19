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
    public class TmacroscopicNodeController : ControllerBase
    {
        private readonly DBContext _context;

        public TmacroscopicNodeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TmacroscopicNode
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TmacroscopicNode>>> GetTmacroscopicNode()
        {
            return await _context.TmacroscopicNode.ToListAsync();
        }

        // GET: api/TmacroscopicNode/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TmacroscopicNode>> GetTmacroscopicNode(long id)
        {
            var tmacroscopicNode = await _context.TmacroscopicNode.FindAsync(id);

            if (tmacroscopicNode == null)
            {
                return NotFound();
            }

            return tmacroscopicNode;
        }

        // PUT: api/TmacroscopicNode/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTmacroscopicNode(long id, TmacroscopicNode tmacroscopicNode)
        {
            if (id != tmacroscopicNode.TmacroscopicNodeId)
            {
                return BadRequest();
            }

            _context.Entry(tmacroscopicNode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TmacroscopicNodeExists(id))
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

        // POST: api/TmacroscopicNode
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TmacroscopicNode>> PostTmacroscopicNode(TmacroscopicNode tmacroscopicNode)
        {
            _context.TmacroscopicNode.Add(tmacroscopicNode);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TmacroscopicNodeExists(tmacroscopicNode.TmacroscopicNodeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTmacroscopicNode", new { id = tmacroscopicNode.TmacroscopicNodeId }, tmacroscopicNode);
        }

        // DELETE: api/TmacroscopicNode/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TmacroscopicNode>> DeleteTmacroscopicNode(long id)
        {
            var tmacroscopicNode = await _context.TmacroscopicNode.FindAsync(id);
            if (tmacroscopicNode == null)
            {
                return NotFound();
            }

            _context.TmacroscopicNode.Remove(tmacroscopicNode);
            await _context.SaveChangesAsync();

            return tmacroscopicNode;
        }

        private bool TmacroscopicNodeExists(long id)
        {
            return _context.TmacroscopicNode.Any(e => e.TmacroscopicNodeId == id);
        }
    }
}
