// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления)

int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число => {num}");

int secondNumber = SecondNumber(num);
Console.WriteLine($"Вторая цифра из заданного числа => {secondNumber}");

int SecondNumber (int number) {
    return number = (number/10)%10;
}
