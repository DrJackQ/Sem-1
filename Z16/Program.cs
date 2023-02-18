// Задача 16 Напишите программу, которая принимает на вход 2 числа
// и проверяет, является ли одно число квадратом другого.


Console.WriteLine("Введите Первое число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Второе число ");
int b = int.Parse(Console.ReadLine()!);
if (a*a ==b || b*b ==a )
{
Console.WriteLine("да, является");
}
else
{
 Console.WriteLine("нет, не я вляется ");
}