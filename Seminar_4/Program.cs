// Напишите программу, которая
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

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int copyNumber = number;
int count = 0; // Количество чисел
if (number != 0)
{
    while (number > 0)
    {
         count++; // Обнаружена 1 цифра, count = count + 1
         number /= 10; // number = number / 10

    }
}

else
{
    count++;
}
Console.WriteLine($"В числе {copyNumber} {count} цифр");