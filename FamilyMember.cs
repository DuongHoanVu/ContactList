using System;

namespace ContactsList
{
  class FamilyMember : Contact
  {
    // TODO : Add implementation
    protected string birthday { get; set; }
    protected string emergencyPhoneNumber { get; set; }

    public FamilyMember(string firstName, string lastName, string address, string phoneNumber, string emergencyPhoneNumber, string birthday) :
      base(firstName, lastName, address, phoneNumber)
    {
      // TODO: Update this to set additional information
      this.emergencyPhoneNumber = emergencyPhoneNumber;
      this.birthday = birthday;
    }

    public override string ToString()
    {
      return String.Format(
        "Name: {0} {1}\nAddress: {2}\nPhone: {3}\nEmergencyPhoneNumber: {4}\nBirthday: {5}\n\n",
        FirstName, LastName, Address, PhoneNumber, emergencyPhoneNumber, birthday);
    }
  }
}
