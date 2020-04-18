using System;

namespace Uri_1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, raiz;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    raiz = i * i;
                    Console.WriteLine(i + "^2 = " + raiz);
                }

            }
        }
    }
}