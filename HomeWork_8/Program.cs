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
 Console.Write(" Введите воличество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите воличество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] randomMatrix = new int[row, col];

void matrix(int row, int col)
{
    int i, j;
    Random rand = new Random();
        for (i = 0; i < row; i++)
    {
        for (j = 0; j < col; j++)
        {
            randomMatrix[i, j] = rand.Next(11);
        }
    }
}
void PrintMayrix(int[,] matrix)
{
    int i, j;

    for (i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
matrix(row, col);
Console.WriteLine($"Исходный массив: ");
PrintMayrix(randomMatrix);
void sort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}
sort(randomMatrix);
Console.WriteLine($"Отсортированый массив: ");
PrintMayrix(randomMatrix);
