namespace Deber02_Ordenamiento;
class BOrdenamientoQuickSortModificado
{
    static void Main7(string[] args)
    {
        DateTime inicio = DateTime.Now;
        int[] A = { 79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24 };


        Console.WriteLine("Arreglo Desordenado");
        for (int i = 0; i < 12; i++)
        {
            Console.Write(A[i] + ", ");
        }
        Console.WriteLine("\nComienza Ordenamiento QuickSort");
        QuickSort(A, 0, A.Length - 1);

        Console.WriteLine("\nArreglo Ordenado");
        for (int i = 0; i < 12; i++)
        {
            Console.Write(A[i] + ", ");
        }

        double tiempoEjecucion = DateTime.Now.Subtract(inicio).Milliseconds;
        Console.WriteLine("\nTiempo de Ejecucion: " + tiempoEjecucion + "ms");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

    }
    static void QuickSort(int[] a, int primero, int ultimo)
    {
        int i, j, central;
        int pivote;
        central = (primero + ultimo) / 2;
        pivote = a[central];
        i = primero;
        j = ultimo;
        do
        {
            while (a[i] < pivote) i++;
            while (a[j] > pivote) j--;
            if (i <= j)
            {
                int tmp;
                tmp = a[i];
                a[i] = a[j];
                a[j] = tmp; /* intercambia a[i] con a[j] */
                i++;
                j--;
                for (int k = 0; k < 12; k++)
                {
                    Console.Write(a[k] + " ");
                }
                    Console.WriteLine("");
            }
        } while (i <= j);
        if (primero < j)
            QuickSort(a, primero, j); /* mismo proceso con sublista izquierda */
        if (i < ultimo)
            QuickSort(a, i, ultimo); /* mismo proceso con sublista derecha */


    }

}
