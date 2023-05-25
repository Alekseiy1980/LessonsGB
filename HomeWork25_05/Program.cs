//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

// int CountNumbersArray(int[] array)
// {
//    int count = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] > 0) count++;
//    }
//    return count;
// }
// int[] FillNumbersArray(int size)
// {
//    int[] array = new int[size];
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.Write($"Введите {i} значение :   ");
//       array[i] = Convert.ToInt32(Console.ReadLine());
//    }
//    return array;
// }

// Console.WriteLine("Введите размер массива :");
// int size = Convert.ToInt32(Console.ReadLine());
// int count = CountNumbersArray(FillNumbersArray(size));
// Console.WriteLine($" Пользователь ввел значений больше 0 => {count}");

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
   k1 * x + b1 = k2 * x + b2 
   x = (-b2 + b1) / (k2 - k1)
   y = k1 * x + b1
*/

void Сoordinates(double b1, double k1, double b2, double k2)
{
   double x = Convert.ToDouble((-b2 + b1) / (k2 - k1));
   double y = Convert.ToDouble(k1 * x + b1);
   Console.WriteLine($" -> ( {x} ; {y} )");
}

Console.WriteLine("Введите b1 : ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2 : ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1 : ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2 : ");
double k2 = Convert.ToInt32(Console.ReadLine());
Сoordinates(b1, k1, b2, k2);