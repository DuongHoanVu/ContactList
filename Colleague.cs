using System;

namespace ContactsList
{
  class Colleague : Contact
  {
    // TODO: Add implementation
    protected string company { get; set; }
    protected string workEmail { get; set; }


    public Colleague(string firstName, string lastName, string address, string phoneNumber, string company, string workEmail) :
      base(firstName, lastName, address, phoneNumber)
    {
      // TODO: Update this to set additional information
      this.company = company;
      this.workEmail = workEmail;
    }
    public override string ToString()
    {
      return String.Format(
        "Name: {0} {1}\nAddress: {2}\nPhone: {3}\nCompany: {4}\nworkEmail: {5}\n\n",
        FirstName, LastName, Address, PhoneNumber, company, workEmail);
    }
  }
}
