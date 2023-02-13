// Прорамма принимает на вход два числа и проверяет является ли одно число квадратом другого

Console.WriteLine("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = Square(number1, number2);

/*if (result)
{
    System.Console.WriteLine("ДА");
}
else System.Console.WriteLine("НЕТ");*/

Console.WriteLine(result ? "да" : "нет");

bool Square(int a, int b)
{
    return (a == b * b || b == a * a);
}

// ДЗ - в 13 задаче через строки исключаем сразу, снижение оценки. Отсекаем до тех пор, пока число не станет трехзначнымчерез цикл. Можно рандомом число вводить
// задача 15 - решаем через методы. можно через булево.