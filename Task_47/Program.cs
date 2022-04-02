void CreatArray(double[,] mas)
{
    for(int i = 0; i < mas.GetLength(0); i++)
    {
        for(int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = new Random().NextDouble() * 20;
        }
    }
}

void PrintArray(double[,] mas)
{
    for(int k = 0; k < mas.GetLength(0); k++)
    {
        for(int m = 0; m < mas.GetLength(1); m++)
        {
            Console.Write("{0:0.00}", mas[k, m]);
            Console.Write("; ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк в массиве: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[str, column];
CreatArray(array);
PrintArray(array);
