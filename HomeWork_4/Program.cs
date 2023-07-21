// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.

// Console.WriteLine("Введите число А: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// int numberC = 1;

// for (int i = 1; i<= numberB; i++)
// {
//     numberC = numberC * numberA;

// }
// Console.WriteLine($"Число А в степени В равно { numberC}");

// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите чичло: ");

int a = Convert.ToInt32(Console.ReadLine());
int len = Length(a);
int Length(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}
int sum = 0;
int Sum(int a, int len)
{
    for (int i = 1; i <= len; i++)
    {
        sum += a % 10;
        a /= 10;
    }
    return sum;
}
Console.Write($"Сумма цифр в числе {a} равна: {Sum(a,len)}");
