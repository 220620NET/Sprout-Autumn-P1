﻿using Models;

User Barbara = new User (01, "bgordon", "oracle", "Barbara", "Gordon", "Employee");

Console.WriteLine("ID: " + Barbara.ID);
Console.WriteLine("username: " + Barbara.userName);
Console.WriteLine(Barbara.firstName + " " + Barbara.lastName + "'s secret is " + Barbara.password + ".");
Console.WriteLine(Barbara.firstName + " is a mere " + Barbara.role + ".");






Console.WriteLine("Type a username for your account.");
// need a method for then creating a new user following up with questions to fill in properties. 