// замена строк в двухмерном массиве

int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

/// summary - описание метода, 3 слэша
/// m- строчик, n - столбцы  

int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
        }

    }
    return matrix;
}

/// PrintArray: int[,] matrix
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void ChangeRows (int[,] inputMatrix)
{
    int lastRowIndex = inputMatrix.GetLength(0) - 1;
    for (int i = 0; i < inputMatrix.GetLength(1); i++)
    {
        int temp = inputMatrix[0, i];
        inputMatrix[0, i] = inputMatrix[lastRowIndex, i];
        inputMatrix[lastRowIndex, i] = temp;
    }
}

int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
Console.WriteLine("Результат: ");ChangeRows(resultMatrix);
PrintArray(resultMatrix);