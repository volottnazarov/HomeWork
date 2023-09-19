// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int[]GenerateArray(int length, int minValue, int maxValue)
{
    int[]array = new int [length];
    Random random = new Random();
    for( int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue);
    }
    return array;
}
int SumOddPosition(int[]array)
{
    int sum = 0;
    
    for(int i = 1; i < array.Length; i++)
    
    if(i%2 > 0)
        sum += array[i];
    return sum;
}
void PrintArray(int[]array)
{
    Console.Write("[");
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}
int length = 4;
int[]massive = GenerateArray(length,10,100);
PrintArray(massive);
SumOddPosition(massive);
Console.Write($" -> " + SumOddPosition(massive));

