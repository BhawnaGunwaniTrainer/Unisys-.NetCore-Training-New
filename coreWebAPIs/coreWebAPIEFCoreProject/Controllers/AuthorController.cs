using coreWebAPIEFCoreProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace coreWebAPIEFCoreProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private HRDbContext _context;
        public AuthorController(HRDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthors()
        {
            return await _context.Authors.ToListAsync();
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Author>>> GetAllAuthors()
        {
            return await _context.Authors.ToListAsync();
        }

        [HttpGet("searchById/{id:int}")]
        public async Task<ActionResult<Author>> GetAuthorById(int id)
        {
            var author = await _context.Authors.FindAsync(id);
            if (author == null)
                return NotFound();
            return author;
        }
        [HttpGet("searchByName/{pub:alpha}")]
        public async Task<ActionResult<Author>> GetAuthorByPublication(string pub)
        {
            var author = await _context.Authors.Where(p => p.Publication == pub).FirstOrDefaultAsync();
            if (author == null)
                return NotFound();
            return author;
        }

    }
}
