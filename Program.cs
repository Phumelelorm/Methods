using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calling a method with the return type
            Console.WriteLine(cube(5));
            Console.WriteLine(cube(2));
            Console.WriteLine(square(8));
            Console.WriteLine(add(10));
            Console.WriteLine(substract(15));
            
            Console.ReadLine();
        }

        static int cube(int number)
        {
            int result = number * number * number;
            return result;
        }
        static int square(int number)
        {
            int result = number * number;
            return result;
        }

        static int add(int number)
        {
            int result = number + number;
            return result;
        }

        static int substract(int number)
        {
            int result = number - 1;
            return result;  
        }
       
    }
}
