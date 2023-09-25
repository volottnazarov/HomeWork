
        // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
        //0, 7, 8, -2, -2 -> 2.
        int Promt(string message)
        {
            Console.Write(message);
            string ReadInput = Console.ReadLine()!;
            int result = Convert.ToInt32(ReadInput);
            return result;
        }
        int SumPositive(int[] array)
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum ++;
                }       
            }
            return sum;
        }
        int[]InputArray(int length)
        {
            int[]array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Promt($"Введите элемент массива :{i} > ");
            }
            return array;
        }
        void PrintArray(int[] array)
        {
            Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("]");
        }
        int length = Promt("Введите длинну массива: ");
        int[] array;
        array = InputArray(length);
        PrintArray(array);
        Console.WriteLine($"Количество элементов больше нуля : {SumPositive(array)}");