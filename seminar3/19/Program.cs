// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int a = number.Length;

if (a == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - число является палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - число не является палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}