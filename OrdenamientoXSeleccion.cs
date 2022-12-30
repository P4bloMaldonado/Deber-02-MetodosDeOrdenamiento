namespace Deber02_Ordenamiento;
class OrdenamientoXSeleccion
{
    static void Main4(string[] args)
    {
        DateTime inicio = DateTime.Now;
        int[] A = { 51, 21, 39, 80, 36 };
        Console.WriteLine("Arreglo Desordenado");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(A[i] + ", ");
        }
        Seleccion(A, 5);
        Console.WriteLine("\nArreglo Ordenado por Seleccion");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(A[i] + ", ");
        }

        double tiempoEjecucion = DateTime.Now.Subtract(inicio).Milliseconds;
        Console.WriteLine("\nTiempo de Ejecucion: " + tiempoEjecucion + "ms");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

    }
    static void Seleccion(int[] A, int n)
    {
        int i, j, indiceMenor;
        int auxiliar;
        for (i = 0; i < n - 1; i++)
        {
            indiceMenor = i; // posición del menor
            for (j = i + 1; j < n; j++)
            {
                if (A[j] < A[indiceMenor])
                {
                    indiceMenor = j; // nueva posición del menor
                }
            }
            auxiliar = A[indiceMenor]; // intercambia posiciones
            A[indiceMenor] = A[i];
            A[i] = auxiliar;
        }

    }
}
