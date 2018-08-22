using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.1415926f;

            double anotherPi = 3.14159265358979323846;

            decimal number = 1.495m;

            number = 14.4m;

            char myInitial = 'J';

            bool itWorked = true;

            itWorked = false;

            string message = "Hello World";

            message = "Turkey and ham";


            Console.WriteLine($"Content of myInitial is {myInitial}");
            
            Console.ReadKey();

        }

       

    }
}
