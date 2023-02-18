Console.WriteLine("Введите Певрое число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Второе число ");
int b = int.Parse(Console.ReadLine()!);
if (a % b == 0)
{
    Console.WriteLine($"{a}, {b} -> кратно");
}
else
{
    Console.WriteLine($"{a}, {b} -> не кратно, остаток {a % b} ");
}