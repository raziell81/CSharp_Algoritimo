using System;
using System.Globalization;

namespace Uri_1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0, total = 0, count = 0;
            double media;

            idade = int.Parse(Console.ReadLine());

            while (idade >= 0)
            {
                count++;
                total += idade;
                idade = int.Parse(Console.ReadLine());
            }
            media = (double)total / (double)count;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}