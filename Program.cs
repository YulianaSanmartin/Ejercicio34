using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Ingrese orden de la matriz: ");
        n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("El orden de la matriz debe ser impar.");

            return;
        }

        int[,] matriz = new int[n, n];

      
        for (int i = 0; i < n; i++)
        {
            int valor = i * 2; 
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = valor++;
            }
        }

        Console.WriteLine("\nMATRIZ COMPLETA");
        MostrarMatriz(matriz, n);

        Console.WriteLine("\nRELOJ DE ARENA");
        MostrarRelojDeArena(matriz, n);
    }

    static void MostrarMatriz(int[,] matriz, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void MostrarRelojDeArena(int[,] matriz, int n)
    {
        int mitad = n / 2;

        for (int i = 0; i < n; i++) 
        {
            for (int j = 0; j < n; j++) 
            {
               
                if (i <= mitad && j >= i && j < n - i)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
               
                else if (i > mitad && j >= n - i - 1 && j <= i)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                else
                {
                    Console.Write("\t");
                }
            }
            Console.WriteLine();
        }
    }
}
