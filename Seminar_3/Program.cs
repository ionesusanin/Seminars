// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите координаты по оси оX: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты по оси оY: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine($"Координаты находяться в первой четверити");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine($"Координаты находяться во второй четверити");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine($"Координаты находяться в третьей четверити");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine($"Координаты находяться в четвертой четверити");

}
else 
{
    Console.WriteLine($"Вы попали на одну из осей");
}