using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0;
            Console.WriteLine("Enter an expression: ");
            var input = Console.ReadLine();
            input = input.Replace(" ", String.Empty);
            
            //if(length first = 1)
            first = Convert.ToInt32(input.Substring(0, 1));
            //else
            first = Convert.ToInt32(input.Substring(0, 2));





        }
    }
}
