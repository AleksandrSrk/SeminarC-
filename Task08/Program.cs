// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите положительное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    for (int i = 1; i <= number; i++)
    {
        if(i%2 ==0){
            System.Console.Write($"{i}, ");
        }
      
    }
} else {
    System.Console.WriteLine("ОШИБКА!!! Нужно ввести положительное целое число");
}