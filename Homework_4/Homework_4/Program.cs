using System;

namespace Data
{
    public class Card
    {
        private string Name;
        private long SynCode;
        private long ProjectId;

        public Card(string name, long synCode, long projectId)
        {
            Name = name;
            SynCode = synCode;
            ProjectId = projectId;
        }

        public Card()
        {
            
        }

        public string SetNewName()
        {
            Console.WriteLine("Name your card:");
            Name = Convert.ToString(Console.ReadLine());
            return Name;
        }

        public long SetNewProjectId()
        {
            Console.WriteLine("Set ProjectId for new card");
            ProjectId = Convert.ToInt64(Console.ReadKey());
            return ProjectId;
        }

        public class Contact
        {
            private long PhoneNumber;

            public long SetPhoneNumber()
            {
                Console.WriteLine("Type your contacts Phone number");
                PhoneNumber = Convert.ToInt64(Console.ReadLine());
                return PhoneNumber;
            }
        }

        public class ContactsPhoneZone: Contact
        {
            private long PhoneZone;
        }

        public class ContactsEmail: Contact
        {
            private string Email;
            private string Alias;

            public string EmailAddress()
            {
                Console.WriteLine("Type your contacts Email address");
                Email = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Type your contacts alias");
                Alias = Convert.ToString(Console.ReadLine());
                return Email;
                return Alias;
            }
        }


        static void Main(string[] args)
        {
         
        }
    }
}