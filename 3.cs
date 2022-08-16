using System;

public static class Globals
{
    //В массиве X=(x1,x2,…,xn) определить минимальный и максимальный элементы. Не упорядочивая массив, удалить из него элементы,
    //расположенные между максимальным и минимальным. 
    //
    internal static void Main()
    {
        int[] X = new int[100];
        int i;
        int n;
        int j;
        int max;
        int min;
        int nmax;
        int nmin;
        Console.Write("Введите количество элементов\n");
        int numb = int.Parse(Console.ReadLine());
        Console.Write("Введите массив X\n");
        for (i = 0; i < numb; i++)
        {
            X[i] = int.Parse(Console.ReadLine());
        }
        max = X[0];
        nmax = 0;
        min = X[0];
        nmin = 0;

        for (i = 1; i < numb; i++)
        {
            if (X[i] > max)
            {
                max = X[i];
                nmax = i;
            }
        }

        for (i = 1; i < numb; i++)
        {
            if (X[i] < min)
            {
                min = X[i];
                nmin = i;
            }
        }

        for (j = 1; j <= nmax - nmin - 1; j++)
        {
            for (i = nmin + 1; i <= numb - 2; i++)
            {
                X[i] = X[i + 1];
            }
            numb--;
        }
        Console.Write("min=");
        Console.Write(min);
        Console.Write("\n");
        Console.Write("max=");
        Console.Write(max);
        Console.Write("\n");
        Console.Write("Результирующий массив X\n");
        for (i = 0; i < numb; i++)
        {
            Console.Write(X[i]);
            Console.Write("\t");
        }
        Console.Write("\n");
        Console.ReadKey(true);
    }
}
