// Задача 11 Напишите программу, которая вводит случайное
// трехзначное число и удаляет вторую цифру этого числа.

int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a2 = num % 10; 
Console.WriteLine($"Первое и последнее число от числа {num} это {a1}{a2}");

