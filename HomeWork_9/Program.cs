// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// string PrintNumbers(int M, int N)
// {
//     if (M == N) return M.ToString();
//     return M +  ", " + PrintNumbers(M + 1, N);
    
// }
// Console.WriteLine($"Числа от {M} до {N}: {PrintNumbers(M, N)}");


// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine()); 

int SumNumbers(int M, int n)
{
    if (M == N) return N;
    return M + SumNumbers(M + 1, N);

}
Console.WriteLine($"Сумма элементов от {M} до {N} равно {SumNumbers(M, N)}");