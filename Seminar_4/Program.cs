﻿// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите число: ");
// int limit = Convert.ToInt32(Console.ReadLine()); // Получили число А
// int sum = 0; // суммы изначально нет
// for (int i = 1; i <= limit; i++)
// {
//     sum += i; // sum = sum + i
    
// }
// Console.WriteLine($"Сумма чисел от 1 до {limit} = {sum }");

// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int copyNumber = number;
// int count = 0; // Количество чисел
// if (number != 0)
// {
//     while (number > 0)
//     {
//          count++; // Обнаружена 1 цифра, count = count + 1
//          number /= 10; // number = number / 10

//     }
// }

// else
// {
//     count++;
// }
// Console.WriteLine($"В числе {copyNumber} {count} цифр");

// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

//  Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine()); // Получили число N
// int result = 1; // Умножив на 0 Старания пропадут
// for (int i = 1; i <= N; i++)
// {
//      result *= i; // result = result * i
    
// }
// Console.WriteLine($"Факториал числа {N} = {result }");

// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]



int[] randomArray = new int[8]; 
//Изначально массив заполнен нулями
// array.Length = size - Длина массива array = size
for (int i = 1; i < array.Length; i++)
{
    // array[i] = new Random().Next(0,2)
    //  Next(2) - НАчинаем с 0 и идем до 2: 0,1 ; тк по 
    // условию массив состоит из 0 и 1
    array[i] = new Random().Next(1000);
    // Console.Write(array[i] + " ");

}
 // Массив печатается в цикле - способ №1 (66 строчка)
 // Способ №2 без цикла
 Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");


