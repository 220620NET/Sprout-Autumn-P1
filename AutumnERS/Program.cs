using Models;
using UI;
// using Services;
// using DataStorage;
// using DataAccess;

User Barbara = new User (01, "bgordon", "oracle", "Barbara", "Gordon", "Employee");

Console.WriteLine("userID: " + Barbara.userID);
Console.WriteLine("userName: " + Barbara.userName);
Console.WriteLine(Barbara.firstName + " " + Barbara.lastName + "'s secret is " + Barbara.password + ".");
Console.WriteLine(Barbara.firstName + " is a mere " + Barbara.userRole + ".");

Console.WriteLine("Now that that's out of the way ... what do YOU want?");

MainMenu main = new MainMenu();
main.Begin();