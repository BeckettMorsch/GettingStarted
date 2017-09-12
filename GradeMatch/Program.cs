using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the grade : ");
            var input = Console.ReadLine();

            if (input == "e")
                Console.WriteLine("You have chosen : Excellent");
            else if(input == "v")
                Console.WriteLine("You have chosen : Very Excellent");
            else if(input == "g")
                Console.WriteLine("You have chosen : Good");
            else if(input == "a")
                Console.WriteLine("You have chosen : Average");
            else if(input == "f")
                Console.WriteLine("You have chosen : Fail");
            else
                Console.WriteLine("You have chosen : Nothing");




        }
    }
}
