using System;

namespace Uri_1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 1, golInter, golGremio, vitoriasInter = 0, vitoriasGremio = 0, empates = 0, totalGrenais = 0;



            while (X == 1)
            {
                string[] list = Console.ReadLine().Split(' ');
                golInter = int.Parse(list[0]);
                golGremio = int.Parse(list[1]);

                if (golInter > golGremio)
                {
                    vitoriasInter++;
                }
                else if (golInter < golGremio)
                {
                    vitoriasGremio++;
                }
                else
                {
                    empates++;
                }
                totalGrenais++;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                X = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(totalGrenais + " grenais\n" +
                "Inter:" + vitoriasInter + "\n" +
                "Gremio:" + vitoriasGremio + "\n" +
                "Empates:" + empates);

            if (vitoriasInter > vitoriasGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitoriasInter < vitoriasGremio)
            {
                Console.WriteLine("Gremio venceu mais");
            }

        }
    }
}