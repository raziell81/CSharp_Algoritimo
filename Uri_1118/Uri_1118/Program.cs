using System;
using System.Globalization;

namespace Uri_1118
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 1, count;
            double nota1, nota2, media, total;


            while (X == 1)
            {
                count = 0;
                total = 0;

                while (count < 2)
                {
                    nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (nota1 < 0.0 || nota1 > 10.0)
                    {
                        Console.WriteLine("nota invalida");
                    }
                    else
                    {
                        count++;
                        total = total + nota1;
                    }

                    while (count < 2)
                    {
                        nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        if (nota2 < 0.0 || nota2 > 10.0)
                        {
                            Console.WriteLine("nota invalida");
                        }
                        else
                        {
                            count++;
                            total = total + nota2;
                        }

                    }
                    media = (double)total / 2.0;
                    Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    X = int.Parse(Console.ReadLine());
                    while (X != 1 && X != 2)
                    {
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        X = int.Parse(Console.ReadLine());
                    }
                }
            }

        }
    }
}