﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3_djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            double d1, d2, Al, B, b, h, At, r, Ac;

            int form = 1;
            do
            {
                Console.WriteLine("Digite o número da figura que deseja saber a área de 1 a 3: ");
                Console.WriteLine(" 1- Losango\n 2- Trapezio\n 3- Circulo\n ");
                form = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (form)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Área do Losango\n");
                            Console.Write("Digite a valor da primera diagonal:  ");
                            d1 = double.Parse(Console.ReadLine());
                            Console.Write("Digite a valor da segunda diagonal:  ");
                            d2 = double.Parse(Console.ReadLine());

                            Al = (d1 * d2) / 2;

                            Console.WriteLine("\nArea = " + Al);
                            Console.Write("\nDeseja refazer ? Digite 1 para sim ou 0 para não:  ");
                            op = int.Parse(Console.ReadLine());
                            Console.Clear();

                        } while (op == 1);
                        break;

                    case 2:
                        do
                        {
                            Console.WriteLine("Área do Trapézio\n");
                            Console.Write("Digite a valor da base maior: ");
                            B = double.Parse(Console.ReadLine());
                            Console.Write("Digite a valor da base menor: ");
                            b = double.Parse(Console.ReadLine());
                            Console.Write("Digite a valor da altura: ");
                            h = double.Parse(Console.ReadLine());

                            At = ((B + b) / 2) * h;
                            Console.WriteLine("\nArea = " + At);

                            Console.Write("\nDeseja refazer? Digite 1 para sim ou 0 para não:  ");
                            op = int.Parse(Console.ReadLine());
                            Console.Clear();
                        } while (op == 1);
                        break;

                    case 3:
                        do
                        {
                            Console.WriteLine("Área do circulo\n");
                            Console.Write("Digite o valor do Raio Do circulo: ");
                            r = double.Parse(Console.ReadLine());

                            Ac = 3.1415 * r * r;
                            Console.WriteLine("\nArea = " + Ac);

                            Console.Write("\nDeseja refazer ? Digite 1 para sim ou 0 para não:  ");
                            op = int.Parse(Console.ReadLine());
                            Console.Clear();
                        } while (op == 1);
                        break;

                }


            } while (true);
        }
    }
}
