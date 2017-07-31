using System;

namespace first_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i =1; i <=255; i++)
            {
               Console.WriteLine(i);
            }

            for (int j = 1; j<=100; j++ )
            {
                if ((j % 3 == 0 || j % 5 == 0) && j % 15 != 0)
                {
                    Console.WriteLine(j);
                }
            }

            for (int h = 1; h<= 100; h++)
            {
                if ( h % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ( h % 3 == 0)
                {
                     Console.WriteLine("Buzz");
                }
                else if ( h % 5 == 0 )
                {
                     Console.WriteLine("Fizz");
                }
            Random rand = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int val = rand.Next(1,100);

                if (val % 15 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                }
                else if (val % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (val % 3 == 0)
                {
                     Console.WriteLine("Fizz");
                }
                
                }
            }
            // Console.WriteLine()
        }
    }
}
