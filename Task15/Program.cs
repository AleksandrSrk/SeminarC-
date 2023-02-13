//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите целое число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

int weekendDay = WeekendDay(num);

int WeekendDay(int numDay)
{

    if (numDay > 5 && numDay < 8)
    {
        Console.WriteLine("Да");
    }
    else if (numDay < 6 && numDay > 0)
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Ошибка!!! Нужно ввести целое число от 1 до 7");
    }

    return 1;
}