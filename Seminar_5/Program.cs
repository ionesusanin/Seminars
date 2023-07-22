// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

// int size = 12;
// int[] array = new int[size];
// int sumPositive = 0; // Сумма положительных чисел
// int sumNegative = 0; // Сумма отрицательных чисел

// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(-20,100);
//     if (array[i] > 0) // Если число в массиве положительное 
//     //то ищем сумму положительных чисел
//     {
//         sumPositive += array[i]; // 
//     }
//     else 
//     {
//         sumNegative += array[i];
//     }
// }
// Console.WriteLine($"Массив: [ {string.Join("; ", array)}] ");
// Console.WriteLine($"Сумма положительных чисел равна {sumPositive}");
// Console.WriteLine($"Сумма отрицательных чисел равна {sumNegative}");

// Методы
// void
// не void (+)

// Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


// Синтаксис метода: тип возвращаемого значания (int) ; 
// Имя метода (getArray);( Параметр1, Параметр2) (int size, int min, int max)
// size - размер массива, min - минимальное число в рандоме, max - максимальное
// int[] getArray(int size, int min, int max)
// {
//     int[] result = new int[size]; // массив на size  элементов
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max +1);
//     }
//     return result; //Массиа который заполнили числами от min до max 

// }
// int[] array = getArray(7, 0 ,10); // size = 7, min = 0;  max = 10
// Console.WriteLine($"Массив: [ {string.Join("; ", array)}] ");

// int [] reverseArray(int[] array) // Метод берет массив и заменяет элементы на противоположние
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//     array[i] *= -1;


//     }
//     return array;

// }
// Console.WriteLine($"Массив с перевернутыми элементами: {string.Join(";", reverseArray(array) )}");


// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int[] getArray(int size, int min, int max)
{
    int[] result = new int[size]; 
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max +1);
    }
    return result; 
}
int[] array = getArray(7, 0 ,10); 
Console.WriteLine($"Массив: [ {string.Join("; ", array)}] ");

// True - число есть, false - числа нет
bool findElement(int[] arr, int element)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == element);
        {
            return true; // элеменд найден
        }        
    }
    return false; // элемент не найден
}
int numberForSearch = 10;
if (findElement(array, numberForSearch))
{
    Console.WriteLine($"Элемент {numberForSearch} присутствует в массиве");
}
else
{
    Console.WriteLine($"Элемент {numberForSearch} отсутствует в массиве");
}