// //Задача 2.Напишите программу, 
// //которая принимает на вход число и 
// //выдаёт количество цифр в числе.
// int DigitCount(int value)
// {
//    int count = 0;
//    while (value > 0)
//    {
//       count++;
//       value /= 10;
//    }
//    return count;
// }

// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(DigitCount(num));


// //Задача 4. Напишите программу, которая выводит
// //массив из 8 элементов, заполненный нулями и 
// //единицами в случайном порядке.

// // [1,0,1,1,0,1,0,0]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//    int[] array = new int[size];
//    for (int i = 0; i < size; i++)
//    {
//       array[i] = new Random().Next(minValue, maxValue + 1);
//    }
//    return array;
// }

// void PrintArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.Write(array[i] + " ");
//    }
// }

// Console.Write("Введите размер массива : ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите нижний диапазон : ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите вверхний диапазон : ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[] arr = CreateRandomArray(size, minValue, maxValue);
// PrintArray(arr);

//Задача 3. Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.

//4  -> 24
//5  -> 120
// int Factorial(int num)
// {
//    int result = 1;
//    for (int i = 1; i <= num; i++)
//    {
//       result *= i;
//    }
//    return result;
// }

// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Factorial(num));


//Задача 1. Напишите программу, которая принимает на вход 
//число (А) и выдаёт сумму чисел от 1 до А.

int SumNum(int A)
{
   int result = 0;
   for (int i = 1; i < A; i++)
   {
      result += i;
   }
   return result;
}

int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNum(num));