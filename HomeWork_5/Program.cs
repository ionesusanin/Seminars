// Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[size];
void mas(int size)
{
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(100, 1000);
        Console.WriteLine(randomArray[i] + "");
    }
}
int kol(int[] randomArray)
{
    int kol = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] % 2 == 0)
        {
            kol = kol + 1;
        }
    }
    return kol;
}
mas(size);
Console.WriteLine($"Количество четных чисел в массиве: {kol(randomArray)}");