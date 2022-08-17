        internal static void Main()
        {


            int[] XArr = new int[100];
            int[] ZArr = new int[100];
            Console.WriteLine("Количество элементов массива:");
            int Numb = int.Parse(Console.ReadLine());
            Console.Write("Массив X\n");
            int length;
            for (length = 0; length < Numb; length++)
            {
                XArr[length] = int.Parse(Console.ReadLine());
            }
            int mass  = 0;
            for (length = 0; length < Numb; length++)
            {
                if (XArr[length] < 0)
                {
                    ZArr[mass++] = XArr[length];
                }
            }
            Console.WriteLine("Массив Z:");
            for (length = 0; length < mass; length++)
            {
                Console.Write(ZArr[length]);
                Console.Write(" ");
            }
            Console.WriteLine(" ");
            for (length = 1; length < Numb - 1; length++)
            {
                XArr[length] = XArr[length + 1];
            }
            Numb--;
            Console.WriteLine("Результирующий массив Х");
            for (length = 0; length < Numb; length++)
            {
                Console.Write(XArr[length]);
                Console.Write(" ");
            }
            Console.WriteLine(" ");
            for (length = 1; length < mass - 1; length++)
            {
                ZArr[length] = ZArr[length + 1];
            }
            mass--;
            Console.WriteLine("Результирующий массив Z");
            for (length = 0; length < mass; length++)
            {
                Console.Write(ZArr[length]);
                Console.Write(" ");
            }
            Console.WriteLine(" ");

        }
    }
