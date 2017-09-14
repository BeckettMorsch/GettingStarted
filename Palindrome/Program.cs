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
            int cont = 1;
            while (cont == 1)
            {
                Console.WriteLine("Enter a phrase: ");
                String original = Console.ReadLine();
                //var length = input.length();
                String input = original.ToLower();
                // Char.IsPunctuation(c)

                input = input.Replace(" ", "");
                input = input.Replace("?", "");
                input = input.Replace(".", "");
                input = input.Replace(",", "");
                input = input.Replace(":", "");
                input = input.Replace("!", "");
                input = input.Replace(";", "");


                char[] reversed = input.ToCharArray();

                Array.Reverse(reversed);
                String rev = new String(reversed);
                

                if (input != rev)
                    Console.WriteLine("\"" + original + "\"" + " is not a palindrome");
                else
                    Console.WriteLine("\"" + original + "\"" + " is a palindrome");


            }



        }
    }
}
