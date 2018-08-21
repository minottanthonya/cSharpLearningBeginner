using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpLearningBeginnerSevenText
{
    class Program
    {
        static void Main(string[] args)
        {

            //string fullName = "Tony Minott ";

            //Console.WriteLine(fullName.Trim());  // Trims leading and trailing whitespace
            //Console.WriteLine(fullName.ToUpper());  // all uppercase

            //// Split into first and last names
            //int index = fullName.IndexOf(' '); // get first space
            //string firstName = fullName.Substring(0, index);
            //string lastName = fullName.Substring(index + 1);

            //// OR use split
            //string[] names = fullName.Split(' ');
            //// first name is first element of array
            //// last name is 2nd element of array

            //string newName = fullName.Replace("Tony", "Tiny");

            //if (String.IsNullOrEmpty(null))
            //    Console.WriteLine("Invalid");

            //if (String.IsNullOrEmpty(""))
            //    Console.WriteLine("Invalid");

            //if (String.IsNullOrEmpty(" ".Trim()))  // Use .Trim() to avoid whitespace issues. Or use .IsNullOrWhitespace()
            //    Console.WriteLine("Invalid");

            //if (String.IsNullOrWhiteSpace(" "))
            //    Console.WriteLine("Invalid");


            //string userInput = "25";

            //int userInputAsInt = Convert.ToInt32(userInput);

            //float price = 29.95f;  // convert to currency
            //Console.WriteLine(price.ToString("C0"));










            //// Summarizing text
            //string sentence = "There are many things that are known to man and mankind, but there are also things that are unknown.";
            //const int MaxLength = 20;

            //if (sentence.Length < MaxLength)
            //    Console.WriteLine(sentence);
            //else
            //{
            //    string[] words = sentence.Split(' ');
            //    int totalCharacters = 0;
            //    List<string> summaryWords = new List<string>();

            //    foreach (string word in words)
            //    {
            //        summaryWords.Add(word);
            //        totalCharacters += word.Length + 1;
            //        if (totalCharacters > MaxLength)
            //            break;
            //    }

            //    string summary = String.Join(" ", summaryWords) + "...";
            //    Console.WriteLine(summary);

            //}



            // convert that ^^ functionality into a class method, outside main method (bottom of this file)


            // Now we can call it like this:
            //string sentence = "There are many things that are known to man and mankind, but there are also things that are unknown.";
            //string summary = SummarizeText(sentence);
            //Console.WriteLine(summary);








            // String Builder

            StringBuilder builder = new StringBuilder();

            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            builder.Replace('-', '+');

            // Has .Remove .Insert and etc.
            // Does not have string searching methods, no .IndexOf.
            // Can access parts of string like:   builder[0]

            Console.WriteLine(builder);

            // Can chain these together
            builder.Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+');
        }
        // End of static void Main(string[] args)




        static string SummarizeText(string sentence, int maxLength = 20)
        {

            if (sentence.Length < maxLength)
                return sentence;


            string[] words = sentence.Split(' ');
            int totalCharacters = 0;
            List<string> summaryWords = new List<string>();

            foreach (string word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            return String.Join(" ", summaryWords) + "...";


        }



    }
}
