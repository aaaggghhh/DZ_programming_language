// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
int[] CreateArray(int size)
{
	int[] array = new int[size];
        Console.Write("Массив [");
    	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]}  ");
	}
    Console.Write("]");
    return array;
	}

int SummElements(int[] array)
{
	int sum = 0;

	for (int i = 0; i < array.Length; i++)
	{
			if (i % 2 == 1 && i!=0)
				sum = sum + array[i];
			else 
			    sum = sum;
	}

	return sum;
}


int[] array = CreateArray(5);
Console.WriteLine();
Console.WriteLine($"Cумма значений элементов на нечетных позициях: " + (SummElements(array)));

