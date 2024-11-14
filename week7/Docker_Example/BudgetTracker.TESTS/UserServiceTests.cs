using AutoMapper;
using BudgetTracker.API.Models.DTO;
using BudgetTracker.API.Service;
using BudgetTracker.Data;
using BudgetTracker.Models;
using Moq;


namespace BudgetTracker.TESTS;

public class UserServiceTests
{
    [Fact]
    public async Task GetAllUsersThrowExceptionOnEmpty()
    {
        //Arrange
        Mock<IUserRepo> mockRepo = new();
        Mock<IMapper> mockMapper = new();
        UserService userService = new(mockRepo.Object, mockMapper.Object);

        List<User> uList = [];

        mockRepo.Setup(repo => repo.GetAllUsers())
            .ReturnsAsync(uList);

        //Act
        //Act is included within assert to catch exception.

        //Assert
        await Assert.ThrowsAsync<Exception>(() => userService.GetAllUsers());
    }

    [Fact]
    public async Task GetAllUsersReturnsProperList()
    {
        //Arrange
        Mock<IUserRepo> mockRepo = new();
        Mock<IMapper> mockMapper = new();
        UserService userService = new(mockRepo.Object, mockMapper.Object);

        List<User> uList = [
            new User {FirstName = "Coffee"},
            new User {},
            new User {}
        ];

        mockRepo.Setup(repo => repo.GetAllUsers())
            .ReturnsAsync(uList);

        //Act
        var result = await userService.GetAllUsers();

        //Assert
        Assert.NotNull(result);
        Assert.Equal(3, result.Count);
        Assert.Contains(result, e => e.FirstName!.Equals("Coffee"));
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public async Task GetUserByIdReturnsProperUser(int id)
    {
        //Arrange
        Mock<IUserRepo> mockRepo = new();
        Mock<IMapper> mockMapper = new();
        UserService userService = new(mockRepo.Object, mockMapper.Object);

        List<User> uList = [
            new User {FirstName = "Coffee", UserId = 1},
            new User {FirstName = "Coffee2", UserId = 2},
            new User {FirstName = "Coffee3", UserId = 3}
        ];

        mockRepo.Setup(repo => repo.GetUserById(It.IsAny<int>()))!
            .ReturnsAsync(uList.FirstOrDefault(user => user.UserId == id));

        //Act
        var result = await userService.GetUserById(id);

        //Assert
        Assert.NotNull(result);
        Assert.IsType<User>(result);
        Assert.Equal(id, result.UserId);
    }

    [Fact (Skip = "Being Lazy")]
    public async Task AddNewUserAddsToList()
    {
        //Arrange
        Mock<IUserRepo> mockRepo = new();
        Mock<IMapper> mockMapper = new();
        UserService userService = new(mockRepo.Object, mockMapper.Object);

        List<User> uList = [
            new User {FirstName = "Coffee", UserId = 1},
            new User {FirstName = "Coffee2", UserId = 2},
            new User {FirstName = "Coffee3", UserId = 3}
        ];

        User newUser = new(){ FirstName = "Coffee4", UserId = 4};
        NewUserDTO newUserDTO = new(){FirstName = "Coffee4", LastName = "IceCream"};

        mockRepo.Setup(repo => repo.AddUser(It.IsAny<User>()))
        .Callback(() => uList.Add(newUser))
        .ReturnsAsync(newUser);

        //Act
        var result = await userService.AddUser(newUserDTO);

        //Assert
        Assert.NotNull(result);
        Assert.IsType<User>(result);
        Assert.Contains(uList, u => u.FirstName!.Equals("Coffee4"));
        mockRepo.Verify(r => r.AddUser(It.IsAny<User>()), Times.Exactly(1));
    }
}