﻿// Программа, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2==0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число не является четным");
}
