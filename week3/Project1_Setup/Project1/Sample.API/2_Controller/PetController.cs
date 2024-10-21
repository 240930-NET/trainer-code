using Microsoft.AspNetCore.Mvc;
using Sample.API.Service;

namespace Sample.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    private readonly IPetService _petService;

    public PetController(IPetService petService) => _petService = petService;

    [HttpGet("/pet")]
    public IActionResult GetAllPets()
    {
        var pets = _petService.GetAllPets();
        return Ok(pets);
    }

    [HttpGet("/pet/{id}")]
    public IActionResult GetPetById(int id)
    {
        throw new NotImplementedException();
    }
}