//Задача 1: Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку массива.
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
            Array[i, j] = i + j;

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

void CangeArrayLine(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];

        array[0, i] = array[array.GetLength(0) - 1, i];

        array[array.GetLength(0) - 1, i] = temp;
    }


}

int[,] array1 = GenDobMass(3, 4);
PrintArray(array1);
CangeArrayLine(array1);
Console.WriteLine();
PrintArray(array1);
