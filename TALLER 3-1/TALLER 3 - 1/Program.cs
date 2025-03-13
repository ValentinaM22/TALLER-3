using System;

namespace Taller3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese orden de la matriz: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            Matriz matriz = new Matriz(n);

            matriz.MostrarMatriz();
            matriz.MostrarTriangularInferior();
        }
    }
}