﻿// ЗАДАЧА 01 Является ли первое число квадратом второго

Console.WriteLine("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int square = number2 * number2;
if (number1 == square) {
    Console.WriteLine("Да");
}
else {
    Console.WriteLine("Нет");
}