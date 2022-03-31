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
        public Regex Email = new Regex(@"^[A-Za-z]+([.+-][A-Za-z 0-9]+)*@[A-Za-z 0-9]+.[A-Za-z]([.[A-Za-z]{2,})?$");
        public Regex MobileNumber = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
        public Regex PasswordRuleOne = new Regex(@"^[A-Za-z]{8,}$");
        public Regex PasswordRuleTwo = new Regex(@"^[A-Za-z]*[A-Z]{1,}[A-Za-z]*$");
        public Regex PasswordRuleThree = new Regex(@"^[A-Za-z 0-9]{1,}[A-Z]{1,}[A-Za-z 0-9]*$");

        public void ValidFirstName(string firstName)
        {
            if (FirstName.IsMatch(firstName))
                Console.WriteLine("firstName is valid");
            else
                Console.WriteLine("firstName is Invalid");

        }
        public void ValidLastName(string lastName)
        {
            if (LastName.IsMatch(lastName))
                Console.WriteLine("lastName is valid");
            else
                Console.WriteLine("lastName is Invalid");
        }
        public void ValidEmail(string email)
        {
            if (Email.IsMatch(email))
                Console.WriteLine("Email is valid");
            else
                Console.WriteLine("Email is Invalid");
        }
        public void ValidMobile(string mobile)
        {
            if (MobileNumber.IsMatch(mobile))
                Console.WriteLine("mobile is valid");
            else
                Console.WriteLine("mobile is Invalid");
        }
        public void ValidPasswordRuleOne(string password)
        {
            if (PasswordRuleOne.IsMatch(password))
                Console.WriteLine("password is valid");
            else
                Console.WriteLine("password is Invalid");

        }
        public void ValidPasswordRuleTwo(string passwordRule2)
        { 
            if (PasswordRuleTwo.IsMatch(passwordRule2))
                Console.WriteLine("password is valid");
            else
                Console.WriteLine("password is Invalid");
        }
        public void ValidPasswordRuleThree(string passwordRule3)
        {
            if (PasswordRuleThree.IsMatch(passwordRule3))
                Console.WriteLine("password is valid");
            else
                Console.WriteLine("password is Invalid");
        }

    }
}
