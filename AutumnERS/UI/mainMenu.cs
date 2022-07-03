
using Models;
using Services;
using System.Text.Json;



namespace UI;
                                                // Interacts with Users
                                                // creating a new user  
                                                // User login
public class MainMenu
{
    public void Begin()
    {
        do
        {
            Console.WriteLine("Welcome to AutumnERS, where expenses are as beautiful as Autumn leaves.");
            Console.WriteLine("What do you need to do first?");
            Console.WriteLine("[1] Login");
            Console.WriteLine("[2] Register");
            Console.WriteLine("[3] View User List");
            Console.WriteLine("[4] View Ticket List");
            Console.WriteLine("[5] Exit");
            string input = Console.ReadLine();

            switch(input)
            {
                case "1": // Login
                    Console.WriteLine("userName: ");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Password, too: ");
                    string password = Console.ReadLine ();
                    Console.WriteLine("Welcome, " + userName + ".");
                    // What is the dollar sign for?
                break;
                case "2": // register
                    Console.WriteLine("Choose a userName");
                    string maybeUserName = Console.ReadLine();
                    Console.WriteLine("Your typed " + maybeUserName + ".");
                    Console.WriteLine("Type a password.");
                    string maybePassword = Console.ReadLine();
                    Console.WriteLine("First Name: ");
                    string maybeFirstName = Console.ReadLine();
                    Console.WriteLine("Last Name: ");
                    string maybeLastName = Console.ReadLine();  
                    Console.WriteLine("Your role: ");
                    Console.WriteLine("[1] Employee");
                    Console.WriteLine("[2] Manager");
                    string maybeRole = Console.ReadLine();  
                    switch(maybeRole)
                    {
                        case "1": // Employee
                            maybeRole = "Employee";
                        break;
                        case "2": // Manager
                            maybeRole = "Manager";               
                        break;
                        default:
                            Console.WriteLine("Thank you.");
                        break;
                    }  
                    Console.WriteLine(maybeFirstName + " " + maybeLastName + " is a " + maybeRole + ".");
                    Environment.Exit(0);               
                break;
                case "3": // View User List
                    Console.WriteLine("The User list displays.");
                break;
                case "4": // View Ticket List
                    Console.WriteLine("The Ticket list displays.");
                break;
                case "5": // Exit
                    Console.WriteLine("Goodbye.");
                    Environment.Exit(0);
                break;
                default:
                    Console.WriteLine("What kind of nonsense was that?");
                break;
            } 
        } while (true);
    }
}

