using System;

class Matrix
{
    private double[,] data;

    public Matrix(int rows, int columns)
    {
        data = new double[rows, columns];
    }

    public void SetValue(int row, int column, double value)
    {
        if (row >= 0 && row < data.GetLength(0) && column >= 0 && column < data.GetLength(1))
        {
            data[row, column] = value;
        }
        else
        {
            throw new ArgumentOutOfRangeException("Индекс вне допустимого диапазона.");
        }
    }

    public void Display()
    {
        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                Console.Write($"{data[i, j]:F2}\t");
            }
            Console.WriteLine();
        }
    }

    public static Matrix operator +(Matrix matrix, int columnIndex)
    {
        if (columnIndex < 0 || columnIndex >= matrix.data.GetLength(1))
        {
            throw new ArgumentOutOfRangeException("Номер столбца вне диапазона.");
        }

        Matrix result = new Matrix(matrix.data.GetLength(0), matrix.data.GetLength(1));

        for (int i = 0; i < matrix.data.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.data.GetLength(1); j++)
            {
                result.data[i, j] = matrix.data[i, j];
                if (j == 0) // добавляем значения из указанного столбца к первому
                {
                    result.data[i, j] += matrix.data[i, columnIndex];
                }
            }
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        Matrix matrix = new Matrix(3, 3);

        matrix.SetValue(0, 0, 1.0);
        matrix.SetValue(0, 1, 2.0);
        matrix.SetValue(0, 2, 3.0);
        matrix.SetValue(1, 0, 4.0);
        matrix.SetValue(1, 1, 5.0);
        matrix.SetValue(1, 2, 6.0);
        matrix.SetValue(2, 0, 7.0);
        matrix.SetValue(2, 1, 8.0);
        matrix.SetValue(2, 2, 9.0);

        Console.WriteLine("Исходная матрица:");
        matrix.Display();

        int columnToAdd = 1;
        Matrix updatedMatrix = matrix + columnToAdd;

        Console.WriteLine($"Матрица после добавления столбца {columnToAdd} к первому столбцу:");
        updatedMatrix.Display();
    }
}
