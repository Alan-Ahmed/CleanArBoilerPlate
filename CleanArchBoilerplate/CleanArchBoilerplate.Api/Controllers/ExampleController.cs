using CleanArchBoilerplate.Application.Example.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchBoilerplate.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExampleController : ControllerBase
{
    private readonly IExampleService _service;

    public ExampleController(IExampleService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
        => Ok(await _service.GetAllAsync());

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] string name)
        => Ok(await _service.CreateAsync(name));
}
