using System;

public class Person : IPersonContact
{
    public string name { get; set; }
    public string lastName { get; set; }
    public string address { get; set; }
    public string email { get; set; }
    public int phoneNumber { get; set; }
    public string city { get; set; }

    public Person(string name, string lastName, string address, string email, int phoneNumber, string city)
    {
        this.name = name;
        this.lastName = lastName;
        this.address = address;
        this.email = email;
        this.phoneNumber = phoneNumber;
        this.city = city;
    }

}
