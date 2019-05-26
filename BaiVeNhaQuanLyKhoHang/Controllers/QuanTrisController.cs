using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BaiVeNhaQuanLyKhoHang.Models;

namespace BaiVeNhaQuanLyKhoHang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuanTrisController : ControllerBase
    {
        private readonly DataContext _context;

        public QuanTrisController(DataContext context)
        {
            _context = context;
        }

        // GET: api/QuanTris
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuanTri>>> GetQuanTris()
        {
            return await _context.QuanTris.ToListAsync();
        }

        // GET: api/QuanTris/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QuanTri>> GetQuanTri(int id)
        {
            var quanTri = await _context.QuanTris.FindAsync(id);

            if (quanTri == null)
            {
                return NotFound();
            }

            return quanTri;
        }

        // PUT: api/QuanTris/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuanTri(int id, QuanTri quanTri)
        {
            if (id != quanTri.Id)
            {
                return BadRequest();
            }

            _context.Entry(quanTri).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuanTriExists(id))
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

        // POST: api/QuanTris
        [HttpPost]
        public async Task<ActionResult<QuanTri>> PostQuanTri(QuanTri quanTri)
        {
            _context.QuanTris.Add(quanTri);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuanTri", new { id = quanTri.Id }, quanTri);
        }

        // DELETE: api/QuanTris/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<QuanTri>> DeleteQuanTri(int id)
        {
            var quanTri = await _context.QuanTris.FindAsync(id);
            if (quanTri == null)
            {
                return NotFound();
            }

            _context.QuanTris.Remove(quanTri);
            await _context.SaveChangesAsync();

            return quanTri;
        }

        private bool QuanTriExists(int id)
        {
            return _context.QuanTris.Any(e => e.Id == id);
        }
    }
}
