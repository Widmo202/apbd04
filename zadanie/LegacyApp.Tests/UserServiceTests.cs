namespace LegacyApp.Tests;

public class UserServiceTests
{
    [Fact]
    public void AddUser_ReturnsFalseWhenFirstNameIsEmpty()
    {
        //Arrange
        var userService = new UserService();
        //Act

        var result = userService.AddUser(
            null,
            "Smith",
            "smith@email.com",
            DateTime.Parse("2002-01-01"),
            1
        );

        //Assert
        Assert.False(result);
    }
    
    [Fact]
    public void AddUser_ThrowsExceptionWhenClientDoesNotExist()
    {
        //Arrange
        var userService = new UserService();
        //Act

        Action action = () => userService.AddUser(
            "Joe",
            "Smith",
            "smith@email.com",
            DateTime.Parse("2002-01-01"),
            100
        );

        //Assert
        Assert.Throws<ArgumentException>(action);
    }
}