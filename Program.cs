// // //Задача 1. Задайте двумерный массив размером m×n,
// // //заполненный случайными целыми числами.

// // int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
// // {
// //    int[,] array = new int[rows, colums];
// //    for (int i = 0; i < rows; i++)
// //    {
// //       for (int j = 0; j < colums; j++)
// //       {
// //          array[i, j] = new Random().Next(minValue, maxValue);
// //       }
// //    }
// //    return array;
// // }

// // void Print2DArray(int[,] array)
// // {
// //    for (int i = 0; i < array.GetLength(0); i++)
// //    {
// //       for (int j = 0; j < array.GetLength(1); j++)
// //       {
// //          Console.Write(array[i, j] + " ");
// //       }
// //       Console.WriteLine();
// //    }
// // }

// // Console.WriteLine("Inpyt rows - ");
// // int rows = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Inpyt colums - ");
// // int colums = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Inpyt minValue - ");
// // int minValue = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Inpyt maxValue - ");
// // int maxValue = Convert.ToInt32(Console.ReadLine());
// // Print2DArray(Create2DRandomArray(rows, colums, minValue, maxValue));

// //Задача 4. задайте двумерный массив. 
// //Найдите сумму элементов, находящихся на
// //главной диагонали (с индексами (0,0); 
// //(1;1) и т.д.

// int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
// {
//    int[,] array = new int[rows, colums];
//    for (int i = 0; i < rows; i++)
//    {
//       for (int j = 0; j < colums; j++)
//       {
//          array[i, j] = new Random().Next(minValue, maxValue);
//       }
//    }
//    return array;
// }

// void Print2DArray(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          Console.Write(array[i, j] + " ");
//       }
//       Console.WriteLine();
//    }
// }

// int SumOfMainDiag(int[,] array)
// {
//    int sum = 0;
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          if (i == j)
//          {
//             sum += array[i, j];
//          }

//       }
//    }
//    return sum;
// }
// Console.WriteLine("Inpyt rows - ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Inpyt colums - ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Inpyt minValue - ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Inpyt maxValue - ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2DRandomArray(colums, minValue, maxValue);
// Print2DArray(array);
// Console.WriteLine(SumOfMainDiag(array));


//Задача 3.Задайте двумерный массив. Найдите элементы,
//у которых оба индекса чётные, и замените эти 
//элементы на их квадраты.
//Задача 2. ****Задайте двумерный массив размера m 
//на n, каждый элемент в массиве находится по формуле: 
//Aₘₙ = m+n.

int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
{
   int[,] array = new int[rows, colums];
   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < colums; j++)
      {
         array[i, j] = new Random().Next(minValue, maxValue);
      }
   }
   return array;
}

void Print2DArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write(array[i, j] + " ");
      }
      Console.WriteLine();
   }
}

int[,] Chet(int[,] array)
{

   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (i % 2 == 0 && j % 2 == 0)
         {
            array[i, j] = array[i, j] * array[i, j];
         }
      }
   }
   return array;
}

Console.WriteLine("Inpyt rows - ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpyt colums - ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpyt minValue - ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpyt maxValue - ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2DRandomArray(rows, colums, minValue, maxValue);

Print2DArray(array);
Console.WriteLine();
Print2DArray(Chet(array));
