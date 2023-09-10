//  Программа, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
int AWeek(string message)
{
    Console.Write(message);
    string day = Console.ReadLine()!;
    int number_day = Convert.ToInt32(day);
    return number_day;
}
int WeekEnd(int number)
{
    if(number<6)
    {
        Console.WriteLine("Будний день");
    }
    else
    {
        Console.WriteLine("Выходной день");
    }
    return number;
}
int number = AWeek("Введите номер дня недели от 1 до 7: ");
WeekEnd(number);
