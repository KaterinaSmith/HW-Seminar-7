// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int countOfRows = ReadInt($"Введите колличество строк:");
int countOfColumns = ReadInt($"Введите колличество столбцов:");

int[,] matrix = new int[countOfRows, countOfColumns];
InitMatrix(matrix);
PrintMatrix(matrix);

void InitMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i=0; i < matrix.GetLength(0); i++)
    {
        for (int j=0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] average = new double[matrix.GetLength(1)];

for (int i = 0; i < matrix.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        result += matrix[j, i];
    }
    average[i] = result / matrix.GetLength(0);
}
PrintM(average);

void PrintM (double[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write($"{matrix[i]} ");
    }
    Console.WriteLine();
}