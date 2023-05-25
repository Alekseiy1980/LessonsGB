// // string[,] table = new string[2, 5];

// // table[1, 2] = "слово";
// // for (int rows = 0; rows < 2; rows++)
// // {
// //    for (int cols = 0; cols < 5; cols++)
// //    {
// //       Console.WriteLine($"-{table[rows, cols]}-");
// //    }
// // } 
// int[,] matrix = new int[3, 4];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//       matrix[i, j] = new Random().Next(0, 10);
//    }
// }

// for (int i = 0; i < 3; i++)
// {
//    for (int j = 0; j < 4; j++)
//    {
//       Console.Write($"-{matrix[i, j]}-");
//    }
//    Console.WriteLine();
// }

// int Factorial(int n)
// {
//    if (n == 1) return 1;
//    else return n * Factorial(n - 1);
// }
// Console.WriteLine(Factorial(5));

// int Fibonacci(int n)
// {
//    if (n == 1 || n == 2) return 1;
//    else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }

// for (int i = 1; i < 40; i++)
// {
//    Console.WriteLine($"{i} => {Fibonacci(i)}");
// }

