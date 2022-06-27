namespace Models;

// Look up ... case sensitivity of class libraries

// USERS
    // Create User class
        // Manager
        // Employee
    // User creation
        // User login

public class User
{
    // What is the advantage of this over an empty constructor? So I can use autoprops?
    public User(
        int userID, 
        string credName, 
        string userPassword, 
        string userFirstName, 
        string userLastName, 
        string userRole)
    // is there an advantage to using "this.userID = userID"?
    {
        ID = userID;
        userName = credName;
        password = userPassword;
        firstName = userFirstName;
        lastName = userLastName;
        role = userRole;
    }

    // Why do they have different amounts of references?
    // Why do the number/amounts of references change?
    public int ID {get; set;}
    public string userName {get; set;}
    public string password {get; set;}
    public string firstName {get; set;}
    public string lastName {get; set;}
    public string role {get; set;}

}