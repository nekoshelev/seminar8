// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 6);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

int size = Prompt("Введите размер матриц > ");
int[,] matA = new int[size, size];
int[,] matB = new int[size, size];
FillArrayRandomNumbers(matA);
FillArrayRandomNumbers(matB);
int[,] proizv = new int[size, size];


for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            proizv[i, j] = proizv[i, j] + (matA[i, k] * matB[k, j]);
        }
    }
}
Console.WriteLine("Первая матрица:");
PrintArray(matA);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
PrintArray(matB);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
PrintArray(proizv);
