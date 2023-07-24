// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// size - размер массива min - мин число в рандоме max - максимальное

// min = array[0]
// array < min
// min = array[i]


// int[] GetArray(int size, int min, int max)
// {
//     int[] array = new int[size]; //только нули
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
         
//     }
//     return array;

// }

// void PrintArray (int[] arr)
// {
//     Console.Write("[");
// //foreach(int item in arr)
// // {
// //     Console.Write(InvalidTimeZoneException + " ");
// // }
// // Цикл для перебора элементов массива
// // arr[i] = item
// // item = arr[0], arr[1], .......
    
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + "  "); // Расстояние между элементами массива в 1 Tab
//     }
    
//         Console.Write("]");
// }
// int[] result = GetArray(9, 0, 15);
// PrintArray(result);
// Console.WriteLine();
// PrintArray(CopyArray(result));
// // № 1 запись в новый массив
//  int[] CopyArray(int[] array)
//  {
//     int[] copyArray = new int[array.Length];
//     int size = array.Length;
//     //Start - 0 элемент, end -  конец исходного массива array
//     for (int start = 0, end = size - 1; start < size; start++, end--)
//     {
//         copyArray[start] = array[end];

//     }
//     return copyArray;
//  }
//  //№2 меняем элементы в текущем массиве
//   void ReverseArray(int[] array)
//   {
//     int size = array.Length;
//     for (int i = 0, j = size - 1; i < size / 2; i++, j--)
//         {
//             int temp = array[i];
//             array[i] = array[j];
//             array[j] = temp;
//         }
//   }
//   Console.WriteLine();
//   ReverseArray(result);
//   PrintArray(result);
   


// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.



// int a = 10;
// int b = 4;
// int c = 5;

// bool IsTriangle(int a, int b, int c)
// {
//    return ( ((a + b) > c) && ((b + c) > a) && ((a + c) > b));
// }
// Console.WriteLine(IsTriangle(a,b,c));

// if (IsTriangle(a ,b ,c))
// {
//     Console.WriteLine($"Треугольник существует");
// }
// else
// {
//     Console.WriteLine($"Треугольник Не существует");
// }


// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 2)
{
    return;
}
int[] fibonachi = new int[N];

fibonachi[0] = 0;
fibonachi[1] = 1;

for (int i = 2; i < N; i++)
{
    fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];
}
Console.WriteLine($"Массив: {string.Join("; ", fibonachi)}");