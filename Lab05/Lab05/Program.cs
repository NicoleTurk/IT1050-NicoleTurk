using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {

            //2. A. Scope: double height. double width.() B. Static vs. Non-Static: Static is not used in this example, as it would be located after Public. Static determines if we can call it without creating an object. C. Return Type: Determines the type of value returned, if any. Double. D. Method Name: getArea. Where you get the information. E. Parameters: Public. Determines restrictions on the code, none in public. F. Method Body: return height * width. Code that gets executed  3. The difference between a user-defined method and a method provided by a framework is that a user-defined method is one that is custom made. A method provided by the framework is essentially stock. When creating a user-defined method you should determine whether or not you even need one, if a stock method might be of better use. 4. The difference between a static and non-static method is that non-static requires an object to call them. Static cannot be instantiated. 
        }
    }
}            
namespace Dog       
{
    class Program
    {
        public string bark;
        public static void bark();
            {
                Dog myDog=new Dog(bark);
                myDog.Name="Fido";

                // To do: uncomment the following lines of code to call the methods
                myDog.bark()
                myDog.doTrick("Fetch")
            }
    }
}
    

