using System;

namespace Uri_1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;

            X = int.Parse(Console.ReadLine());

            while (X != 0)
            {
                if (X % 2 != 0)
                {
                    X = X + 1;
                }
                int soma = X + X + 2 + X + 4 + X + 6 + X + 8;
                Console.WriteLine(soma);
                X = int.Parse(Console.ReadLine());
            }

        }
    }
}