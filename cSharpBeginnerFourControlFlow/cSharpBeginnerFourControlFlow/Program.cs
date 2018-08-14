using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBeginnerFourControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            // IF/Else Statements

            //int hour = 10;

            //if (hour > 0 && hour < 12)
            //    Console.WriteLine("It's morning.");
            //else if (hour >= 12 && hour < 18)
            //    Console.WriteLine("It's afternoon.");
            //else
            //    Console.WriteLine("It's evening.");


            //bool isGoldCustomer = true;
            //float price;

            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.95f;

            //float price = (isGoldCustomer) ? 19.95f : 29.95f;


            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Spring:
                    Console.WriteLine("It's autumn and its a beautiful season");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's summer and a perfect time to to go the beach.");
                    break;

                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }

            // For Loop

            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }



            string name = "John Smith";
            for (int i = 0; i < name.Length; i++)
                Console.WriteLine(name[i]);

            foreach (char character in name)
                Console.WriteLine(character);


            int[] numbers = new int[] { 1, 2, 3, 4 };
            foreach (int number in numbers)
                Console.WriteLine(number);

            // While Loop

            int i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                i++;
            }



            while (true)
            {
                Console.Write("Type your name: ");
                string input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;

                Console.WriteLine("@Echo: " + input);
            }



            Random random = new Random();

            for (int i = 0; i < 10; i++)
                Console.Write((char)('a' + random.Next(0, 26)));
            //Console.Write((char)random.Next(97, 122));
            Console.WriteLine();



            Random random = new Random();
            const int PasswordLength = 10;
            char[] buffer = new char[PasswordLength];

            for (int i = 0; i < PasswordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            string password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
