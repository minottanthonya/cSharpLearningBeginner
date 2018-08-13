using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBeginnerThree //CSharp Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            // CLASSES

            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);



            // ARRAYS
            // array of length 3... length is fixed in c sharp

            int[] numbers = new int[3]; 
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);  // Filled with default value based on array type.
            Console.WriteLine(numbers[2]);

            // Can define values at initialization

            string[] names = new string[3] {"Jack", "John", "Mary"};



            // STRINGS
            // strings are immutable

                       string firstName = "Mosh";
                       string lastName = "Hamedani";

                       string fullName = string.Format("My name is {0} {1}", firstName, lastName);
                       Console.WriteLine(fullName);

                       string[] names = new string[3] { "Jack", "John", "Mary" };
                       string formattedNames = string.Join(",", names);
                       Console.WriteLine(formattedNames);

                       string text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2";
                       Console.WriteLine(text);
                       string text1 = @"Hi John
                             // Look into the following paths
                             c:\folder1\folder2";
                       Console.WriteLine(text1);



        }
    }
}
