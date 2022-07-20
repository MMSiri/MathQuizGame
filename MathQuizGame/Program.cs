using System;

namespace MathQuizGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Q q = new Q(Q.R.Next(2) == 1);
            while (true)
            {
                Console.Write($"{q.N1} {q.Op} {q.N2} = ");
                if (!int.TryParse(Console.ReadLine(), out int i))
                {
                    Console.WriteLine("Thanks for playing!");
                    return;
                }
                if (q.Check(i))
                {
                    Console.WriteLine("Correct!");
                    q = new Q(Q.R.Next(2) == 1);
                }
                else Console.WriteLine("Incorrect. Try again!");
            }

        }
    }
}
