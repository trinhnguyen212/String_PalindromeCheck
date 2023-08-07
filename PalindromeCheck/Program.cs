using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to check if it is Palindrome or not: ");
            string string_input = Console.ReadLine();
            string rev;

            char[] ch = string_input.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = string_input.Equals(rev, StringComparison.OrdinalIgnoreCase);

            if (b)
            {
                Console.WriteLine("" + string_input + " is a Palindrome");
            }
            else
            {
                Console.WriteLine("" + string_input + " is not a Palindrome!");
            }

            Console.Read();
        }
    }
}
