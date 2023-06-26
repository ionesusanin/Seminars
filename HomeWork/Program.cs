// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine()); 
// if (firstNumber > secondNumber)
// {
//     Console.WriteLine("Число " + firstNumber + " больше числа " + secondNumber);
// }
// else // все остальные случаи
// {
//      Console.WriteLine("Число " + firstNumber + " меньше числа " + secondNumber);
// }
//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a < b) max = b;
if (b < c) max = c;
Console.WriteLine("Максимальное число " + max);