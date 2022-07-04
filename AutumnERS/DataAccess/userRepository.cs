using Models;
using System.Text.Json;

namespace DataAccess;

public class UserRepository
{
    private const string filePath = "userRegistry.json";

    // The Add method takes paramateres, one for key and one for value
    public User AddUser(User newUser){
        string fileString = File.ReadAllText(filePath);
        

        try
        {
            Dictionary<string, User> userRegistry = JsonSerializer.Deserialize<Dictionary<string, User>>(fileString);
            userRegistry.Add(newUser.lastName, newUser);
            File.WriteAllText(filePath, JsonSerializer.Serialize(userRegistry));
            return newUser;
        }
        catch(JsonException)
        {
            throw;
        }
    }

    



}