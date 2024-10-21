using Sample.API.Model;
using Sample.API.Repository;

namespace Sample.API.Service;

public class PetService : IPetService
{
    private readonly IPetRepository _petRepository;

    public PetService(IPetRepository petRepository) => _petRepository = petRepository;

    public IEnumerable<Pet> GetAllPets()
    {
        return _petRepository.GetAllPets();
    }
}