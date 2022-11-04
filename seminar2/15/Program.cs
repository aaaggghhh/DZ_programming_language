// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите номер дня недели от 1 до 7: ");
int a = int.Parse(Console.ReadLine());

switch (a)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник"); break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Суббота - выходной"); break;
    case 7: Console.WriteLine("Воскресенье - выходной"); break;
}

if (a == 6)
{
    Console.WriteLine("ВЫХОДНОЙ!!!");
}
if (a == 7)
{
    Console.WriteLine("ВЫХОДНОЙ!!!");
}

