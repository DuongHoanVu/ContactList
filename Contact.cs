using System;

namespace ContactsList
{
  class Contact
  {
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string Address {get; set;}
    public string PhoneNumber {get; set;}

    // Constructor; creates a new instance
    public Contact(string firstName, string lastName, string address, string phoneNumber)
    {
      // Todo: solve question 4
      if (string.IsNullOrWhiteSpace(firstName))
      {
            firstName = "default";
      }
      if (string.IsNullOrWhiteSpace(lastName))
      {
            lastName = "default";
      }

      FirstName = firstName;
      LastName = lastName;
      Address = address;
      PhoneNumber = phoneNumber;
    }

    // This ensures that you can print the information related to a contact
    // simply by saying Console.WriteLine(contact)
    // ToString() belongs to the Object class, which is the superclass of every
    // other class in C#.
    // You will need to override this in the subclasses (i.e., specializations)
    // to display additional information.
    public override string ToString()
    {
      return String.Format(
        "Name: {0} {1}\nAddress: {2}\nPhone: {3}\n\n",
        FirstName, LastName, Address, PhoneNumber);
      }
  }
}
