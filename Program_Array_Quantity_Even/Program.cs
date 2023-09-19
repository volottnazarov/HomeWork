//  Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
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
int QuantityEven(int[]array)
{
    int sumEven = 0;
    
    for(int i = 0; i < array.Length; i++)
    
    if(array[i]%2 == 0)
        sumEven += 1;
    return sumEven;
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
int[]massive = GenerateArray(length,100,1000);
PrintArray(massive);
QuantityEven(massive);
Console.Write($" -> " + QuantityEven(massive));

