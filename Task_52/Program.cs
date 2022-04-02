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

Console.Write("Введите количество строк в массиве: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[str, column];
CreatArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Таблица средних арифметических значений: ");

int u;
double count;
double srznach;

for(int p = 0; p < array.GetLength(0); p++)
{
    count = 0;
    srznach = 0;
    u = 0;
    for(int t = 0; t < array.GetLength(1); t++)
    {
        count += array[p, t];
        u++;
    }
    srznach = count / u;
    Console.Write("{0:0.00}", srznach);
    Console.WriteLine(";");
}