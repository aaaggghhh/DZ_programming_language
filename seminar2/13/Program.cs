// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (n > 99){
   Console.WriteLine(n>99 ? n.ToString()[2] : '-');
}
else if (n < -99){
   Console.WriteLine(n<-99 ? n.ToString()[3] : '-');
}   
else{
   Console.WriteLine("Третьей цифры в данном числе нет");
}

