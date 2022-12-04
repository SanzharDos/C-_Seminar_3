// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

void Count(double xa, double xb, double ya, double yb)
{
double num1 = Math.Pow((xb - xa), 2);
double num2 = Math.Pow((yb - ya), 2);
double result = Math.Sqrt(num1 + num2);
Console.WriteLine($"Расстояние между координатами А({xa}; {ya}) и В({xb}; {yb}) составляет = {result}");
}

try
{
    Console.WriteLine("Введите значение по X координаты A");
    double xa = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение по Y координаты A");
    double ya = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение по X координаты B");
    double xb = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение по Y координаты B");
    double yb = Convert.ToDouble(Console.ReadLine());
    Count(xa, xb, ya, yb);
}

catch
{
    Console.WriteLine("Надо ввести число!");
}