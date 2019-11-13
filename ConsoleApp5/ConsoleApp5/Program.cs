using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tallista = new int[5];
            for(int i = 0; i<5; i++)
            {
                tallista[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 4; i >= 0; i--)
                Console.WriteLine(tallista[i]);
        }
    }
}
