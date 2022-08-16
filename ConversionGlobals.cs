using System;

public static class Globals
{
    // Dominator.cpp: определяет точку входа для консольного приложения.
    //Из массива Х(N) все отрицательные элементы записать в массив Z(m). Удалить в каждом массиве первый элемент.

    internal static void Main()
	{
		setlocale(LC_ALL, "RUS");
		int i;
		int N;
		int m;
		int[] X = new int[100];
		int[] Z = new int[100];
		Console.Write("Количество элементов массива:\n");
		N = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		Console.Write("Массив X\n");
		for (i = 0; i < N; i++)
		{
			X[i] = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		}
		m = 0;
		for (i = 0; i < N; i++)
		{
			if (X[i] < 0)
			{
				Z[m++] = X[i];
			}
		}
		Console.Write("Массив Z:\n");
		for (i = 0; i < m; i++)
		{
			Console.Write(Z[i]);
			Console.Write(" ");
		}
		Console.Write("\n");
		for (i = 1; i < N - 1; i++)
		{
			X[i] = X[i + 1];
		}
		N--;
		Console.Write("Результирующий массив Х\n");
		for (i = 0; i < N; i++)
		{
			Console.Write(X[i]);
			Console.Write(" ");
		}
		Console.Write("\n");
		for (i = 1; i < m - 1; i++)
		{
			Z[i] = Z[i + 1];
		}
		m--;
		Console.Write("Результирующий массив Z\n");
		for (i = 0; i < m; i++)
		{
			Console.Write(Z[i]);
			Console.Write(" ");
		}
		Console.Write("\n");

	}
}