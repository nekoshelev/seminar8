// Задача 3: Составить частотный словарь элементов
//двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.
//Значения элементов массива 0..9
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

int[] ElementsCount(int[,] array)
{
    int[] CountArray = new int[10];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            CountArray[array[i, j]]++;
        }


    }
    return CountArray;
}
void PrintArrayOne(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
    System.Console.WriteLine();
}
int[,] array1 = GenDobMass(3, 3);
PrintArray(array1);
int[] element1 = ElementsCount(array1);
PrintArrayOne(element1);