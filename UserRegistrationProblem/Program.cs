using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello all welcome to User Registration Regex");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Program number to get executed \n1. Validate first name \n2.Validate Lastname " +
                   "\n3. Validate Email \n4. Validate Mobile No \n5. ValidatePasswordRule1 \n6. Validate Password Rule2 \n7. valid Password Rule3" +
                  "\n8.Exit" );
                UserRegistration Checkpattern = new UserRegistration();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("*First letter should be capital.");
                        Console.WriteLine("*length should be Minimum three characters.");
                        Console.WriteLine("Enter First name :");
                        string fname = Console.ReadLine();
                        Checkpattern.ValidFirstName(fname);
                        break;
                    case 2:
                        Console.WriteLine("*First letter should be capital.");
                        Console.WriteLine("*length should be Minimum three characters.");
                        Console.WriteLine("Enter Last name :");
                        string lname = Console.ReadLine();
                        Checkpattern.ValidLastName(lname);
                        break;
                    case 3:
                        Console.WriteLine("Enter Email id :");
                        string email = Console.ReadLine();
                        Checkpattern.ValidEmail(email);
                        break;
                    case 4:
                        Console.WriteLine("Enter Mobile No. :");
                        string mobilenum = Console.ReadLine();
                        Checkpattern.ValidMobile(mobilenum);
                        break;
                    case 5:
                        Console.WriteLine("Enter Password :");
                        Console.WriteLine("*Password for minimum 8 characters");
                        string password = Console.ReadLine();
                        Checkpattern.ValidPasswordRuleOne(password);
                        break;
                    case 6:
                        Console.WriteLine("Enter Password :");
                        Console.WriteLine("*Password for minimum 8 characters");
                        Console.WriteLine("*Atleat One UpperCase");
                        string passwordRule2 = Console.ReadLine();
                        Checkpattern.ValidPasswordRuleTwo(passwordRule2);
                        break;
                    case 7:
                        Console.WriteLine("Enter Password :");
                        Console.WriteLine("*Password for minimum 8 characters");
                        Console.WriteLine("*Atleat One UpperCase");
                        Console.WriteLine("*Atleast One Numeric Number");
                        string passwordRule3 = Console.ReadLine();
                        Checkpattern.ValidPasswordRuleThree(passwordRule3);
                        break;
                    case 8:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
    
}
    
