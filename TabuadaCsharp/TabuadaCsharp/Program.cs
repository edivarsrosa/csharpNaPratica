using System;

namespace TabuadaCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("3 X " + i + " = " + (i*3));
            }
            Console.WriteLine();
            for(int i=0; i<11; i++)
            {
                Console.WriteLine("4 X " + i + " = " + (i * 4));
            }
        }
    }
}
