using System;

public static class Globals
{
    //Из массива Х(N) все отрицательные элементы записать в массив Z(m).
    //Удалить в каждом массиве первый элемент.
    //

    internal static void Main()
    {
        int i;
        int N;
        int m;
        int[] X = new int[100];
        int[] Z = new int[100];
        Console.WriteLine("Количество элементов массива:");
        int Numb = int.Parse(Console.ReadLine());
        Console.Write("Массив X\n");
        for (i = 0; i < Numb; i++)
        {
            X[i] = int.Parse(Console.ReadLine());
        }
        m = 0;
        for (i = 0; i < Numb; i++)
        {
            if (X[i] < 0)
            {
                Z[m++] = X[i];
            }
        }
        Console.WriteLine("Массив Z:");
        for (i = 0; i < m; i++)
        {
            Console.Write(Z[i]);
            Console.Write(" ");
        }
        Console.Write("\n");
        for (i = 1; i < Numb - 1; i++)
        {
            X[i] = X[i + 1];
        }
        Numb--;
        Console.WriteLine("Результирующий массив Х");
        for (i = 0; i < Numb; i++)
        {
            Console.Write(X[i]);
            Console.Write(" ");
        }
        Console.WriteLine(" ");
        for (i = 1; i < m - 1; i++)
        {
            Z[i] = Z[i + 1];
        }
        m--;
        Console.WriteLine("Результирующий массив Z");
        for (i = 0; i < m; i++)
        {
            Console.Write(Z[i]);
            Console.Write(" ");
        }
        Console.WriteLine(" ");

    }
}
