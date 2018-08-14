using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpBeginnerThree.Math;

namespace cSharpBeginnerThree //CSharp Fundamentals
{

    class  Program
    { 
        static void Main(string[] args)
        {

            // CLASSES

            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            calculator calculator = new calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            // ARRAYS
            // Array of length 3. The length is fixed in C#.

            var numbers = new int[3] { 1, 2, 3 }; 
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);  // Filled with default value based on array type.
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            // Can define values at initialization

            var names = new string[3] {"Jack", "John", "Mary"};

            // STRINGS

            //This is a standard string concatanation. 

            // string name = firstName + " " + lastName;

            //STRING FORMAT

            //This is a format that makes strings easier to read.

            // string actucalName = string.Format("{0} {1}", firstName, lastName);
            
            // Strings are immutable

                       var firstName = "Mosh";
                       var lastName = "Hamedani";

                       var fullName = string.Format("My name is {0} {1}", firstName, lastName);
                       Console.WriteLine(fullName);

                       var names = new string[3] { "Jack", "John", "Mary" };
                       var formattedNames = string.Join(",", names);
                       Console.WriteLine(formattedNames);

                       var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2";
                       Console.WriteLine(text);
                       var text1 = @"Hi John
                             Look into the following paths
                             c:\folder1\folder2";
                       Console.WriteLine(text1);

            //ENUMS
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
