namespace UI;
//using Models;
// using Services;
// using DataAccess;
// using DataStorage;

// Interacts with Users
// User creation
// User login

// Console.WriteLine("Type a username for your account.");

// need a method for then creating a new user following up with questions to fill in properties. 

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
                break;
                default:
                    Console.WriteLine("What kind of nonsense was that?");
                break;
            } 
        } while (true);
    }
}


