// Задача 14 
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine()!);
if (a % 7 ==0 || a % 23 ==0)
{
Console.WriteLine($"{a} Кратно 7 или 23");
}
else
{
    Console.WriteLine($"{a} Не кратно 7 или 23");
}