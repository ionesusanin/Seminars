﻿// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = 1;

for (int i = 1; i<= numberB; i++)
{
    numberC = numberC * numberA;

}
Console.WriteLine($"Число А в степени В равно { numberC}");