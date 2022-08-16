using System;

public static class Globals
{
    // Составить программу, которая выводит в табличном виде результат вычисления функций y1(x), y2(x) и y3(x),
    //где х изменяется от 0 до 360 градусов с шагом в 20 градусов.
    // Значения x в радианах выводить с точностью до 3 знаков после запятой, значения функций – до 4.
    //

    internal static void Main()
    {
        int i;
        int x;
        double xr;
        double y1;
        double y2;
        double y3;
        double pi = 3.14159265F;
        Console.Write("+-----------------------------------+\n");
        Console.Write("x,grad|x,rad| y1(x) | y2(x) | y3(x) |\n");
        Console.Write("+-----------------------------------+\n");
        for (i = 0; i <= 18; i++)
        {
            x = i * 20;
            xr = x * pi / 180;
            y1 = Math.Sin(xr) + (Math.Sin(3 * xr) / 3);
            y2 = y1 + (Math.Sin(5 * xr) / 5);
            y3 = y2 + (Math.Sin(7 * xr) / 7);
            Console.Write("|{0,3:D}  |{1,5:f3}|{2,7:f4}|{3,7:f4}|{4,7:f4}|\n", x, xr, y1, y2, y3);
        }
        Console.Write("+-----------------------------------+\n");
        Console.ReadKey(true);
    }


}
