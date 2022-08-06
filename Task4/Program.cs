// Задача 4: Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец,
//на пересечении которых расположен наименьший элемент массива.
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenDobMass(int m, int n)
{
    int[,] Array = new int[m, n];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(0, 10);

        }
    }
    return Array;
}
void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }

    System.Console.WriteLine();
}

(int, int) FoundMinEliment(int[,] array)
{
    int column = 0;
    int row = 0;

    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                column = j;
                row = i;
            }

        }

    }
    return (row, column);
}

int[,] DeleteNewArray(int[,] array, int r, int c)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int ii = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != r)
        {
            int jj = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i != r && j != c)

                {
                    result[ii, jj] = array[i, j];
                    jj++;
                }

            }
            ii++;
        }
    }
    return result;
}

int[,] array1 = GenDobMass(3, 3);
PrintArray(array1);
(int row, int column) = FoundMinEliment(array1);
Console.WriteLine($"{row},{column}");
int[,] delete = DeleteNewArray(array1, row, column);
PrintArray(delete);