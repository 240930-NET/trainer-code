using Sample.API.Model;

namespace Sample.API.Service;

public interface IPetService
{
    IEnumerable<Pet> GetAllPets();
}