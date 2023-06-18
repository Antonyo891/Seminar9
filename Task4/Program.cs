/* **Задача 69:**Напишите программу,
которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.

A = 3; B = 5-> 243(3⁵)

A = 2; B = 3-> 8*/
using System;
using static System.Console;
int Exponentiation (int Number, int Power)
{
    if (Power==1) return Number;
    int result =Number*Exponentiation(Number, Power-1);
    WriteLine ($"result ={result}, Power = {Power}");
    return result;
}
Clear();
WriteLine(Exponentiation(3,5));