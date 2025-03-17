using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    class RelojDeArena
    {
        private int[,] matriz;
        private int n;

        public RelojDeArena(int tamaño)
        {
            if (tamaño % 2 == 0)
            {
                throw new ArgumentException("El tamaño debe ser un número impar.");
            }

            n = tamaño;
            matriz = new int[n, n];
            LlenarMatriz();
        }

        private void LlenarMatriz()
        {
            int valor = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = valor++;
                }
            }
        }

        public void MostrarMatrizCompleta()
        {
            Console.WriteLine("\nMATRIZ COMPLETA:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matriz[i, j],3} ");
                }
                Console.WriteLine();
            }
        }

        public void MostrarRelojDeArena()
        {
            Console.WriteLine("\nRELOJ DE ARENA:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                  
                    if (j >= i && j < n - i || j <= i && j >= n - 1 - i)
                    {
                        Console.Write($"{matriz[i, j],3} ");
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

