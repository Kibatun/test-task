using System;

public static class Globals
{
    //Написать программу, которая вводит по строкам с клавиатуры двумерный массив целого типа (3х5) и
    //вычисляет среднее арифметическое его элементов.
    //

    internal static void Main()
    {
        int[][] x =
        {
            new int[5],
            new int[5],
            new int[5]
        };
        int i;
        int j;
        int s;
        double s1;
        s = 0;
        s1 = 0F;
        Console.Write("Введите массив X: \n");
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 5; j++)
            {
                string tempVar = Console.ReadLine();
                if (tempVar != null)
                {
                    x[i][j] = int.Parse(tempVar);
                }
            }
        }
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 5; j++)
            {
                s += x[i][j];
            }
        }
        s1 = s / 15.0;
        Console.Write("Среднее арифметическое= {0:f2}", s1);
        Console.ReadKey(true);
    }
}
