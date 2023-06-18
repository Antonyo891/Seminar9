/*Задача 67. Вернуть сумму цифр числа. Рекурсия*/
using System;
using static System.Console;
int Enter(string n)
{
    System.Console.WriteLine(n);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int SumNumbers (int Numbers)
{
    if (Numbers/10==0) return Numbers;
    int Sum = Numbers%10+SumNumbers(Numbers/10);
    return Sum;
}
Clear();
int n = Enter("Введите число");
WriteLine($"Сумма цифр чисел ={SumNumbers(n)}");