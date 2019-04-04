using System;

namespace net
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 20;
            var c = a;
            a = b;
            b = c;

            Console.WriteLine($"Inverted - A={a} and B={b}");
        }
    }
}
