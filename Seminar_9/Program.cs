// Рекурсия - это вызов функции внутри функции

// String SayHello()
// {
//     SayHello();
//     return "Hi";
// }
// SayHello();
// int Factorial (int n)
// {
//     // Базовый случай? когда надо выйти из рекурсии
//     if (n == 1) return 1; // попадание в return - завершении функции

//     // Рекурсивный случай
// return n * Factorial(n - 1);
// }
//  Console.WriteLine(Factorial(4));
//  Console.WriteLine(Factorial(15));


// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
// Факториал - N

// Console.WriteLine("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return start + "," + PrintNumbers(start + 1, end);
    
// }
// Console.WriteLine($"Числа от 1 до {n}: {PrintNumbers(1, n)}");


// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumNumbers(num / 10);

}
Console.WriteLine($"Сумма цифр числа {number}: {SumNumbers(number)}");