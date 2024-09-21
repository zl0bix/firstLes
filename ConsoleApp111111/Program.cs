using System;
using System.ComponentModel;
using System.Runtime.Intrinsics;



namespace ConsoleApp111111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string str = "";
            Console.Write("Enter number -> ");
            str = Console.ReadLine();          
            int n;           
                int.TryParse(str, out n);
            if (n != 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            


        }
    }
}
