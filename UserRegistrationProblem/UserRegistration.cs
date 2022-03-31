using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class UserRegistration
    {
        public Regex FirstName = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        public Regex LastName = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        public void ValidFirstName(string firstName)
        {
            if (FirstName.IsMatch(firstName))
                Console.WriteLine("firstName is valid");
            else
                Console.WriteLine("firstName is Invalid");

        }
        public void ValidLastName(string lastName)
        {
            if (FirstName.IsMatch(lastName))
                Console.WriteLine("lastName is valid");
            else
                Console.WriteLine("lastName is Invalid");
        }
    }
}
