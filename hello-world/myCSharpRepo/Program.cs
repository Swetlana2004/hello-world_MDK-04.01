using System;
using System.IO;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine("Hello world");
            }
        }
    }
}
