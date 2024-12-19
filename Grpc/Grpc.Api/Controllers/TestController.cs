using Grpc.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Grpc.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    private readonly ILogger<TestController> _logger;

    private static User _user = new()
    {
        Id = 1,
        Name = "John Doe",
        Email = "john.doe@gmail.com",
        UserName = "john.doe@gmail.com"
    };

    public TestController(ILogger<TestController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_user);
    }
}