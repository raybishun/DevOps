using System;

namespace JenkinsDotNetPoC
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(DoWork("Hello, World!"));
        }

        public static string DoWork(string message = "Hello, World!")
        {
            return message;
        }
    }
}
