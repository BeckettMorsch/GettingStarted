using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordAuthentication
{
    class Program
    {
        static void Main(string[] args)
        {
            var pass = "letmein";
            var user = "root";
            int num = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the Username: ");
                var userT = Console.ReadLine();
                Console.WriteLine("Enter the Password: ");
                var passT = Console.ReadLine();

                if (userT == "root" && passT == "letmein")
                {
                    Console.WriteLine("Username and password authenticated.. you may proceed");
                    num = 1;
                    break;
                }

            }
            if (num != 1)
                Console.WriteLine("Too many incorrect login attempts!  Try again later!");
            else
                num = 0;

        

        }
    }
}
