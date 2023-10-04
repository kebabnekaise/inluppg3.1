using System;
using System.IO.Pipes;

namespace inluppg3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ans = int.Parse(Console.ReadLine());
            if (ans <= 19 && ans >= 16)
            {
                Console.WriteLine("Du får delta");
            }
            else if (ans < 16)
            {
                Console.WriteLine("Du är för ung");
            }
            else
            {
                Console.WriteLine("Du är för gammal");
            }
        }
    }
}