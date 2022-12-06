/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Без использования функции Math.Pow.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int a = ReadInt("Введите число А: ");
int b = ReadInt("Введите число B: ");


int multiplication = 1;

for (int i = 1; i <= b; i++)
{
    multiplication *= a;
}

Console.WriteLine($"A в степени B = {multiplication}");;

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}