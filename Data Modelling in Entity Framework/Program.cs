using System;
using System.Collections.Generic;

public class Customer
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; } // Can be empty
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public List<string> PhoneNumbers { get; set; } // One customer can have many phone numbers
    public string Address { get; set; } // Many customers can live at one address
    public string Email { get; set; } // Can be empty
    public List<string> Likes { get; set; } // Many customers can have many likes
    
    public Customer()
    {
        PhoneNumbers = new List<string>();
        Likes = new List<string>();
    }
}
