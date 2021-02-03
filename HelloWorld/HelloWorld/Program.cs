using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {          
            string myname = "Patricia";
            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Hello World!");
            Console.WriteLine(capsMessage);

            Console.Read();
            

        }
    }
}
