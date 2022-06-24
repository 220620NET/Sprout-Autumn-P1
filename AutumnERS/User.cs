namespace Models;
// Other classes under the Models namespace:
    // Tickets

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

    // If I understood correctly, the following syntactic sugar automatically does validation checks?
    // Is there another reason to use them other than reducing coding time?
    // Why do the first two have zero references?
    // Why do the last four have a reference?
    public int ID {get; set;}
    public string userName {get; set;}
    public string password {get; set;}
    public string firstName {get; set;}
    public string lastName {get; set;}
    public string role {get; set;}

}