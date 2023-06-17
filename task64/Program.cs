// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные/четные** числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int number = Prompt("Введите число: ");

Elements(number);

int Prompt(string num)
{
    Console.Write(num);
    int n = int.Parse(Console.ReadLine()!);
    return Elements(n);
}

int Elements(int num)
{
    if (num < 1)
    {
        return 0;

    }

    if (num % 2 == 0)
    {
        Console.Write($"{num} ");
    }

    return Elements(num = num - 1);
}
