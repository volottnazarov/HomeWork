// Программа, которая на вход принимает три числа, и выдает максимальное из этих чисел.
Console.WriteLine("Введите три числа:");
int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = Convert.ToInt32(Console.ReadLine());
int number_3 = Convert.ToInt32(Console.ReadLine());
int max = number_1;
if(number_2>max)
{
    max = number_2;
}
if(number_3>max)
{
    max = number_3;
}
Console.WriteLine("Максимальное число " + max);