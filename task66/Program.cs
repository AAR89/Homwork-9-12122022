// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = m;
int temp2 = n;

if (m > n)
{
    m = n;
    n = temp;
    temp2 = n;
}

PrintSumm(m, n, temp = 0, temp2);

void PrintSumm(int m, int n, int summ, int temp2)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов от {m} до {temp2} -> {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ, temp2);
}
