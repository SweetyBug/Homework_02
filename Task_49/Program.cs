void CreatArray(int[,] mas)
{
    for(int i = 0; i < mas.GetLength(0); i++)
    {
        for(int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = new Random().Next(10, 100);
        }
    }
}

void PrintArray(int[,] mas)
{
    for(int k = 0; k < mas.GetLength(0); k++)
    {
        for(int m = 0; m < mas.GetLength(1); m++)
        {
            Console.Write(mas[k, m] + "; ");
        }
        Console.WriteLine();
    }
}

void ReplacementArray(int[,] mas)
{
    for(int i = 0; i < mas.GetLength(0); i++)
    {
        for(int j = 0; j < mas.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
            {
                mas[i, j] *= mas[i, j];
            }
        }
    }
}

Console.Write("Введите количество строк в массиве: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[str, column];
CreatArray(array);
PrintArray(array);
Console.WriteLine();
ReplacementArray(array);
PrintArray(array);
