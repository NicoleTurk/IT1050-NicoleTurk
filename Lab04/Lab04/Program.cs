using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {

            // The four basic elements of counter-controlled repetition are the controlled variable, the initial value, the increment/decremeny, and the loop-continuation condition. The controlled variable is the counter for the loop, while the initial value is the starting value for the control variable. The increment/decrement is the modifier for the control variable as it goes through the lopp and the loop-continuation condition determines whether or not the loop's condition has been satisfied.

            // A for loop should be used when the number of iterations is already known and a while loop is used when it's not.

            // A do...while statement should be used when the statement needs to be run at least once, since it evaluates at the bottom. By comparison, a while runs conditinually until the condition is no longer true.

            int i;
            for ( i = 1; i <= 100; i++)
                
            {
                Console.WriteLine(i);
                if (( i % 2) == 0)
                Console.WriteLine("Even");
                else Console.WriteLine("Odd");
            }
            int temperature;

            Console.Write("Please enter a temperature");
            temperature = Convert.ToInt16(Console.ReadLine());

            if (temperature < 10)
                Console.WriteLine("Polar Bear");
            else if (temperature < 20)
                Console.WriteLine("Penguin");
            else if (temperature < 40)
                Console.WriteLine("Moose");
            else if (temperature < 50)
                Console.WriteLine("Reindeer");
            else if (temperature < 60)
                Console.WriteLine("Deer");
            else if (temperature < 70)
                Console.WriteLine("Turtle");
            else if (temperature < 80)
                Console.WriteLine("Lion");
            else if (temperature < 90)
                Console.WriteLine("Fish");
            else
                Console.WriteLine("Bug");

            int x = 10;
            while (x < 21)
            {
                Console.WriteLine("{0}", x);
                x++;
            }

            for (int y = 0; y < 101; y++)
            {
                Console.WriteLine(y);
                Console.WriteLine("********");
            }

        }
    }
}
