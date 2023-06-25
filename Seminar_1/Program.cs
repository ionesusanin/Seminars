// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49
// тип данных имя = значение
// Console.Write("Введите число: ");
// double number = Convert.ToDouble(Console.ReadLine()); // в переменной number  хранится число 5

// double result = number * number;

// Console.WriteLine("Квадрат числа " + number + " равен: " + result); // "2"+"3" = "23" Конкатенация или процесс сложения строк
// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет
// camelCase
// "=" - присваивание "==" - проверка на равенство
Console.Write("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine()); 
if (firstDigit == secondDigit*secondDigit)
{
    Console.WriteLine("Число " + firstDigit + " является квадратом от числа " + secondDigit);
}
else // все остальные случаи
{
    Console.WriteLine("Число " + firstDigit + " НЕ является квадратом от числа " + secondDigit);
}