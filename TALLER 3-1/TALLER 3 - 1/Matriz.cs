using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3
{
    public class Matriz
    {
        private int[,] datos;
        private int orden;

        public Matriz(int n)
        {
            orden = n;
            datos = new int[n, n];
            LlenarMatriz();
        }

        private void LlenarMatriz()
        {
            for (int i = 0; i < orden; i++)
            {
                for (int j = 0; j < orden; j++)
                {
                    datos[i, j] = i + j;
                }
            }
        }

        public void MostrarMatriz()
        {
            Console.WriteLine("\nMatriz completa:");
            for (int i = 0; i < orden; i++)
            {
                for (int j = 0; j < orden; j++)
                {
                    Console.Write($"{datos[i, j],3} ");
                }
                Console.WriteLine();
            }
        }

        public void MostrarTriangularInferior()
        {
            Console.WriteLine("\nTriangular inferior:");
            for (int i = 0; i < orden; i++)
            {
                for (int j = 0; j < orden; j++)
                {
                    if (j <= i)
                        Console.Write($"{datos[i, j],3} ");
                    else
                        Console.Write("    ");
                }
                Console.WriteLine();
            }
        }
    }
}