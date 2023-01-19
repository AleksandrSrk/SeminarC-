// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double number2 = Convert.ToDouble(Console.ReadLine());

if (number1 > number2) {
    
    Console.WriteLine($"max = {number1}, min = {number2}");
}
else {
    Console.WriteLine($"max = {number2}, min = {number1}");
}

// Как выполнить проверку на число? Что было введено число, а не строка?
