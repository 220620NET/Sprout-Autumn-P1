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

// public class User
// {
//     public User(
//         int userID,             // userID will be created by index in array of users
//         string userName, 
//         string password, 
//         string firstName, 
//         string lastName, 
//         string userRole)        // Employee or Manager
//     // is there an advantage to using "this.userID = userID"?
//     {
//         this.userID = userID;
//         this.userName = userName;
//         this.password = password;
//         this.firstName = firstName;
//         this.lastName = lastName;
//         this.userRole = userRole;
//     }

//     // Why do they have different amounts of references?
//     // Why do the number/amounts of references change?
//     public int userID {get; set;}
//     public string userName {get; set;}
//     public string password {get; set;}
//     public string firstName {get; set;}
//     public string lastName {get; set;}
//     public string userRole {get; set;}

// }


