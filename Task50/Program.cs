/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого элемента в массиве нет */

Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of colomns: ");
int colomns = Convert.ToInt32(Console.ReadLine());


int[,] CreatMatrixRndInt(int rows, int colomns, int min, int max)
{
    int[,] matr = new int[rows, colomns];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max);
            
        }
        
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write(string.Empty);
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j], 3} ");
            else Console.Write($"{matr[i, j], 3}");
        }
        Console.WriteLine(string.Empty);
        
    }
}

void ValueOfElementInMatrix(int[,] matr, int row, int colomn)
{
    if (row <= matr.GetLength(0)-1 && colomns <= matr.GetLength(1)-1) 
    Console.WriteLine($"The value of this element: {row}, {colomns} -> {matr[row,colomns]}");
    else Console.WriteLine($"{row},{colomns} -> there is no such element in the matrix");
}

int[,] matrix2D = CreatMatrixRndInt(3, 4, 0, 9);
Console.WriteLine(string.Empty);
PrintMatrix(matrix2D);
Console.WriteLine(string.Empty);
if (rows < 0 || colomns < 0) Console.WriteLine("You entered a negative number");
else ValueOfElementInMatrix(matrix2D, rows, colomns);
