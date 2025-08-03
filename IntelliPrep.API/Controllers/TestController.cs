using IntelliPrep.API.Data;
using IntelliPrep.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace IntelliPrep.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    private readonly IntelliPrepDbContext _context;

    public TestController(IntelliPrepDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var tests = await _context.Tests.Include(t => t.Questions).ToListAsync();
        return Ok(tests);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Test test)
    {
        _context.Tests.Add(test);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetAll), new { id = test.Id }, test);
    }
}