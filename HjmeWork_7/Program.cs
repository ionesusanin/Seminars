// Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Write(" Введите воличество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Введите воличество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[, ] randomArray = new double[m, n];
// void mas (int m, int n)
// {
//     int i, j;
//     Random rand = new Random();
//     for (i = 0; i < m; i++)
//     {
//         Console.WriteLine();
//         for (j = 0; j < n; j++)
//         {
//         randomArray[i, j] = rand.NextDouble();
//         Console.Write($"{randomArray[i, j]: F2}");
//         }
//     }
// }
// mas(m, n);

// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



// Console.Write("Введите размерность m массива: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размерность n массива: ");
// int col = Convert.ToInt32(Console.ReadLine());
// double[,] randomArray = new double[row,col];
// Console.Write("Введите позицию строки: ");
// int row2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию столбца: ");
// int col2 = Convert.ToInt32(Console.ReadLine());
// void mas(int row, int col)
// {
//     int i,j;
//     Random rand = new Random();
//     for (i = 0; i < row; i++)
//         {
//             Console.WriteLine();
//             for (j = 0; j < col; j++)
// {
// randomArray[i,j] = rand.NextDouble();
// Console.Write($"{randomArray[i,j]:F2} ");
// }
//             Console.WriteLine();
//         }
// }
// mas(row,col);

// if (row2 <= row+1 && col2 <= col+1)
// Console.Write($"Значение элемента равно {randomArray[row2-1,col2-1]:F2} ");
// else Console.Write("Такого элемента нет в массиве");


// Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// ср арифм 0 столбца: (1+5+8)/3=4,6
int row = 3;
int col = 3;
int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
            Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
    }

// for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          double rowSum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             rowSum += matrix[i, j];
            
//     }
//     Console.WriteLine($"Сумма элементов строчки {i} = {Math.Round(rowSum / matrix.GetLength(1),2)}");
//     }
for (int i = 0; i < matrix.GetLength(1); i++)
    {
         double colSum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            colSum += matrix[j, i];
            
    }
    Console.WriteLine($"Сумма элементов столбце {i} = {Math.Round(colSum / matrix.GetLength(0),2)}");
    }
