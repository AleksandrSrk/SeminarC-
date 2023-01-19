// Программа на вход принимает число Н а на выходе показывает все целые цисла в промежутке от Н до -Н
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int negativN = N * -1;

for (int i = 0; i<= N*2; i++){
    Console.Write($"{negativN}, ");
    negativN++;

}