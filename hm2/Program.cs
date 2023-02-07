// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int countOfRows = ReadInt("Введите индекс строки: ");
int countOfColumns = ReadInt("Введите индекс столбца: ");
int[,] matrix = new int[8, 8];
InitMatrix(matrix);
PrintMatrix(matrix);

if (countOfRows < matrix.GetLength(0) && countOfColumns < matrix.GetLength(1)) 
{
    Console.WriteLine(matrix[countOfRows, countOfColumns]);
}
else 
{
    Console.WriteLine($"Такого числа нет в массиве");
}

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

