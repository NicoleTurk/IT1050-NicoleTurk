using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = 2;
            while (q < 128) //If you write while (q <= 128) it'll write the full thing, but if you tweak it then it won't go past 64.
            {
                Console.WriteLine("[{0}]", q);
                q *= 2;
            }

            for (int x = 49; x >= 1;)
            {
                Console.Write("{0}", x);
                x--;
                if (x >= 1)
                    Console.Write(",");
            }
            Console.WriteLine(""); // I need space for activities.

            int i = 1;
            while (i <= 21)
            {
                Console.Write("{0} ", i);
                i = i + 2;
            }

            // 7. It posts the * once, because it runs sequentially. If you write it as a while statement, it would function as intended and never print a *.

            bool icyRain = false;
            bool tornadoWarning = false;
            string name = "Let's go outside";

            if ((icyRain) & (tornadoWarning));
            else
                Console.WriteLine("{0}", name);

                //int f = 6;
                //Boolean keepLooping = true;
                // while (keepLooping)
                //{
                //    if (f <= 5)
                //  keepLooping = false;
                //   f++;
                //  Console.WriteLine("I can't stop running.");
                //  }



            }
        }
    }
