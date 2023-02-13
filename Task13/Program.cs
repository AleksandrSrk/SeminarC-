/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int lengthNumber = LengthNumber(num);
int arrayNumber = ArrayNumber(lengthNumber);


int LengthNumber(int number)
{

    int length = 0;
    while (number != 0)
    {
        number = number / 10;
        length++;
    }

    return length;

}

int ArrayNumber(int length)
{
    int[] arr = new int[length];

    if (num > 99)
    {
        for (int i = length - 1; i >= 0; i--)
        {
            arr[i] = num % 10;
            num = num / 10;
        }

        Console.WriteLine(arr[2]);
    }

    else { Console.WriteLine("Третьей цифры нет"); }
    return 1;
}
