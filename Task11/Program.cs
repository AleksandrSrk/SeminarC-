// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
int randomNumber = new Random().Next(100, 1000);
System.Console.WriteLine(randomNumber);

int finishNumber = GetNumber(randomNumber);
System.Console.WriteLine(finishNumber);

int GetNumber(int number)
{
    int left = number % 10;
    int right = number / 100;
    int result = right * 10 + left;
    return result;
}

