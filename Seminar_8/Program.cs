// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.
int[,] result = GetMatrix(3, 4, 0, 10);
// таьлица 3х4 с числами от 0 до 10 включительно
PrintMayrix(result);
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
void CangeRow(int[,] matr)
{
    int lastRowIndex = matr.GetLength(0) - 1;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        int temp = matr[0, i];
        matr[0, i] = matr[lastRowIndex, i];
        matr[lastRowIndex, i] = temp;
    }
}
Console.WriteLine($"Поменяли первую и последнюю строчку местами");
CangeRow(result);
PrintMayrix(result);