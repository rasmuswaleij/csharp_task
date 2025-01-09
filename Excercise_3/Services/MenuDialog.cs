using System.Reflection.Metadata;
using Business.Dtos;
using Business.Models;
using Business.Services;



namespace Excercise_3.Services;
public class MenuDialog
{

    UserService userService = new UserService();


    public void Run()
    {
        do
        {
            Console.WriteLine("1. Add a user");
            Console.WriteLine("2. View all users");
            Console.WriteLine("Q. Quit");
            var option = Console.ReadLine();

            switch (option!.ToLower())
            {
                case "1":
                    AddUser();
                    break;
                case "2":
                    ViewUsers();
                    break;
                case "q":
                    Environment.Exit(0);
                    break;
            }

        } while (true);
    }

    public void AddUser()
    {
        var _user = new UserRegistrationForm();

        Console.WriteLine("Add name:");
        _user.Name = Console.ReadLine();

        Console.WriteLine("Add email:");
        _user.Email = Console.ReadLine();

        userService.AddUser(_user);

    }

    public void ViewUsers()
    {
        var list = userService.ViewUsers();
        foreach(Users user in list)
        {
            Console.WriteLine(user.Name);
            Console.WriteLine(user.Email);
            Console.WriteLine(user.Id);


        }

    }
}
