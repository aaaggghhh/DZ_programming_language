﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());

int result = (a % 100) / 10 ;

Console.WriteLine($"Вторая цифра данного числа: {result}");