﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Введите a");
string astring = Console.ReadLine ();
int a = Convert.ToInt32(astring) ;
int count = 1;
while (count<=a)
{
    if (count%2 == 0)
    {
        Console.WriteLine (count);
    }
count++;
}