﻿/*Задача 63.При помощи рекурсии ввести на экран натуральные числа до N*/
using System;
using static System.Console;
void NaturalNumber (int LastNumber)
{
    Write($"{LastNumber} ");
    if (LastNumber>=2) NaturalNumber(LastNumber-1);
    WriteLine();
}
Clear();
NaturalNumber(10);