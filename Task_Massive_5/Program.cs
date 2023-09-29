// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

int[,]GetArray(int rows, int cols, int minValue, int maxValue)
{
    int[,]array = new int[rows, cols];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,]array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
         Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void SumInLines(int[,] array)
{
    int[] sumInLines = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {  
            sumInLines[i] += array[i, j];
        }
    }
    int minPosition= 0;
    for (int i = 0; i < sumInLines.Length; i++)
    {
        if (sumInLines[minPosition] > sumInLines[i])
         minPosition = i;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minPosition + 1}");  
}

int[,]array = GetArray(4,3,1,10);
PrintArray(array);
SumInLines(array);