using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace male_or_female
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your gender (Male/Female): ");
            string gender = Console.ReadLine();

            if (gender.Equals("Male"))
            {
                Console.WriteLine("User is Male");
            }
            else if (gender.Equals("Female"))
            {
                Console.WriteLine("User is Female");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
