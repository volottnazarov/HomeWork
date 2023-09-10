// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число:");
bool MinValue(int number)
{
    if (number<100)
    {
        Console.WriteLine("В введенном числе нет третьей цыфры");
         Console.WriteLine("Введите число больше 99:");
         return false;
    }
    return true;
}
int number = Convert.ToInt32(Console.ReadLine());
int ThreeNumberPosition(int number)
{
    while(number>999)
    {
        number = number/10;
    }
return number%10;
}
if(MinValue(number))
{
    Console.WriteLine("Третья цифра введенного числа:" + ThreeNumberPosition(number));
}

