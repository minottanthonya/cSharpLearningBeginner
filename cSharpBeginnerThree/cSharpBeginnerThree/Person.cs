using System;

namespace cSharpBeginnerThree //CSharp Fundamentals
{
    //to easily make this class file, press alt + enter on the class, in this case the person, and then select the option to create new file
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}
