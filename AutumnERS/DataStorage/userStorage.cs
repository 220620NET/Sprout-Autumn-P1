namespace DataAccess;

using Models;
using DataStorage;
using DataAccess;
using customExceptions;


// Sample, Existing Users

User Barbara = new User (01, "bgordon", "oracle", "Barbara", "Gordon", "Employee");

Console.WriteLine("userID: " + Barbara.userID);
Console.WriteLine("userName: " + Barbara.userName);
Console.WriteLine(Barbara.firstName + " " + Barbara.lastName + "'s secret is " + Barbara.password + ".");
Console.WriteLine(Barbara.firstName + " is a mere " + Barbara.userRole + ".");


// Array for Users