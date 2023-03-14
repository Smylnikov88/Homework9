// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int start = 1;
Concequense(N, start);
// for (int i = 1; i <= N; i++)
// {
// Console.Write($"{i} ");
// }

void Concequense(int number, int start)
{
if (start <= number)
{
Console.Write($"{start} ");
Concequense(number, start + 1);
}
}