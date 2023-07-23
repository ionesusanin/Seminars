﻿// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// size - размер массива min - мин число в рандоме max - максимальное

// min = array[0]
// array < min
// min = array[i]


int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size]; //только нули
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
         
    }
    return array;

}

void PrintArray (int[] arr)
{
    Console.Write("[");
//foreach(int item in arr)
// {
//     Console.Write(InvalidTimeZoneException + " ");
// }
// Цикл для перебора элементов массива
// arr[i] = item
// item = arr[0], arr[1], .......
    
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "  "); // Расстояние между элементами массива в 1 Tab
    }
    
        Console.Write("]");
}
int[] result = GetArray(9, 0, 15);
PrintArray(result);
Console.WriteLine();
PrintArray(CopyArray(result));
// № 1 запись в новый массив
 int[] CopyArray(int[] array)
 {
    int[] copyArray = new int[array.Length];
    int size = array.Length;
    //Start - 0 элемент, end -  конец исходного массива array
    for (int start = 0, end = size - 1; start < size; start++, end--)
    {
        copyArray[start] = array[end];

    }
    return copyArray;
 }
 //№2