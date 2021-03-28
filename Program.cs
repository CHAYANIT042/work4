using System;

namespace ข้อสอบ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("input number a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("input number b");
            b = int.Parse(Console.ReadLine());
            int x = a;
            int y = b;

            while (x != y)
            {
                if (x < y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }
            }
            Console.WriteLine(x);
        }
    }
}
