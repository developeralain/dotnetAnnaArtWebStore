using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaintingsController : ControllerBase
    {
        private readonly StoreContext _context; // _ prefix common for private read-only fields
        public PaintingsController(StoreContext context)
        {
            _context = context;
            
        }

        [HttpGet]
        public async Task<ActionResult<List<Painting>>> GetPaintings()
        {
            var paintings = await _context.Paintings.ToListAsync();
            return Ok(paintings);
            // you can do the below single line of code instead of the above 2 lines instead and get the same result
            // return await context.Paintings.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Painting>> GetPainting(int id)
        {
            return await _context.Paintings.FindAsync(id);
        }
    }
}