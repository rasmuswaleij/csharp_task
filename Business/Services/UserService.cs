using Business.Dtos;
using Business.Factories;
using Business.Models;

namespace Business.Services;
public class UserService
{
    private  List<Users> _users = [];
    private readonly FileService _fileService = new();

    public void AddUser(UserRegistrationForm form)
    {
        var user = UserFactory.Create(form);
        _users.Add(user);
        _fileService.SaveListToFile(_users);
    }

    public IEnumerable<Users> ViewUsers()
    {
        _users = _fileService.LoadListFromFile();
        return _users;
    }
}
