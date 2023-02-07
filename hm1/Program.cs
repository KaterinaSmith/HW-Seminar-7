// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели некоректное число. Повторите ввод.");
        }

    }
    return result;
}

void InitMatrix(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(-99, 99)/10.0;
    }
}

}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int countOfRows = GetNumber($"Введите колличество строк:");
int countOfColumns = GetNumber($"Введите колличество столбцов:");

double[,] matrix = new double[countOfRows, countOfColumns];
InitMatrix(matrix);
PrintMatrix(matrix);