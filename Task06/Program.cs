﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2==0)
{
    System.Console.WriteLine("ДА");
} else {
    System.Console.WriteLine("НЕТ");
}