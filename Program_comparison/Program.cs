// Программа , которая на входе получает два числа, и выдает какое число больше , какое меньше.
Console.WriteLine("Введите два числа:");
int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = Convert.ToInt32(Console.ReadLine());
if(number_1==number_2)
{
    Console.WriteLine("Значения чисел одинаковые");
}
if(number_1>number_2)
{
    Console.WriteLine("Первое число является наибольшим");
    Console.WriteLine("Соответственно второе - наименьшим.");
}
if(number_1<number_2)
{
    
    Console.WriteLine("Второе число является наибольшим");
    Console.WriteLine("Соответственно первое - наименьшим."); 
}


    