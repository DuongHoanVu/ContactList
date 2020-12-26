using System;

namespace ContactsList
{
  class Friend : Contact
  {
    // TODO : Add implementation
    protected string personalEmail { get; set; }

    public Friend(string firstName, string lastName, string address, string phoneNumber, string personalEmail) :
      base(firstName, lastName, address, phoneNumber)
    {
      // TODO : Update this to set additional information
      this.personalEmail = personalEmail;
    }

    public override string ToString()
    {
      return String.Format(
        "Name: {0} {1}\nAddress: {2}\nPhone: {3}\nPersonalEmail: {4}\n\n",
        FirstName, LastName, Address, PhoneNumber, personalEmail);
    }
  }
}
