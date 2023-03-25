using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class FirstName
    {
        public bool Validate(string firstName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                return false;
            }

            if (!char.IsUpper(firstName[0]))
            {
                return false;
            }

            if (firstName.Length < 3)
            {
                return false;
            }

            return true;
        }

        public static void First_Name()
        {
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();

            FirstName validator = new FirstName();

            if (validator.Validate(firstName))
            {
                Console.WriteLine("Valid first name!");
            }
            else
            {
                Console.WriteLine("Invalid first name. Please try again.");
            }
        }
    }
}
