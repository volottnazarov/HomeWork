// Задайте двумерный массив.Напишите программу, которая поменяет первую 
//и последнюю строки массива местами.

void ChangeTwoLine(int[,]array, int line1, int line2)
{
    int n = array.GetLength(0);
    for (int col = 0; col < array.GetLength(0); col++)
    {
        int temp = array[line1,col];
        array[line1,col] = array[line2,col];
        array[line2,col] = temp; 
    }
}

int[,]GetArray(int rows, int cols)
{
    int[,]array = new int[rows, cols];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i * j;
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
int[,]array = GetArray(5,5);
PrintArray(array);
ChangeTwoLine(array,0,4); //цыфры означают какие номера строк заменить местами
PrintArray(array);