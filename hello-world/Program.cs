using System;
using System.IO;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello world!";
            Console.WriteLine(message);
            File.WriteAllText("output.txt", message);
        }
    }
}
