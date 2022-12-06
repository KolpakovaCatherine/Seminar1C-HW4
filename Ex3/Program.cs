/*
Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.
5 -> [1, 2, 5, 7, 19] 
3 -> [6, 1, 33]*/

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers, 0, 10);
WriteArray(numbers);


void FillArrayRandomNumbers(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void WriteArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.WriteLine($"{array[i]}]");
        }

    }
}
