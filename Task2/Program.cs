// Задайте двумерный массив. Напишите программу,
//которая заменяет строки на столбцы. В случае,
//если это невозможно, программа должна вывести сообщение
//для пользователя.

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

void CangeArrayLine2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];

            array[j, i] = temp;
        }

    }

}

int[,] array1 = GenDobMass(3, 3);
PrintArray(array1);
CangeArrayLine2(array1);
Console.WriteLine();
PrintArray(array1);