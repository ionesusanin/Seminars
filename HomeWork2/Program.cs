// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1



// int randomNumber = new Random().Next(100, 1000); //100-1000 включительно
// int result = (randomNumber % 100) / 10;

// Console.WriteLine($"в числе {randomNumber} -> {result}");



// Напишите программу, которая выводит третью цифру заданного числа 
 // или сообщает, что третьей цифры нет. До 10 символов
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int Length = number.ToString().Length;
// if (Length >= 3)
// {
//     while (number > 999)
//     {
//         number = number / 10;
//     }
//     int result = number % 10;
//     Console.WriteLine($"Третья цифра это {result}");
// }
// else
// {
//     Console.WriteLine($"Третьей цифры нет");
// }


//  Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 5)
{
    Console.WriteLine($"Это будний день");
}
if (number >= 6 && number < 8)
{
Console.WriteLine($"Это выходной день");
}
else
{
    Console.WriteLine($"неверный параметр");
}