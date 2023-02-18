Console.Clear();
int num = new Random().Next(100, 1000); // num 25
int a1 = num / 10; // a1 =25 / 10 = 2
int cent = a1 % 10;
Console.WriteLine($"Средняя цифра числа {num} это {cent}");

