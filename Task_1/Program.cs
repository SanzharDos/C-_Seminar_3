// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void CheckKoord(int x, int y) // создали функцию CheckKoord - ЧекниКоординаты
{
    if (x > 0 && y > 0) Console.WriteLine("Это четверть №1");
    else if (x < 0 && y > 0) Console.WriteLine("Это четверть №2");
    else if (x < 0 && y < 0) Console.WriteLine("Это четверть №3");
    else if (x > 0 && y < 0) Console.WriteLine("Это четверть №4");
    else Console.WriteLine("Точка находится на координатной оси");
}

try // попробуй сделать это
{
    Console.WriteLine("Введите координату X");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату Y");
    int y = Convert.ToInt32(Console.ReadLine());
    CheckKoord(x, y);
}

catch // если не получилось, сделай это
{
    Console.WriteLine("Надо было вводить целые числа!");
}
