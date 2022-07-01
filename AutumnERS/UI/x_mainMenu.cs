
// using Models;
// using Services;
// using System.Text.Json;

// namespace UI;

// public class MainMenu
// {
//     public void Begin()
//     {
//         Console.WriteLine("Welcome to AutumnERS, where expenses are as beautiful as Autumn leaves.");
        
//         do
//         {
//             Console.WriteLine("What do you need to do first?");
//             Console.WriteLine("[1] Login");
//             Console.WriteLine("[2] Register");
//             string input = Console.ReadLine();

//             switch(input)
//             {
//                 case "1": // Login
//                     Console.WriteLine("userName: ");
//                     string userName = Console.ReadLine();
//                     Console.WriteLine("Password, too: ");
//                     string password = Console.ReadLine ();
//                     Console.WriteLine("Welcome, " + userName + ".");
//                     // What is the dollar sign for?
//                 break;
//                 case "2": // register

//                     private void RegisterNewUser()
//                         {
//                             // need method to generate userID
//                             Console.WriteLine("Create a userID");
//                             string userID = Console.ReadLine();
//                             Console.WriteLine("Choose a userName");
//                             string userName = Console.ReadLine();
//                             Console.WriteLine("Type a password.");
//                             string password = Console.ReadLine();
//                             Console.WriteLine("First Name: ");
//                             string firstName = Console.ReadLine();
//                             Console.WriteLine("Last Name: ");
//                             string lastName = Console.ReadLine();  
//                             Console.WriteLine("Your role: ");
//                             Console.WriteLine("[1] Employee");
//                             Console.WriteLine("[2] Manager");
//                             string userRole = Console.ReadLine();  
//                             switch(userRole)
//                             {
//                                 case "1": // Employee
//                                     userRole = "Employee";
//                                 break;
//                                 case "2": // Manager
//                                     userRole = "Manager";               
//                                 break;
//                                 default:
//                                     Console.WriteLine("Thank you.");
//                                 break;
//                             }

//                             User registeringUser = new User(
//                                 this.userName = userName,
//                                 this.password = password,
//                                 this.firstName = firstName,
//                                 this.lastName = lastName,
//                                 this.userRole = userRole
//                             );
//                             try
//                             {
//                                 User buttface = new AuthService().Register(registeringUser);
//                                 Console.WriteLine("You're all registered and stuff!");
//                             }  
//                             catch(JsonException ex)
//                             {
//                                 Console.WriteLine("Sorry, you screwed something up. Try again.");
//                             }
//                         }           
//                 break;
//                 default:
//                     Console.WriteLine("What kind of nonsense was that?");
//                 break;
//             } 
//         } while(true);
//     }
// }