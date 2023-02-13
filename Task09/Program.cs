// Программа выводит случайное число из отрезка 10 - 99, и показывает наибольшую цифру числа


int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {num}");

/*
int left = num % 10;
int right = num / 10;
if (left > right) {Console.WriteLine($"Наибольшая цифра числа => {left}");}
else {Console.WriteLine($"Наибольшая цифра числа => {right}");}
*/


// Решаем задачу через метод:

int maxDigit = MaxDigit(num);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");

int MaxDigit(int number)
{
    int left = number % 10;
    int right = number / 10;
    if (left > right) return left;
    else return right;
}

