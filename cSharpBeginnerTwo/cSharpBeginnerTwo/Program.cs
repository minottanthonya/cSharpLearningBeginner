using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBeginnerTwo //Type Conversion
{
    class Program
    {
        static void Main(string[] args)
        {

            //will not work if you have the int first UNLESS BELOW
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            //now it will work because you CAST the byte (Make it explicit to visual studio what you are trying to do
            int d = 1;
            byte y = (byte) d;
            Console.WriteLine(y);

            //two parter here
            var number = "1234";
            int t = Convert.ToInt32(number);
            Console.WriteLine(t);

            //second part using try showing how to handle an exception
            try
            {
                var numbah = "1234";
                int x = Convert.ToByte(numbah);
                Console.WriteLine(x);
            }
            catch (Exception)
            {
                Console.WriteLine("The number didnt work right, wasn't converted to a byte.");
            }

            //Last part

            try
            {
                string str = "true";
                bool f = Convert.ToBoolean(str);
                Console.WriteLine(f);
            }
            catch (Exception)
            {
                Console.WriteLine("Was not converted to boolean.");
            }

        }
    }
}
