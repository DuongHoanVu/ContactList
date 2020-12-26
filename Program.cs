using System;

namespace ContactsList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of contacts
            ListOfContacts myList = new ListOfContacts();

            // Populate the list
            myList.AddContact(new Contact(
              null, "Mukherjee", "842 Cambie Road, Vancouver, BC", "000-000-0000"));

            myList.AddContact(new Contact(
              "Jim", "Kurose", "University of Massachusetts", "111-111-1111"));

            myList.AddContact(new Contact(
              "Richard", "Sutton", "University of Alberta, Edmonton", "222-222-2222"));

            // TODO: Add additional information
            myList.AddContact(new Friend(
              "Santa", "Claus", "North Pole, H0H 0H0, Canada", "1-800-H0H-0H00", "friendemail@gmail.com"));

            // TODO: Add additional information
            myList.AddContact(new Colleague(
              "Friendly", "Colleague", "842 Cambie Road, Vancouver, BC", "333-333-3333", "Amazon", "collegue@amazon.com"));

            // TODO: Add additional information
            myList.AddContact(new FamilyMember(
              "Beau", "TheDog", "Under the sofa, Vancouver, BC", "1-800-WOOF-GRR", "999-999-9999", "02-24-97"));

            // Print the contents of the contacts list
            //Console.WriteLine(myList);

            // Search the list by firstName lastName combinations
            // When a match is found, display all contact information available
            // All the searches should find a match except for the last one.
            string[] firstNames = new string[]{
              "Sourav", "Jim", "Richard", "Santa", "Friendly", "Beau", "Keith"};
            string[] lastNames = new string[]{
              "Mukherjee", "Kurose", "Sutton", "Claus", "Colleague", "TheDog", "Ross"};

            for (int index = 0; index < firstNames.Length; index++)
            {
              Contact match = myList.Search(firstNames[index], lastNames[index]);
              if (match == null)
              {
                Console.WriteLine("No match found with first name: {0} and last name: {1}",
                  firstNames[index], lastNames[index]);
              }
              else
              {
                Console.WriteLine("Match found with first name: {0} and last name: {1}\n{2}",
                  firstNames[index], lastNames[index], match);
              }
            }
        }
    }
}
