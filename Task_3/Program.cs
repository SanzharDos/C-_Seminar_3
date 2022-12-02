// Задача №18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void CheckKoord(int num)
{
    if (num == 1) Console.WriteLine($"В {num} четверти - x > 0 и y > 0");
    else if (num == 2) Console.WriteLine($"В {num} четверти - x < 0 и y > 0");
    else if (num == 3) Console.WriteLine($"В {num} четверти - x < 0 и y < 0");
    else if (num == 4) Console.WriteLine($"В {num} четверти - x > 0 и y < 0");
    else Console.WriteLine($"Четверти {num} нет на двумерном графике координат");
}

try
{
Console.WriteLine("Введите номер четверти, от 1 до 4");
int num = Convert.ToInt32(Console.ReadLine());
CheckKoord(num);
}

catch
{
    Console.WriteLine("Нужно ввести целое число от 1-го до 4-х!!");
}