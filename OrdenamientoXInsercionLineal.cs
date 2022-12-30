namespace Deber02_Ordenamiento;
class OrdenamientoXInsercionLineal
{
    static void Main5(string[] args)
    {
        DateTime inicio = DateTime.Now;
        int[] A = { 14, 9, 16, 1, 13, 17 };
        Console.WriteLine("Arreglo Desordenado");
        for (int i = 0; i < 6; i++)
        {
            Console.Write(A[i] + " ");
        }
        Insercionlineal(A, 6);
        Console.WriteLine("\nArreglo Ordenado por Insercion Lienal: ");
        for (int i = 0; i < 6; i++)
        {
            Console.Write(A[i] + ", ");
        }

        double tiempoEjecucion = DateTime.Now.Subtract(inicio).Milliseconds;
        Console.WriteLine("\nTiempo de Ejecucion: " + tiempoEjecucion + "ms");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

    }
    static void Insercionlineal(int[] A, int n)
    {
        int i, j;
        bool encontrado;
        int auxiliar;
        for (i = 1; i < n; i++)
        { // A[0], A[1], ..., A[i-1] está ordenado
            auxiliar = A[i];
            j = i - 1;
            encontrado = false;
            while ((j >= 0) && !encontrado)
            {
                if (A[j] > auxiliar)
                { // se mueve dato hacia la derecha para la inserción
                    A[j + 1] = A[j];
                    j--;
                }
                else
                {
                    encontrado = true;
                }
            }
            A[j + 1] = auxiliar;
        }

    }
}