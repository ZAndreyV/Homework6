/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


int[,] CreatMatrixRndInt(int rows, int colomns, int min, int max)
{
    int[,] matr = new int[rows, colomns];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine(string.Empty);
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 2} ");
        }
    }
    Console.WriteLine(string.Empty);
}

double[] AveregeElementsInEachColumn(int[,] matr)
{
    double[] result = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
         double sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];
        }
        double sumAvr = Math.Round(sum/matr.GetLength(0),1);
        result[j] = sumAvr;
    }
    return result;
}

void PrintArray(double[] arr)
{
    Console.Write("Arithmetic mean of each column: ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + "; ");
        else Console.Write(arr[i]);   
    }
    Console.Write(".");
}

int[,] matrix2D = CreatMatrixRndInt(3, 4, 0, 9);
PrintMatrix(matrix2D);
Console.WriteLine(string.Empty);
double[] averegeElementsInEachColumn = AveregeElementsInEachColumn(matrix2D);
PrintArray(averegeElementsInEachColumn);

