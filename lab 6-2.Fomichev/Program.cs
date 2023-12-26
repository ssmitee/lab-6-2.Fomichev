using System;

namespace MatrixLibrary
{
    public class MatrixOperations
    {
        public static double CalculateSumOfMinMax(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            double min = double.MaxValue;
            double max = double.MinValue;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] < min)
                        min = matrix[i, j];

                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                }
            }

            double sum = min + max;

            return sum;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int columns = int.Parse(Console.ReadLine());

        double[,] matrix = new double[rows, columns];

        // Вводим значения элементов матрицы
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Введите элемент [{i}, {j}]: ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double sum = MatrixLibrary.MatrixOperations.CalculateSumOfMinMax(matrix);

        Console.WriteLine("Сумма максимального и минимального элементов матрицы: " + sum);
    }
}