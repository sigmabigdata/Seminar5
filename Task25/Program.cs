﻿/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int a = new Random().Next(1, 10);
int b = new Random().Next(1, 10);
int result = 1;
for (int i = 1; i <= b; i++)
{

    result = a * result;

}





Console.WriteLine($"{a} в степени {b} = {result}");
