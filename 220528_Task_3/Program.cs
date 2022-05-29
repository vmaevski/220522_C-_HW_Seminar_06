// 3. Напишите программу, которая будет создавать 
// копию заданного 2-мерного массива с помощью поэлементного копирования.

int[,] RandomArray(int row, int column, int from, int to)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(from, to);
        }
    }
    return array;
}

int[,] CopyArray(int[,] array)
{
    int new_row = array.GetLength(0);
    int new_column = array.GetLength(1);
    int[,] new_array = new int[new_row, new_column];
    for (int i = 0; i < new_row; i++)
    {
        for (int j = 0; j < new_column; j++)
        {
            new_array[i, j] = array[i, j];
        }
    }
    return new_array;
}

void PrintArray(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array_1 = RandomArray(5, 5, 0, 10);
PrintArray(array_1);
int[,] copy_array_1 = CopyArray(array_1);
PrintArray(copy_array_1);