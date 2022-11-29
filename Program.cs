using System;

namespace Numbers_1___N_with_Step_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            for (long i = 1; i <= num; i += 3)
            {
                Console.WriteLine(i);
            }    
        }
    }
}
