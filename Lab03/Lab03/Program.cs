using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            // They both perform an action, but how they do so is slightly different. An if single-selection statement performs an action once if the statement is true, whereas a while repetition statement will continue to perform the action for as long as the condition is true. 

            int speedlimit;
            int speed;
            speed = 42;
            speedlimit = 35;

            if (speed > speedlimit) Console.WriteLine("SLOW NOW");

            int isTrue;
            isTrue = 100;

            if (isTrue <= 100) Console.WriteLine("It is True!");
            else Console.WriteLine("It is False!");

            double temperature;
            double celsius;

            Console.Write("What is the temperature outside?");
            temperature = Convert.ToDouble(Console.ReadLine());
            celsius = (temperature - 32) * 5 / 9;
            Console.WriteLine("celsius {0}", celsius);

            if (temperature < 40) 
             Console.WriteLine("It is too cold!");  
            else if (temperature > 90)
             Console.WriteLine("It is too hot!"); 


            int climb;
            climb = 0;

            while (climb <= 10)
            {
                Console.WriteLine("climb: {0}", climb);
                climb++;
            }

            int fall;
            fall = 60;

            while (fall >= 20)
            {
                Console.WriteLine("fall: {0}", fall);
                fall -= 5;
            
            }

            int biggerclimb;
            biggerclimb = 10;

            while (biggerclimb <= 20)
            {
                Console.WriteLine("biggerclimb: {0}", biggerclimb);
                biggerclimb += 2;
            }
        }
    }
}
