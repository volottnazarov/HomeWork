// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.
int Promt(string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine()!;
    int result = int.Parse(readInput);
    return result;
}
int SumDigit(int number)
{
    int sum = 0;
    while(number>0)
    {
        sum = sum + number%10;
        number = number/10;
    }
    return sum;
}
int number = Promt("Введите число: ");
Console.WriteLine(SumDigit(number));
