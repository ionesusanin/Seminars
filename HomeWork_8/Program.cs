//  Задайте двумерный массив. Напишите программу, 
//  которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


//  Console.Write(" Введите воличество строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Введите воличество столбцов: ");
// int col = Convert.ToInt32(Console.ReadLine());

// int[,] randomMatrix = new int[row, col];

// void matrix(int row, int col)
// {
//     int i, j;
//     Random rand = new Random();
//         for (i = 0; i < row; i++)
//     {
//         for (j = 0; j < col; j++)
//         {
//             randomMatrix[i, j] = rand.Next(11);
//         }
//     }
// }
// void PrintMayrix(int[,] matrix)
// {
//     int i, j;

//     for (i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// matrix(row, col);
// Console.WriteLine($"Исходный массив: ");
// PrintMayrix(randomMatrix);
// void sort(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//             {
//                 if (matrix[i, k] < matrix[i, k + 1])
//                 {
                    
//                     int temp = matrix[i, k + 1];
//                     matrix[i, k + 1] = matrix[i, k];
//                     matrix[i, k] = temp;
//                 }
//             }
//         }
//     }
// }
// sort(randomMatrix);
// Console.WriteLine($"Отсортированый массив: ");
// PrintMayrix(randomMatrix);


// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

//  Console.Write(" Введите воличество строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Введите воличество столбцов: ");
// int col = Convert.ToInt32(Console.ReadLine());

// int[,] randomMatrix = new int[row, col];

// void matrix(int row, int col)
// {
//     int i, j;
//     Random rand = new Random();
//         for (i = 0; i < row; i++)
//     {
//         for (j = 0; j < col; j++)
//         {
//             randomMatrix[i, j] = rand.Next(10);

//         }
//     }
// }
// void PrintMayrix(int[,] matrix)
// {
//     int i, j;

//     for (i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// matrix(row, col);
// Console.WriteLine($"Исходный массив: ");
// PrintMayrix(randomMatrix);
// int SumString (int[,] matrix, int i)
// {
//     int sum = matrix[i, 0];
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         sum += matrix[i, j];
//     }
//     return sum;
// }
// int minSum = 1;
// int sum = SumString(randomMatrix, 0);
// for (int i = 0; i < randomMatrix.GetLength(0); i++)
// {
//     if (sum > SumString(randomMatrix, i))
//     {
//         sum = SumString(randomMatrix, i);
//         minSum = i + 1;
//     }
// }
// Console.WriteLine($"Строчка с наименьшей суммой элементов: {minSum}");


//  Задайте две матрицы. Напишите программу, 
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateMatrix (int row, int col, int deep, int min, int max)
{
    int[,,] matrix = new int[row, col, deep];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for ( int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rand.Next(min, max + 1);
            }
        }
    }
    return matrix;
}
void PrintMayrix (int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for ( int k = 0; k < matrix.GetLength(2); k++)
            {
                 Console.Write(matrix[i, j, k] + "\t");

            }
        }        
        Console.WriteLine();
    }
}
int[,,] matrix3D = CreateMatrix(2,2,2,10,99);
PrintMayrix(matrix3D);
