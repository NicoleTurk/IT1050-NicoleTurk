using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Lab2
{
    public class Multiplication
    {
        public static void Main(string[] args)
        {
            int number1;
            int number2;
            int product;

            Console.Write( "Enter first integer: " );
            number1 = Convert.ToInt32( Console.ReadLine() );
         
           Console.Write( "Enter second integer: " );
          number2 = Convert.ToInt32( Console.ReadLine() );
           
            product = number1 * number2;

           Console.WriteLine( "Sum is {0}",product);

            Console.WriteLine("{0}\n{1}", "Hello World!", "From Nicole");
            Console.WriteLine("Hello World!\tFrom Nicole");

            // a. The class declaration
            // b. The difference between integer type variables and double / floating-point variables is that double or floating-point variables have numbers following the decimal point, whereas an integer does not.
            // c. The DisplayMessage method is an example of a method used in Chapter 4.
            // d. get, set
            // e. A class is used to define a type of object, while the object itself is used to build the class. Classes are usually referred to as blueprints, while objects are like building blocks of stored memory.
        }
    }
}
