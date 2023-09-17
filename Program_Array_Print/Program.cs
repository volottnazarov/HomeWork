// Программа, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
int Promt(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine()!;
    int result = int.Parse(ReadInput);
    return result;
}
int[]ArrayGenerate(int Length, int minValue, int maxValue)
{
    int[]array = new int[Length];
    Random random = new Random();
    for(int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
        return array;
}        
void PrintArray(int[]array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.Write("]");

}
int length = Promt("Введите длинну массива (по заданию число 8): ");
int max = Promt("Введите максимальное значение диапазона массива: ");
int min = Promt("Введите минимальное значение диапазона массива: ");
int[]array = ArrayGenerate(length, min, max);
PrintArray(array);

//else
//{
  //  Console.WriteLine("Ошибка! Введите число согласно заданию.");
//}