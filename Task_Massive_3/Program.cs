// Задайте двумерный массив c увеличением следующего элемента на "k".
//Напишите программу, которая меняет местами строки на столбцы.

void ChangeRowsAndCol(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i + 1; j <array. GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp; 
        }
    }
}
int[,]GetArray(int rows, int cols)
{
    int[,]array = new int[rows, cols];
    int k = 1;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = k++;
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
         Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,]array = GetArray(5,5);
PrintArray(array);
ChangeRowsAndCol(array); 
PrintArray(array);
