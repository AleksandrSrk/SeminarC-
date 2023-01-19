// ЗАДАЧА 03 Выдавать название недели по заданному номеру

Console.WriteLine("Введите номер дня недели от 1 до 7: ");
string numberWeek = Console.ReadLine();

if (numberWeek == "1") { Console.WriteLine($"Номер {numberWeek} соответствует Понедельнику"); }
else if (numberWeek == "2") { Console.WriteLine($"Номер {numberWeek} соответствует Вторнику"); }
else if (numberWeek == "3") { Console.WriteLine($"Номер {numberWeek} соответствует Среде"); }
else if (numberWeek == "4") { Console.WriteLine($"Номер {numberWeek} соответствует Четвергу"); }
else if (numberWeek == "5") { Console.WriteLine($"Номер {numberWeek} соответствует Пятнице"); }
else if (numberWeek == "6") { Console.WriteLine($"Номер {numberWeek} соответствует Субботе"); }
else if (numberWeek == "7") { Console.WriteLine($"Номер {numberWeek} соответствует Воскресению"); }
else { Console.WriteLine("ОШИБКА!!! Нужно ввести номер дня недели от 1 до 7!"); }


// Вариант решения задачи через свич кейс:

switch (numberWeek)
{
    case "1":
        Console.WriteLine($"Номер {numberWeek} соответствует Понедельнику");
        break;
    case "2":
        Console.WriteLine($"Номер {numberWeek} соответствует Вторнику");
        break;
    case "3":
        Console.WriteLine($"Номер {numberWeek} соответствует Среде");
        break;
    case "4":
        Console.WriteLine($"Номер {numberWeek} соответствует Четвергу");
        break;
    case "5":
        Console.WriteLine($"Номер {numberWeek} соответствует Пятнице");
        break;
    case "6":
        Console.WriteLine($"Номер {numberWeek} соответствует Субботе");
        break;
    case "7":
        Console.WriteLine($"Номер {numberWeek} соответствует Воскресению");
        break;
    default:
        Console.WriteLine("ОШИБКА!!! Нужно ввести номер дня недели от 1 до 7!");
        break;
}