using System;

public static class Globals
{
    //Написать программу, которая вводит по строкам с клавиатуры двумерный массив целого типа (3х5) и
    //вычисляет среднее арифметическое его элементов.
    //

    internal static void Main()
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
        int str;
        double str1;
        str = 0;
        str1 = 0F;
        for (length = 0; length < 3; length++)
        {
            for (height = 0; height < 5; height++)
            {
                str += TwoDimArr[length][height];
            }
        }
        str1 = str / 15.0;
        Console.Write("Среднее арифметическое= {0:f2}", str1);
        Console.ReadKey(true);
    }
}
