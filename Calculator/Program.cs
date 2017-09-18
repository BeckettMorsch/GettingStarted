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
            int second = 0;
            //int value;
            int result = 0;
            Console.WriteLine("Enter an expression: ");
            String input = Console.ReadLine();
           
            input = input.Replace(" ", String.Empty);

            //if(length first = 1)
            first = Convert.ToInt32(input.Substring(0, 1));
            //else
            second = Convert.ToInt32(input.Substring(2));





            for (int i=0;i<input.Length + 1;i++)
            {
                if (input[i] == '*')
                    result = first * second;

                else if (input[i] == '/')
                    result = first / second;

                else if (input[i] == '+')
                    result = first + second;
                else
                    result = first = second;

                
            }

            Console.WriteLine("Result: " + input + " = "+result);
            Console.WriteLine("hi");



        }
    }
}
