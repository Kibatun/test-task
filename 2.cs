using System;

public static class Globals
{
    //Написать программу, которая вводит по строкам с клавиатуры двумерный массив целого типа (3х5) и
    //вычисляет среднее арифметическое его элементов.
    //

    internal static void Main()
    {
        Table();
    }
    public static void Table()
    {
        int[][] TwoDimArr =
       {
            new int[5],
            new int[5],
            new int[5]
        };
        Console.WriteLine("Введите массив X:");
        int length;
        int height;
        for (length = 0; length < 3; length++)
        {
            for (height = 0; height < 5; height++)
            {
                string tempVar = Console.ReadLine();
                if (tempVar != null)
                {
                    TwoDimArr[length][height] = int.Parse(tempVar);
                }
            }
        }
        int sum = 0;
        double ArithmAver = 0F;
        for (length = 0; length < 3; length++)
        {
            for (height = 0; height < 5; height++)
            {
                sum += TwoDimArr[length][height];
            }
        }
        ArithmAver = sum / 15.0;
        Console.Write("Среднее арифметическое= {0:f2}", ArithmAver);
        Console.ReadKey(true);
    }
}
