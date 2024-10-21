using Sample.API.Data;
using Sample.API.Model;

namespace Sample.API.Repository;

public class PetRepository : IPetRepository
{
    private readonly SampleContext _petContext;

    public PetRepository(SampleContext petContext) => _petContext = petContext;

    public IEnumerable<Pet> GetAllPets()
    {
        return _petContext.Pets.ToList();
    }
}