/**********************************************************************************************************
 * Class: Programming 120  (Classes and Objects)                                                          *
 * Project: HW4 Inheritance with Fruit                                                                    *
 * Professor: Kurt Friedrich                                                                              *
 * Name: Chris Singleton                                                                                  *
 * Date: 10/17/2016                                                                                       *
 **********************************************************************************************************
 * Summary: 1. Create a Console Class, Parent class and two Child Classes.                                *
 *          2. Instantiate Objects with Property Values in the Program Class of the Console,              *
 *          3. By Adding property values to Object parameters in the Program Class of the Console.        *
 *          4. Pass Properties directly from the Child Classes to the Program Object parameter values,    *
 *          5. And capture the values directly in the Program Class.                                      *
 *          6. Child Classes directly inherit the Weight Property from the Parent Fruit Class.            *
 *          7. Capture the Objects properties to methods that write out to the Console.                   *
 *          8. In the argument, Import property value only shows in the write string, based on being true.*
 *          9. Note: Write out the Import object property values in the string placeholders.              *
 **********************************************************************************************************/
using ChrisSingletonFruit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrisSingletonFruit
{
    public class Program
    {
       // private static readonly string Imported;
        static void Main(string[] args)
        {
            
            // Note: The constructors in the subclasses are getting weight from the Fruit class, then passing properties to the parameter values of the objects.
            Apple Apple1;  // name and create a new variable of type Apple1, then pass the property values.
            Apple1 = new Apple("Red", 5); //instantiate an object instance of a new object, call constructor, new returns reference to object.

            Apple Apple2;  // name and create a new variable of type Apple2, then pass the property values.
            Apple2 = new Apple("Green", 6); //instantiate an object instance of a new object, call constructor, new returns reference to object.

            Banana Banana1;  // name and create a new variable of type Banana1, then pass the property values.
            Banana1 = new Banana("Green", 4, false); //instantiate an object instance of a new object, call constructor, new returns reference to object.

            Banana Banana2;  // name and create a new variable of type Banana1, then pass the property values.
            Banana2 = new Banana("Yellow", 8, true); //instantiate an object instance of a new object, call constructor, new returns reference to object.

            // Print out the Objects.
            PrintApple(Apple1);
            PrintApple(Apple2);
            PrintBanana(Banana1);
            PrintBanana(Banana2);
            Console.ReadKey();
        }

        /* Pass the Print Object values to the methods. Note: Doesn't matter the name, it will take on any
           Apple parameter with values. */
        private static void PrintApple(Apple applePassedIn)
        {
            Console.Write("\nThis Apple weighs:  {0} oz, and its Color is: {1}", applePassedIn.Weight, applePassedIn.Color+".");
        }

        // Pass the values to the string, while only allowing a true Boolean condition.
        private static void PrintBanana(Banana Banana2)
        {
            string isImported;
            if (Banana2.Imported)
            {
                isImported = "is imported.";
            }
            else
            {
                isImported = "is not imported.";
            }

            Console.Write("\nThis Banana weighs: {0} oz, and its Color is: {1} and {2}", Banana2.Weight, Banana2.Color, isImported);
            
        }
    }
}
