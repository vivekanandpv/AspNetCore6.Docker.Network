using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
using WebApplication4.Services;

namespace WebApplication4.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class PersonsController:ControllerBase
{
    private readonly IPersonService _service;

    public PersonsController(IPersonService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Person>>> GetAsync()
    {
        return Ok(await _service.GetAllAsync());
    }
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Person>> GetAsync(int id)
    {
        return Ok(await _service.GetByIdAsync(id));
    }

    [HttpPost]
    public async Task<ActionResult<Person>> CreateAsync(Person person)
    {
        return Ok(await _service.CreateAsync(person));
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<Person>> UpdateAsync(int id, Person person)
    {
        return Ok(await _service.UpdateAsync(id, person));
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        await _service.DeleteAsync(id);
        return NoContent();
    }
}