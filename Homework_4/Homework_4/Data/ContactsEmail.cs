using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4.Data
{
    public class ContactsEmail : Contact
    {
        private string Email;
        private string Alias;

        public string EmailAddress()
        {
            Console.WriteLine("Type your contacts Email address");
            Email = Convert.ToString(Console.ReadLine());
            return Email;
        }
    }
}
