// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// 

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int InputNumber()
// {
//     int num = new Random().Next(4, 5);
//     return num;
// }
// void CraeteArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         Console.Write($"Строка {i + 1}: ");
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void SerchRowSmallestSum(int[,] arr)
// {
//     int sum = 0, min = 0, index = 1;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             sum = 0;
//             for (int k = 0; k < arr.GetLength(1); k++)
//             {
//                 sum += arr[i, k];
//             }
//             if (sum < min || min == 0)
//             {
//                 min = sum;
//                 index = i;
//             }
//         }
//     }
//     Console.WriteLine($"Строка {index + 1} имеет наименьшую сумму = {min}");
// }

// int row = InputNumber(), colums = InputNumber();
// int[,] array = new int[row, colums];
// CraeteArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// SerchRowSmallestSum(array);


// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int InputNumber()
// {
//     int num = new Random().Next(2, 2);
//     return num;
// }
// void CraeteArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void MatrixProduct(int[,] matrixA, int[,] matrixB, int[,] matrixC)
// {
//     int result = 0;
//     for (int i = 0; i < matrixA.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixB.GetLength(1); j++)
//         {
//             result = 0;
//             for (int k = 0; k < matrixA.GetLength(1); k++)
//             {
//                 result += matrixA[i, k] * matrixB[k, j];
//             }
//             matrixC[i, j] = result;
//         }
//     }
// }
// int iA = InputNumber(), jA = InputNumber();
// int iB = InputNumber(), jB = InputNumber();
// int[,] matrixA = new int[iA, jA];
// int[,] matrixB = new int[iB, jB];
// int[,] newMatrixC = new int[iA, jB];
// if (jA == iB)
// {
// Console.WriteLine("Матрица А:");
// CraeteArray(matrixA);
// PrintArray(matrixA);
// Console.WriteLine("Матрица В:");
// CraeteArray(matrixB);
// PrintArray(matrixB);
// MatrixProduct(matrixA, matrixB, newMatrixC);
//     Console.WriteLine("Матрица C:");
//     PrintArray(newMatrixC);
// }
// else Console.WriteLine("Умножить нельзя");

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int InputNumber()
{
    int num = new Random().Next(4, 4);
    return num;
}
void CraeteArray(int[,] arr)
{
    int num = 1, i = 0, j = 0, temp = 0, sizeRow = arr.GetLength(0), sizeColom = arr.GetLength(1);
    while (num <= arr.GetLength(0) * arr.GetLength(1))
    {
        for (i = temp; i < sizeColom; i++)
        {
            arr[j, i] = num++;
        }
        j = sizeColom - 1;
        for (i = temp + 1; i < sizeRow; i++)
        {
            arr[i, j] = num++;
        }
        j = sizeRow - 1;
        for (i = sizeColom - 2; i >= temp && temp != sizeRow - 1; i--)
        {
            arr[j, i] = num++;
        }
        j = temp;
        for (i = sizeRow - 2; i > temp && temp != sizeColom - 1; i--)
        {
            arr[i, j] = num++;
        }
        sizeColom--;
        sizeRow--;
        temp++;
        j = temp;
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int row = InputNumber(), colums = InputNumber();
int[,] array = new int[row, colums];
CraeteArray(array);
PrintArray(array);