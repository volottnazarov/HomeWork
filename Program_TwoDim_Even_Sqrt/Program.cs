// Задаем двумерный массив. Ищем элементы у которых оба индекса четные, 
// заменяем эти элементы на их квадраты.
int[,]GetArray(int rows, int cols,int minValue, int maxValue)
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
    Console.WriteLine();
}   
void EvenSqr(int[,]array)
{
    for(int i = 0; i < array.GetLength(0); i = i + 2)
    {
        for(int j = 0; j < array.GetLength(1); j = j + 2)
        {
            array[i,j] = array[i,j] * array[i,j];
           // Console.Write(array[i,j] + " ");
        }
     }
}   
int [,]arr = GetArray(3,4,1,9);
PrintArray(arr);
EvenSqr(arr);
PrintArray(arr);
