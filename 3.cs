using System;

public static class Globals
{
    //В массиве X=(x1,x2,…,xn) определить минимальный и максимальный элементы. Не упорядочивая массив, удалить из него элементы,
    //расположенные между максимальным и минимальным. 
    //
    internal static void Main()
    {
        int[] arr = new int[100];
        int amount;        
        Console.WriteLine("Введите количество элементов");
        int numb = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите массив X");
        for (amount = 0; amount < numb; amount++)
        {
            arr[amount] = int.Parse(Console.ReadLine());
        }
        int max;
        int min;
        int nmax;
        int nmin;
        max = arr[0];
        nmax = 0;
        min = arr[0];
        nmin = 0;

        for (amount = 1; amount < numb; amount++)
        {
            if (arr[amount] > max)
            {
                max = arr[amount];
                nmax = amount;
            }
        }

        for (amount = 1; amount < numb; amount++)
        {
            if (arr[amount] < min)
            {
                min = arr[amount];
                nmin = amount;
            }
        }
        int dig;
        for (dig = 1; dig <= nmax - nmin - 1; dig++)
        {
            for (amount = nmin + 1; amount <= numb - 2; amount++)
            {
                arr[amount] = arr[amount + 1];
            }
            numb--;
        }
        Console.Write("min=");
        Console.Write(min);
        Console.WriteLine(" ");
        Console.Write("max=");
        Console.Write(max);
        Console.WriteLine(" ");
        Console.WriteLine("Результирующий массив X");
        for (amount = 0; amount < numb; amount++)
        {
            Console.Write(arr[amount]);
            Console.Write("\t");
        }
        Console.WriteLine(" ");
        Console.ReadKey(true);
    }
