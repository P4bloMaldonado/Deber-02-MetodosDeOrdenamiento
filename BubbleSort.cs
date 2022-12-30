namespace Deber02_Ordenamiento;
class BubbleSort
{
    static void Main1(string[] args)
    {
        DateTime inicio = DateTime.Now;
        int[] A = { 50, 20, 40, 80, 30 };
        Console.WriteLine("Arreglo Desordenado");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(A[i] + ", ");
        }
        Burbuja(A, 5);
        Console.WriteLine("\nArreglo Ordenado");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(A[i] + ", ");
        }

        double tiempoEjecucion = DateTime.Now.Subtract(inicio).Milliseconds;
        Console.WriteLine("\nTiempo de Ejecucion: " + tiempoEjecucion + "ms");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

    }
    static void Burbuja(int[] A, int n)
    {
        int i, j;
        int auxiliar;
        for (i = 0; i < n - 1; i++)
        {             //n–1 pasadas
            for (j = 0; j < n - 1 - i; j++)
            { // burbujeo de datos
                if (A[j] > A[j + 1])
                {          //comparación de elementos contiguos para intercambio
                    auxiliar = A[j];
                    A[j] = A[j + 1];
                    A[j + 1] = auxiliar;
                }
            }
        }

    }
}
