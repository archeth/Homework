using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4.Data
{
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
}
