// Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int rows = 3;
int columns = 3;

int[,] matrix = new int[rows, columns];

int minElement = int.MaxValue;
int indexRowMin = 0;
int indexColumnsMin = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11);
        Console.Write(matrix[i, j] + " ");
        if (minElement > matrix[i, j]) // 5 > 0 , min =0 
        {
            minElement = matrix[i, j];
            indexRowMin = i;
            indexColumnsMin = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine(minElement);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (indexRowMin != i)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (indexColumnsMin != j)
            {
                Console.Write(matrix[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}
     

