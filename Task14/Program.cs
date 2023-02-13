// Программа принимает на вход число и проверяет кратно ли оно одновременно 7 и 23
Console.WriteLine("Введите целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

bool result = Multiplicity(number1);

/*if (result)
{
    System.Console.WriteLine("ДА");
}
else System.Console.WriteLine("НЕТ");*/

Console.WriteLine(result ? "да" : "нет");

bool Multiplicity(int num)
{
    return (num % 7 == 0 && num % 23 == 0);
}