using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a phrase: ");
            var input = Console.ReadLine();
            //var length = input.length();
            
            char[] letters = input.ToCharArray();
            char[] reversed = input.ToCharArray();
            Array.Reverse(reversed);
            if (letters == reversed)
                Console.WriteLine(input + " is a palindrome");
            else
                Console.WriteLine(input + " is not a palinrome");

            Console.WriteLine("FLY HAI");




        }
    }
}
