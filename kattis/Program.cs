using System;
namespace kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string[] y = x.Split(' ');

            int a1 = int.Parse(y[0]);
            int a2 = int.Parse(y[1]);
            int a3 = int.Parse(y[2]);

            for (int i = 1; i < a3+1; i++)
            {
                if (i % a1 == 0 && i % a2 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % a1 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % a2 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else 
                {
                    Console.WriteLine(i); 
                }
                
            }

            
            

        }
    }
}