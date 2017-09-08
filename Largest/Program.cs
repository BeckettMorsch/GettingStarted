using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            int third;

            Console.WriteLine("Input the 1st number : ");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 2nd number : ");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 3rd number : ");
            third = Convert.ToInt32(Console.ReadLine());

            if (first > second && first > third)
                Console.WriteLine("The 1st Number is the greatest among the three");
            else if (second > first && second > third)
                Console.WriteLine("The 2nd Number is the greatest among the three");
            else
                Console.WriteLine("The 3rd Number is the greatest among the three");

            






        }
    }
}
