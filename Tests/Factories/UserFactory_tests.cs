using Business.Dtos;
using Business.Factories;
using Business.Models;

namespace Tests.Factories;
public class UserFactory_tests
{
    [Fact]
    public void Create_ShouldReturnUserRegistrationForm()
    {
        var result = UserFactory.Create();

        Assert.NotNull(result);
        Assert.IsType<UserRegistrationForm>(result);   
    }

    [Fact]
    public void Create_ShouldReturnUsers_WhenUserRegistrationFormIsInserted()
    {
        var userRegistrationform = new UserRegistrationForm()
        {
            FirstName = "Rasmus",
            Email = "rasmus@domain.com"
        };

        var result = UserFactory.Create(userRegistrationform);

        Assert.NotNull(result);
        Assert.IsType<Users>(result);
        Assert.Equal(result.FirstName, userRegistrationform.FirstName);
        Assert.Equal(result.Email, userRegistrationform.Email);
    }
}
