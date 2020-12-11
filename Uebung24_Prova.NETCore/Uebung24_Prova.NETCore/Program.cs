using System;

namespace Uebung24_Prova.NETCore
{
    class Program
    {
        static void Main(string[] args)
        {
        length:
            int length = 10000;
            Console.WriteLine("Hello World!");
            for (int i = 0; i < length; i++)
            {
                goto length;
            }
        }
    }
}
