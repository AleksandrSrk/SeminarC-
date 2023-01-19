// Программа принимает на вход трехзначное число и на выходе показывает последнюю цифру числа
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000){
    Console.Write(number = number%10);
}
else {
    Console.Write("Ошибка!!! Нужно ввести трехзначное число!");
}
