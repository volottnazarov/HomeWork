// Программа, которая на вход принимает число N, а на выходе показывает
// все четные числа от 1 до N.
Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int number = 1;
while(number<N)
{
    if(number%2 == 0)
    {
        Console.WriteLine(number);
    }
number = number + 1 ;
}
