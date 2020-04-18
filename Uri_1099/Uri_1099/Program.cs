using System;

namespace Uri_1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, Y, soma;

            N = int.Parse(Console.ReadLine());
            string[] valores;


            for (int i = 1; i <= N; i++)
            {
                valores = Console.ReadLine().Split(' ');
                X = int.Parse(valores[0]);
                Y = int.Parse(valores[1]);

                soma = 0;
                if (X < Y)
                {
                    for (int j = X + 1; j < Y; j++)
                    {
                        if (j % 2 != 0)
                        {
                            soma += j;
                        }
                    }
                }
                if (Y < X)
                {
                    for (int j = Y + 1; j < X; j++)
                    {
                        if (j % 2 != 0)
                        {
                            soma += j;
                        }
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}
