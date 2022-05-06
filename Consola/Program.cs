using System;
using Utils;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            Console.WriteLine(Singleton.GetInstance().connectDB());
        }
    }
}
