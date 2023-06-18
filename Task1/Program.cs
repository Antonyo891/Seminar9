/*Задача 63.При помощи рекурсии ввести на экран натуральные числа до N*/
using System;
using static System.Console;
string NaturalNumber (int LastNumber)
{
    if (LastNumber==1)
    {
         //WriteLine(1);
         return $"{M}";}
    string s = NaturalNumber(LastNumber-1) + ", " + LastNumber.ToString();
        //WriteLine(s);
        return s;
}
Clear();
WriteLine(NaturalNumber(10));