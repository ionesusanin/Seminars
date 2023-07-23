// Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] randomArray = new int[size];
// void mas(int size)
// {
//     for (int i = 0; i < size; i++)
//     {
//         randomArray[i] = new Random().Next(100, 1000);
//         Console.WriteLine(randomArray[i] + "");
//     }
// }
// int kol(int[] randomArray)
// {
//     int kol = 0;
//     for (int i = 0; i < randomArray.Length; i++)
//     {
//         if (randomArray[i] % 2 == 0)
//         {
//             kol = kol + 1;
//         }
//     }
//     return kol;
// }
// mas(size);
// Console.WriteLine($"Количество четных чисел в массиве: {kol(randomArray)}");


// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[size];
void mas(int size)
{
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(1, 20);
        Console.WriteLine(randomArray[i] + "");
    }
}

int kol(int[] randomArray)
{
    int sum = 0;
    int i = 0;
    while (i < randomArray.Length)
    {
        sum += randomArray[i];
        i += 2;
    }
    return sum;
}
mas (size);
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях в массиве [ {string.Join("; ", randomArray)}]:  равна {kol(randomArray)}");