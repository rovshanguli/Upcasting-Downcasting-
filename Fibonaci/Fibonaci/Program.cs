using System;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumbuer = 0;
            int SecondNumber = 1;
            int count = 0;
            for(int i = 2; i< 15; i++)
            {
                count = FirstNumbuer + SecondNumber;
                FirstNumbuer = SecondNumber;
                SecondNumber = count;
            }
            Console.WriteLine(count);
        }
    }
}
