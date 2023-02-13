// Принимает на вход два числа и выводит, является ли первое число кратным второму. Если не кратно, то выводит остаток от деления
Console.WriteLine("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

/*
if (number1 % number2 == 0)
{
    System.Console.WriteLine($"{number1} кратно {number2}");
} else {
    System.Console.WriteLine($"Не кратно, остаток {number1 % number2}");
}
*/

// Способ группы

int remains = MultipleNum(number1, number2);

int MultipleNum(int num1, int num2){
    return num1 % num2;
}

if (remains ==0)
{
    System.Console.WriteLine("кратно");
} else {
    System.Console.WriteLine($"Не кратно,{remains}");
}