using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpLearningBeginnerEightFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            // FILE provides static methods

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);

            string path = @"c:\somefile.jpg";
            File.Delete(path);

            if (File.Exists(path))
            {
                // Standard if conditional statement
            }

            string content = File.ReadAllText(path);




            // FILE INFO provides instance methods

            FileInfo fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                // Standard if conditional statement
            }





            // DIRECTORY
            Directory.CreateDirectory(@"c:\temp\folder1");

            string[] files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.jpg", SearchOption.AllDirectories);
            foreach (string file in files)
                Console.WriteLine(file);

            string[] directories = Directory.GetDirectories(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            foreach (string directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");




            // DIRECTORY INFO

            DirectoryInfo directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();





            // PATH

            string path = @"c:\projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";

            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetDirectoryName(path));


        }
    }
}
