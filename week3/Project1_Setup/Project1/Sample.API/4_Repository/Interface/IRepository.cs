using Sample.API.Model;

namespace Sample.API.Repository;

public interface IPetRepository
{
    IEnumerable<Pet> GetAllPets();
}

public interface IOwnerRepository
{
    
}