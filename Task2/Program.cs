/*Задача 65. M и N Все натуральные между N и M*/
using System;
using static System.Console;
string NaturalBetweenMN(int M, int N)
{
    if (N==M) return $"{M}";
    string s = NaturalBetweenMN(M,N-1) + "," + N.ToString();
    return s;
}
Clear();
WriteLine(NaturalBetweenMN(5,23));