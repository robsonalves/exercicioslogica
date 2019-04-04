using System;

namespace net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre your number value: ");
            var num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(--num);
        }
    }
}
