namespace LegacyApp.Tests;

public class UserServiceTests
{
    [Fact]
    public void AddUser_ReturnsFalseWhenFirstNameIsEmpty()
    {
        
        // Arrange
        var userService = new UserService();

        // Act
        var result = userService.AddUser(
            null, 
            "Kowalski", 
            "kowalski@kowalski.pl",
            DateTime.Parse("2000-01-01"),
            1
            );

        // Assert
        // Assert.Equal(false, result);
        Assert.False(result);
    }
    

    [Fact]
    public void AddUser_ThrowsArgumentExceptionWhenClientDoesNotExist()
    {
        
        // Arrange
        var userService = new UserService();

        // Act
        Action action = () => userService.AddUser(
            "Jan", 
            "Kowalski", 
            "kowalski@kowalski.pl",
            DateTime.Parse("2000-01-01"),
            100
        );

        // Assert
        Assert.Throws<ArgumentException>(action);
    }   
    // AddUser_ReturnsFalseWhenMissingAtSignAndDotInEmail
    
    [Fact]
    public void AddUser_ReturnsFalseWhenMissingAtSignAndDotInEmail()
    {
        // Arrange
        var userService = new UserService();

        // Act
        var result = userService.AddUser(
            "Jan", 
            "Kowalski", 
            "kowalskipl",
            DateTime.Parse("2000-01-01"),
            1
        );

        // Assert
        Assert.False(result);
    }
    
     // AddUser_ReturnsFalseWhenYoungerThen21YearsOld
     
     [Fact]
     public void AddUser_ReturnsFalseWhenYoungerThen21YearsOld()
     {
         // Arrange
         var userService = new UserService();

         // Act
         var result = userService.AddUser(
             "Jan", 
             "Kowalski", 
             "kowalski@kowalski.pl",
             DateTime.Parse("2020-01-01"),
             1
         );

         // Assert
         Assert.False(result);
     }
     
     // AddUser_ReturnsTrueWhenVeryImportantClient
     [Fact]
     public void AddUser_ReturnsTrueWhenVeryImportantClient()
     {
         // Arrange
         var userService = new UserService();
         
         //            {2, new Client{ClientId = 2, Name = "Malewski", Address = "Warszawa, Koszykowa 86", Email = "malewski@gmail.pl", Type = "VeryImportantClient"}},

         // Act
         var result = userService.AddUser(
             "Jan", 
             "Malewski", 
             "malewski@gmail.pl",
             DateTime.Parse("2000-01-01"),
             2
         );

         // Assert
         Assert.True(result);
     }
     
     // AddUser_ReturnsTrueWhenImportantClient
     [Fact]
     public void AddUser_ReturnsTrueWhenImportantClient()
     {
         // Arrange
         var userService = new UserService();
         
         //                        {3, new Client{ClientId = 3, Name = "Smith", Address = "Warszawa, Kolorowa 22", Email = "smith@gmail.pl", Type = "ImportantClient"}},


         // Act
         var result = userService.AddUser(
             "Jan", 
             "Smith", 
             "smith@gmail.pl",
             DateTime.Parse("2000-01-01"),
             3
         );

         // Assert
         Assert.True(result);
     }
     
     // AddUser_ReturnsTrueWhenNormalClient
     
     [Fact]
     public void AddUser_ReturnsTrueWhenNormalClient()
     {
         // Arrange
         var userService = new UserService();
         
         //                        {5, new Client{ClientId = 5, Name = "Kwiatkowski", Address = "Warszawa, Złota 52", Email = "kwiatkowski@wp.pl", Type = "NormalClient"}},

         // Act
         var result = userService.AddUser(
             "Jan", 
             "Kwiatkowski", 
             "kwiatkowski@wp.pl",
             DateTime.Parse("2000-01-01"),
             5
         );

         // Assert
         Assert.True(result);
     }
     
     // AddUser_ReturnsFalseWhenNormalClientWithNoCreditLimit
     
     [Fact]
     public void AddUser_ReturnsFalseWhenNormalClientWithNoCreditLimit()
     {
         // Arrange
         var userService = new UserService();
         

         // Act
         var result = userService.AddUser(
             "Jan", 
             "Kowalski", 
             "kowalski@kowalski.pl",
             DateTime.Parse("2000-01-01"),
             1
             
         );

         // Assert
         Assert.False(result);
     }
     
     // AddUser_ThrowsExceptionWhenUserDoesNotExist
     
     [Fact]
     public void AddUser_ThrowsExceptionWhenUserDoesNotExist()
     {
        
         // Arrange
         var userService = new UserService();

         // Act
         Action action = () => userService.AddUser(
             "asdasddsaads", 
             "dasdsaasdasd", 
             "dasdsadas@kowalski.pl",
             DateTime.Parse("2000-01-01"),
             1
         );

         // Assert
         Assert.Throws<ArgumentException>(action);
     }   
     
     // AddUser_ThrowsExceptionWhenUserNoCreditLimitExistsForUser
     
     [Fact]
     public void AddUser_ThrowsExceptionWhenUserNoCreditLimitExistsForUser()
     {
        
         // Arrange
         var userService = new UserService();

         // Act
         // {6, new Client{ClientId = 6, Name = "Andrzejewicz", Address = "Warszawa, Koszykowa 52", Email = "andrzejewicz@wp.pl", Type = "NormalClient"}}
         Action action = () => userService.AddUser(
             "asdasddsaads", 
             "Andrzejewicz", 
             "andrzejewicz@wp.pl",
             DateTime.Parse("2000-01-01"),
             6
         );

         // Assert
         Assert.Throws<ArgumentException>(action);
     }  
         
}