using Models;
using System.Text.Json;
using DataAccess;

namespace Services;

public class AuthService
{
    public User Register(User newUser)
    {
        try
        {
            return new userRepository().AddUser(newUser);
        }
        catch(JsonException)
        {
            throw;
        }
    }

}