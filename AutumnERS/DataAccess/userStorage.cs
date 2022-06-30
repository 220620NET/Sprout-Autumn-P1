// using Services;

using Models;
// using customExceptions;

namespace DataAccess;

// Creates array to hold up to 10 sample, existing Users

public static class UserStorage
{
    public static User[] userList {get; set;} = new User[10];

    public static int userListSize {get; set;} = 0;
}