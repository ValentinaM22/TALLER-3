using _34;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el orden de la matriz (impar): ");
        int n = int.Parse(Console.ReadLine());

        try
        {
            RelojDeArena reloj = new RelojDeArena(n);
            reloj.MostrarMatrizCompleta();
            reloj.MostrarRelojDeArena();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
