using Business.Dtos;
using Business.Helpers;
using Business.Models;

namespace Business.Factories;
public class UserFactory
{
    public static UserRegistrationForm Create() => new();

    public static Users Create(UserRegistrationForm form) => new()
    {
        Id = GuidGenerator.Generate(),
        Name = form.Name,
        Email = form.Email,
    };
}
