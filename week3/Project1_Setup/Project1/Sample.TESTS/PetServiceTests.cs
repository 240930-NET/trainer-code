using Moq;
using Sample.API.Model;
using Sample.API.Repository;
using Sample.API.Service;

namespace Sample.TESTS;

public class PetServiceTests
{
    [Fact]
    public void GetAllPetsReturnList()
    {
        //Arrange
        Mock<IPetRepository> mockRepo = new();
        PetService petService = new(mockRepo.Object);

        List<Pet> petList = [
            new Pet{Id = 1, Name = "Nyla2", Type = "Cat"},
            new Pet{Id = 2, Name = "Rover", Type = "Dog"},
            new Pet{Id = 3, Name = "Chirp", Type = "Bird"}
        ];

        mockRepo.Setup(repo => repo.GetAllPets()).Returns(petList);

        //Act
        var returnedList = petService.GetAllPets();

        //Assert
        Assert.NotEmpty(returnedList);
        Assert.Equal(3, returnedList.Count());
        Assert.Contains(returnedList, pet => pet.Name.Equals("Nyla"));
    }
}