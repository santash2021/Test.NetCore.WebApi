using Microsoft.AspNetCore.Mvc;

namespace WebApi.Test.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : Controller
{
    [HttpGet("text")]
    public async Task<IActionResult> Index()
    {
        var text = "hello world?";
        return Ok(text);
    }
}