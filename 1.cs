using System;

public static class Globals
{
    // Составить программу, которая выводит в табличном виде результат вычисления функций y1(x), y2(x) и y3(x),
    //где х изменяется от 0 до 360 градусов с шагом в 20 градусов.
    // Значения x в радианах выводить с точностью до 3 знаков после запятой, значения функций – до 4.
    //

    internal static void Main()
    {
        int cons;
        Console.WriteLine("+-----------------------------------+");
        Console.WriteLine("x,grad|x,rad| y1(x) | y2(x) | y3(x) |");
        Console.WriteLine("+-----------------------------------+");
        for (cons = 0; cons <= 18; cons++)
        {
            int grad;
            double rad;
            double y1;
            double y2;
            double y3;
            double pi = 3.14159265F;
            grad = cons * 20;
            rad = grad * pi / 180;
            y1 = Math.Sin(rad) + (Math.Sin(3 * rad) / 3);
            y2 = y1 + (Math.Sin(5 * rad) / 5);
            y3 = y2 + (Math.Sin(7 * rad) / 7);
            Console.WriteLine("|{0,3:D}  |{1,5:f3}|{2,7:f4}|{3,7:f4}|{4,7:f4}|", grad, rad, y1, y2, y3);
        }
        Console.WriteLine("+-----------------------------------+");
        Console.ReadKey(true);
    }


}
