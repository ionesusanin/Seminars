﻿// int number = 4;
// void ConvertToBinary(int number)
// {
//     if (number == 0)
//     {
//         return;
        
//     }
//     ConvertToBinary(number / 2);
//     Console.Write(number % 2);

// }
//    ConvertToBinary(number);

// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.Write(" Введите воличество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Введите воличество столбцов: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// int minRandom = 0;
// int maxRandom = 10;

// int[,] array2D = GetMatrix(rows, colums, minRandom, maxRandom);
// //Создается таблица из ows строчкек и colums столбцов
// // int[x] - массив одномерный; int [x,y] - двумерный массив; int[x,y,z] -трехмерный
// //Матрица - прямок=уголная таблица размером m (сторочки) на n (столбики)
// PrintMayrix (array2D);
// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;

// }
// void PrintMayrix (int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }


// 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// Console.Write(" Введите воличество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Введите воличество столбцов: ");
// int colums = Convert.ToInt32(Console.ReadLine());


// int[,] array2D = GetMatrix(rows, colums);
// PrintMayrix (array2D);
// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = i + j;
//         }
//     }
//     return matrix;

// }
// void PrintMayrix (int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
 


//  Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

Console.Write(" Введите воличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите воличество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
int minRandom = 0;
int maxRandom = 10;

int[,] array2D = GetMatrix(rows, colums, minRandom, maxRandom);
Console.WriteLine("Исхлдный массив: ");
PrintMayrix (array2D);
int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;

}
void PrintMayrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            // if (i % 2 == 0 && j % 2 ==0)
            // {
            matrix[i, j] *= matrix[i, j];

            // }
        }
    }
    return matrix;
}
// Без сохранения результата
Console.WriteLine("результат: ");
PrintMayrix(ChangeMatrix(array2D));

//так результат сохраняется в change2DArray, его с помощью PrintMayrix и печатаем
// int[,] change2DArray = ChangeMatrix(array2D);
//  PrintMayrix(ChangeMatrix(change2DArray));