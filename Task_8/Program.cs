﻿/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Clear();

string str;
int number;

Console.Write("Enter the number : ");
str = Console.ReadLine();
number = Convert.ToInt32(str);

int count = 2;

while (count <= number)
{
    if (count % 2 == 0)
    {
        Console.Write(count + ", ");
    }
    count++;
}
