// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

// Console.WriteLine("Введите координаты по оси оX: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты по оси оY: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine($"Координаты находяться в первой четверити");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine($"Координаты находяться во второй четверити");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine($"Координаты находяться в третьей четверити");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine($"Координаты находяться в четвертой четверити");

// }
// else 
// {
//     Console.WriteLine($"Вы попали на одну из осей");
// }



// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// AB = корень (x1 - x2)2 + (y1 - y2)2


// Console.WriteLine("Введите координаты по оси оХ для первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты по оси оY для первой точки: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты по оси оХ для второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты по оси оY для второй точки: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// // Math.Sqrt(Число) = Math.Sqrt(25) = 5
// // Math.Pow(Число, степень) =  Math.Pow(2,3) = 8
// // Math.Round(Число, количество знаков) = Math.Round(1,254478, 2) = 1,25

// Double d = Math.Round(Math.Sqrt( Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 2);
// Console.WriteLine($"Расстояние: {d}");

// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int start = 1;
Console.WriteLine("Введите число: ");

int end = Convert.ToInt32(Console.ReadLine());

while (start <= end)
{
    Console.Write(Math.Pow(start, 2) + " ");
    start++; // start = start + 1 - инкремент
}
