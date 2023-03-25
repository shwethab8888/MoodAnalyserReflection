using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class LastName
    {
            private string input;

            public LastName(string input)
            {
                this.input = input;
            }

            public string Analyze()
            {
                if (string.IsNullOrEmpty(input) || !char.IsUpper(input[0]))
                {
                    return "Invalid last name: must start with a capital letter.";
                }

                if (input.Length < 3)
                {
                    return "Invalid last name: must have at least 3 characters.";
                }

                return "Valid last name!";
    
            }
        public static void Last_Name()
        {
            string input = "Shwetha";
            LastName lastName = new LastName(input);
            string result = lastName.Analyze();
            Console.WriteLine(result); 

           
            input = "reddy";
            lastName = new LastName(input);
            result = lastName.Analyze();
            Console.WriteLine(result); 

            input = "B";
            lastName = new LastName(input);
            result = lastName.Analyze();
            Console.WriteLine(result); 
        }
    }
}
