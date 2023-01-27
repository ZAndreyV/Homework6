/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double[,] CreatMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matr = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            double num = rnd.NextDouble() * (max - min) + min;
            matr[i, j] = Math.Round(num, 1);
        }
        

    }
    return matr;
}

void PrintMatrixDouble(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j], 8};");
            else Console.Write($"{matr[i, j], 8} ");
        }
        Console.WriteLine(']');
    }
}


double[,] creatMatrixRndDouble = CreatMatrixRndDouble(3, 4, -10, 10);
PrintMatrixDouble(creatMatrixRndDouble);